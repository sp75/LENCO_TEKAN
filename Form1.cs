using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LENCO_TEKAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fDialog = new FolderBrowserDialog();
            fDialog.SelectedPath = Input_folder_text.Text;
            fDialog.ShowDialog();
            Input_folder_text.Text = fDialog.SelectedPath;

            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fDialog = new FolderBrowserDialog();
            fDialog.SelectedPath = OutputFolderText.Text;
            fDialog.ShowDialog();
            OutputFolderText.Text = fDialog.SelectedPath;

            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            FileSystemWatcher watcher = new FileSystemWatcher(Input_folder_text.Text, "*.csv");
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;*/

            button1.Enabled = false;

            timer1.Start();

        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed)
            BuildFile(e.FullPath);
        }

        const string URL_LENCOLAB = "http://live.lencolink.com/tools/tecan/export_to_csv.aspx?id={0}";//"http://dev.lencolab.com/tools/tecan/export_to_csv.aspx?id={0}";
        const string LOG_FILE = "log.txt";
        void BuildFile(string FullPath)
        {
            try
            {
                FileStream s2 = new FileStream(FullPath, FileMode.Open);
                if (s2.CanRead && s2.CanWrite )
                {
                    s2.Close();
                    if (File.Exists(FullPath) && FullPath.IndexOf("_reply.csv") == -1)
                    {

                        string id = "";
                        string[] csv_f = File.ReadAllLines(FullPath);
                        WriteLog(String.Format("Read file [{0}]", FullPath));
                        if (Directory.Exists(ArhivetextBox.Text))
                        {
                            File.Delete(Path.Combine(ArhivetextBox.Text, Path.GetFileName(FullPath)));
                           
                        }

                        foreach (string item in csv_f)
                        {
                            if (String.IsNullOrEmpty(item))
                            {
                                continue;
                            }
                            id += item.Split( ',' )[0]/*.ToUpper().Trim('U')*/ + ",";
                        }

                        string fileout = Path.GetFileNameWithoutExtension(FullPath) + "_reply.csv";  

                        using (WebClient web = new WebClient())
                        {
                            web.Proxy = WebRequest.DefaultWebProxy;
                            web.Credentials = System.Net.CredentialCache.DefaultCredentials;
                            web.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                            web.Encoding = System.Text.Encoding.UTF8;

                            string download_file = Path.Combine(ArhivetextBox.Text, fileout);
                            string dowload_url = String.Format(URL_LENCOLAB, id.Trim(','));

                            WriteLog(String.Format("Start download file [{0}]", dowload_url));
                            web.DownloadFile(dowload_url, download_file);

                            if (File.Exists(download_file))
                            {
                                WriteLog(String.Format("Download successful [{0}]", download_file));

                                File.Copy(download_file, Path.Combine(OutputFolderText.Text, fileout), true);
                                WriteLog(String.Format("Copy to output folder [{0}]", Path.Combine(OutputFolderText.Text, fileout)));

                                File.Move(FullPath, Path.Combine(ArhivetextBox.Text, Path.GetFileName(FullPath)));

                                WriteLog(String.Format("File move from [{0}] to {1}", FullPath, Path.Combine(ArhivetextBox.Text, Path.GetFileName(FullPath))));
                            }
                            else
                            {
                                WriteLog("Error download file:" + dowload_url);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                WriteLog(String.Format( "{0} Exception caught.", e.Message));
            }

        }

        private void WriteLog(string str)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, LOG_FILE), true))
            {
                sw.WriteLine( "{0} : {1}", DateTime.Now, str );
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fDialog = new FolderBrowserDialog();
            fDialog.SelectedPath = ArhivetextBox.Text;
            fDialog.ShowDialog();
            ArhivetextBox.Text = fDialog.SelectedPath;

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked) button1.PerformClick();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(Input_folder_text.Text);
            foreach (string fileName in fileEntries)
                if (Path.GetExtension(fileName).ToLower() == ".csv" && fileName.IndexOf("_reply.csv") == -1) BuildFile(fileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            String content_body=@"
$
<span>{{teg1}}</span>
<span>{{teg2}}</span>
<span>{{teg3}}</span>
,
<span>{{teg4}}</span>
<span>{{teg5}}</span>
<span>{{teg6}}</span>
,
<span>{{teg7}}</span>
<span>{{teg8}}</span>
<span>{{teg9}}</span>
</div>";
                String dd = rnd.Next(897876, 23875775).ToString();
                  dd =   dd.PadLeft(9);
                  for (int i = 0; i < 9; i++)
                  {
                      content_body = content_body.Replace(String.Format("{{teg{0}}}",i), Convert.ToString(dd[i]));
                  }
                 
        

           //  _page.Replace("<?ext:derogatory_items_removed?>", content_body);
        }
    }
}
