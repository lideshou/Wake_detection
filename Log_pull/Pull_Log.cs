using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Log_pull
{
    public partial class Pull_Log : Form
    {
        private Process p;
        private string output = "";
        private string cmd = @"C:\Users\HA21484\Desktop\Luxshare\AT_Command\platform-tools\adb.exe";
        private bool logflag = false;
        private StreamReader sr;
        public Pull_Log()
        {
            InitializeComponent();
        }

        private void btn_Pull_Click(object sender, EventArgs e)
        {
            if (logFlag() == true)
            {
                p = new Process();
                p.StartInfo.FileName = cmd;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments = @"pull /data/unisound/unisound.txt C:\Users\HA21484\Desktop\AM001WAKE\log";
                p.Start();
                p.WaitForExit();
                p.Close();
                this.label1.Text = getTimes().ToString();
            }
            else
            {
                MessageBox.Show("未找到该文件！");
            }
        }

        private bool logFlag()
        {
            p = new Process();
            p.StartInfo.FileName = cmd;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "shell ls /data/unisound";
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            if (output.Contains("unisound.txt"))
            {
                logflag = true;
            }
            p.WaitForExit();
            p.Close();
            return logflag;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (logFlag() == true)
            {
                p = new Process();
                p.StartInfo.FileName = cmd;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.Arguments = @"shell rm /data/unisound/unisound.txt";
                p.Start();
                p.WaitForExit();
                p.Close();
                MessageBox.Show("Success!");
                logflag = false;
            }
            else
            {
                MessageBox.Show("未找到该文件！");
            }
        }

        private int getTimes()
        {
            int count=0;
            sr = new StreamReader(@"C:\Users\HA21484\Desktop\AM001WAKE\log\unisound.txt",Encoding.Default);
            string line = sr.ReadToEnd();
            string[] str = line.Split('T');
            sr.Close();
            return count=str.Length-1;
        }
    }
}
