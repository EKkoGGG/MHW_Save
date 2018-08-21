using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WHW_Save
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private Process[] MyProcesses;
        static SmtpClient smt;
        public bool flag = true;
        public string path = Environment.CurrentDirectory + @"\Config.ini";
        public Form1()
        {
            InitializeComponent();
        }
        static void MakeSmtpConnection()
        {
            smt = new SmtpClient();
            smt.Host = "smtp.qq.com";
            smt.EnableSsl = true;
            smt.Credentials = new NetworkCredential("330564052@qq.com", "ovysprmezglkbifi");
        }

        static void SendMails(string Address, string FilePath)
        {
            var mm = new MailMessage();
            mm.From = new MailAddress("330564052@qq.com", "MHW_Save", Encoding.UTF8);
            mm.To.Add(new MailAddress("330564052@qq.com"));
            mm.BodyEncoding = Encoding.UTF8;
            mm.Subject = "Monster Hunter: World_Save";
            mm.Attachments.Add(new Attachment(FilePath));
            SendMail(mm);
        }

        static void SendMail(MailMessage ms)
        {
            smt.Send(ms);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                textEdit1.Text = openFileDialog1.FileName;

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textEdit2.Enabled = false;
                flag = false;
            }
            else
            {
                textEdit2.Enabled = true;
                flag = true;
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SaveMhw();

        }

        public void SaveMhw()
        {
            try
            {
                if (textEdit1.Text != "" && textEdit2.Text != "")
                {
                    MakeSmtpConnection();
                    string eMail = textEdit2.Text;
                    string adress = textEdit1.Text;
                    SendMails(eMail, adress);
                    MessageBox.Show("上传存档成功！");
                    smt.Dispose();
                    Thread.Sleep(1000);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("路径或邮箱不能为空！");
                }
            }
            catch
            {
                MessageBox.Show("上传失败，请检查路径或邮箱是否填写正确");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            IniFile ini = new IniFile(path);
            if (textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "")
            {
                ini.IniWriteValue("ini", "path", textEdit1.Text);
                ini.IniWriteValue("ini", "eMail", textEdit2.Text);
                ini.IniWriteValue("ini", "gamePath", textEdit3.Text);
                MessageBox.Show("保存配置成功");
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    info.Attributes = FileAttributes.Hidden;
                }
            }
            else
            {
                MessageBox.Show("路径或邮箱不能为空！");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(path);
            if (ini.ExistINIFile(path))
            {
                textEdit1.Text = ini.IniReadValue("ini", "path");
                textEdit2.Text = ini.IniReadValue("ini", "eMail");
                textEdit3.Text = ini.IniReadValue("ini", "gamePath");
            }
            else
            {
                MessageBox.Show("未找到配置文件，请开始配置");
            }
           
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog2.ShowDialog())
            {
                textEdit3.Text = openFileDialog2.FileName;

            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && MouseButtons.Left == e.Button)
            {
                WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Process.Start(textEdit3.Text);
            WindowState = FormWindowState.Minimized;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyProcesses = Process.GetProcesses();
            List<string> processName = new List<string>();
            foreach (var item in MyProcesses)
            {
                processName.Add(item.ProcessName);
            }
            bool mhw = processName.Contains("");
            if (!mhw)
            {
                timer1.Enabled = false;                
                SaveMhw();
                this.Close();

            }
        }
    }

    public class IniFile
    {
        public string Path;

        public IniFile(string path)
        {
            this.Path = path;
        }

        #region 声明读写INI文件的API函数

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);

        #endregion

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <param name="iValue">值</param>
        public void IniWriteValue(string section, string key, string iValue)
        {
            WritePrivateProfileString(section, key, iValue, this.Path);
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <returns>返回的键值</returns>
        public string IniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp.ToString();
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="Section">段，格式[]</param>
        /// <param name="Key">键</param>
        /// <returns>返回byte类型的section组或键值组</returns>
        public byte[] IniReadValues(string section, string key)
        {
            byte[] temp = new byte[255];

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp;
        }

        public bool ExistINIFile(string path)
        {
            return File.Exists(path);
        }
    }

}
