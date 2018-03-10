using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulkhead
{
    public partial class Form1 : Form
    {
        SuperVar GLOBAL = new SuperVar();
        public Form1()
        {
            InitializeComponent();
            CodeColumn.Width = 25;
            URLColumn.Width = FileList.Width - 26;
        }
        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        public IEnumerable<int> IntRange(int start, int end)
        {
            int rs = start;
            int re = end;
            if(start > end)
            {
                rs = end;
                re = start;
            }
            for (int i = rs; i <= re; i++)
            {
                yield return i;
            }
        }

        private void StartBGW()
        {
            switch (GLOBAL.Stage)
            {
                case SuperVar.Stages.NotStarted:
                    Action.Enabled = false;
                    FileList.Items.Clear();
                    TextStatus.Text = "Stage: Generating";
                    Generator.RunWorkerAsync(GLOBAL);
                    break;
                case SuperVar.Stages.Generating:
                    Action.Enabled = false;
                    TextStatus.Text = "Stage: Downloading";
                    Downloader.RunWorkerAsync(GLOBAL);
                    break;
                default:
                    MessageBox.Show("Unknown state", "State Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Action_Click(object sender, EventArgs e)
        {
            StartBGW();
        }

        private void Generate(object sender, DoWorkEventArgs e)
        {
            SuperVar sv = e.Argument as SuperVar;
            sv.Stage = SuperVar.Stages.Generating;
            string fp = sv.FilePattern;
            List<string[]> matrix = new List<string[]>();
            string[] parts = fp.Split('{');
            sv.Count = 0;
            sv.Total = parts.Length;
            foreach (string part in parts)
            {
                sv.Status = "Generating group possibilities...";
                sv.Count++;
                Generator.ReportProgress(0, new object[] { sv, null });
                if(part.Contains("}"))
                {
                    string pattern = part.Split('}')[0];
                    string thing = part.Split('}')[1];
                    List<string> possibility = new List<string>();
                    if(pattern.Contains("|"))
                    {
                        possibility.AddRange(pattern.Split('|'));
                    }
                    else if(pattern.Contains("-"))
                    {
                        int start, end;
                        string[] range = pattern.Split('-');
                        if (range.Length != 2)
                        {
                            e.Result = false;
                            MessageBox.Show("Too many dashes in pattern.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if(range[0].Length == 0 || range[1].Length == 0)
                        {
                            e.Result = false;
                            MessageBox.Show("A range must have both a start and an end.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (range[0].Length == 1 && range[1].Length == 1)
                        {
                            start = range[0][0];
                            end = range[1][0];

                            if (!(start >= 32 && end <= 126))
                            {
                                e.Result = false;
                                MessageBox.Show("Invalid character range. Please make sure your characters are between ASCII codes 32 and 126.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            foreach (int ch in IntRange(start, end))
                            {
                                possibility.Add(Convert.ToChar(ch).ToString());
                            }
                        }
                        else
                        {
                            try
                            {
                                end = int.Parse(range[1]);
                                int pad = 0;
                                if(range[0].StartsWith("p"))
                                {
                                    start = int.Parse(range[0].Substring(1));
                                    pad = (start < end) ? end.ToString().Length : start.ToString().Length;
                                }
                                else
                                    start = int.Parse(range[0]);
                                foreach (int num in IntRange(start, end))
                                {
                                    string p = num.ToString();
                                    while (p.Length < pad)
                                        p = "0" + p;
                                    possibility.Add(p);
                                }
                            }
                            catch
                            {
                                e.Result = false;
                                MessageBox.Show("Unable to parse range.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    matrix.Add(possibility.ToArray());
                    if(thing != "" && thing != null)
                        matrix.Add(new string[] { thing });
                    possibility.Clear();
                }
                else
                {
                    if (part != "" && part != null)
                        matrix.Add(new string[] { part });
                }
            }
            sv.Total = 1;
            foreach (string[] arr in matrix)
            {
                sv.Total = sv.Total * arr.Length;
            }
            sv.Count = 0;

            sv.Status = "Generating possibilities...";
            foreach (string[] possibility in (new MatrixWalker<string>(matrix.ToArray())).Get())
            {
                sv.Count++;
                sv.Possibilities.Add(string.Join("", possibility));
                Generator.ReportProgress(0, new object[] { sv, sv.Possibilities.Last() });
            }
            sv.Status = "Finished";
            e.Result = sv;
        }

        private void GeneratedItem(object sender, ProgressChangedEventArgs e)
        {
            object[] gen = e.UserState as object[];
            SuperVar sv = gen[0] as SuperVar;
            if (gen[1] is string file)
            {
                ListViewItem i = new ListViewItem("");
                i.SubItems.Add(file);
                FileList.Items.Add(i);
            }

            if (ProgStatus.Maximum != sv.Total)
            {
                ProgStatus.Value = 0;
                ProgStatus.Maximum = sv.Total;
            }
            ProgStatus.Value = sv.Count;
        }

        private void Generated(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AutoContinue.Checked && e.Result is SuperVar)
                StartBGW();
            else if (!(e.Result is null) && (bool)e.Result == false)
                GLOBAL.Stage = SuperVar.Stages.NotStarted;
            else
            {
                Action.Enabled = true;
                ProgStatus.Value = 0;
                TextStatus.Text = "Ready.";
            }
        }

        private void Download(object sender, DoWorkEventArgs e)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Bulkhead\\" + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            SuperVar sv = e.Argument as SuperVar;
            string name = "";
            sv.Stage = SuperVar.Stages.Downloading;
            sv.Total = sv.Possibilities.Count;
            sv.Count = 0;
            e.Result = false;
            foreach (string url in sv.Possibilities)
            {
                if (Downloader.CancellationPending)
                {
                    e.Result = true;
                    return;
                }
                sv.Count++;
                HttpWebResponse response = null;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                object[] update = new object[2];
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    name = sv.Count.ToString();
                    while (name.Length < sv.Total.ToString().Length)
                        name = "0" + name;
                    name += "." + url.Split('.').Last();
                    if (!Directory.Exists(filepath))
                        Directory.CreateDirectory(filepath);
                    byte[] buf = new byte[1024];
                    Stream str = (response.GetResponseStream());
                    FileStream fs = new FileStream(filepath + "\\" + name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    sv.FileSize = response.ContentLength;
                    CancellationToken ct = new CancellationToken(Downloader.CancellationPending);
                    Task t = str.CopyToAsync(fs, 1024, ct);
                    FileInfo fi = new FileInfo(filepath + "\\" + name);
                    while (!t.IsCompleted)
                    {
                        if (Downloader.CancellationPending)
                        {
                            t.Wait();
                            fs.Close();
                            str.Close();
                            e.Result = true;
                            return;
                        }
                        sv.Position = fi.Length;
                        Downloader.ReportProgress(0, null);
                        fi = new FileInfo(filepath + "\\" + name);
                    }
                    fs.Close();
                    str.Close();
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        response = (HttpWebResponse)ex.Response;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + url, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (response != null)
                    {
                        update[0] = url;
                        update[1] = (int)response.StatusCode;
                        response.Close();
                    }
                }
                Downloader.ReportProgress(0, update);
                int sleep = new Random().Next(200, 400);
                Thread.Sleep(sleep);
            }
            if (Directory.Exists(filepath))
                e.Result = filepath;
            else
                e.Result = false;
        }
        private void DownloadProgressed(object sender, ProgressChangedEventArgs e)
        {
            if(e.UserState == null)
            {
                if (ProgStatus.Value > 100)
                    ProgStatus.Value = 0;
                ProgStatus.Maximum = 100;
                ProgStatus.Value = (int)Math.Floor((decimal)(GLOBAL.Position / GLOBAL.FileSize * 100));
                TextStatus.Text = BytesToString(GLOBAL.Position) + " of " + BytesToString(GLOBAL.FileSize);
            }
            else
            {
                object[] update = e.UserState as object[];
                string url = (string)update[0];
                int code = (int)update[1];
                ListViewItem i = FileList.FindItemWithText(url, true, 0);
                i.EnsureVisible();
                if (code == 404)
                    FileList.Items.Remove(i);
                else if (code != 200)
                    i.Text = ("☠");
                else
                    i.Text = ("✔");
            }
        }

        private void DownloadComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            Action.Enabled = true;
            object result = e.Result;
            if(result.GetType() == typeof(string))
            {
                string dir = (e.Result as string);
                if (Directory.Exists(dir))
                    Process.Start(dir);
            }
            else if (result.GetType() == typeof(bool))
            {
                if ((bool)result == true)
                {
                    MessageBox.Show("You have opted to cancel your download.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("None of the URLs generated are downloadable.", "Nothing to Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("There was a problem during the download process.", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GLOBAL = new SuperVar
            {
                FilePattern = FilePattern.Text
            };
            TextStatus.Text = "Done. Ready.";
            FileList.Invalidate();
            FileList.Update();
        }

        private void PatternChanged(object sender, EventArgs e)
        {
            GLOBAL.FilePattern = FilePattern.Text;
        }

        private void InsertNumberRange(object sender, EventArgs e)
        {
            string fp = FilePattern.Text;
            fp += (NR_Pad.Checked) ? "{p" : "{";
            fp += NR_Start.Value.ToString();
            fp += "-";
            fp += NR_End.Value.ToString();
            fp += "}";
            FilePattern.Text = fp;
        }

        private void QuickInsert(object sender, EventArgs e)
        {
            FilePattern.Text += (sender as Button).Tag;
        }

        private void ResizeColumns(object sender, EventArgs e)
        {
            CodeColumn.Width = 25;
            URLColumn.Width = FileList.Width - 26;
        }

        private void ResizeStatus(object sender, EventArgs e)
        {
            if (CodeColumn.Width != 25)
                CodeColumn.Width = 25;
        }
    }
}
