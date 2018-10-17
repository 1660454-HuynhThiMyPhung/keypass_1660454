using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace lockfolrder_1660454
{
    public partial class Form1 : Form
    {
        public string status;
        private string _pathkey;
        string[] arr;
        public Form1()
        {
            InitializeComponent();
            arr = new string[6];
            arr[0] = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            arr[1] = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}";
            arr[2] = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}";
            arr[3] = ".{645FF040-5081-101B-9F08-00AA002F954E}";
            arr[4] = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}";
            arr[5] = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}";

            this.status = arr[0];
        }

        public string pathkey
        {
            get { return _pathkey; }
            set { _pathkey = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lockey dlg2 = new lockey();
            dlg2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unlock dlg22 = new unlock();
            dlg22.ShowDialog();
        }
        private string getstatus(string stat)
        {
            for (int i = 0; i < 6; i++)
                if (stat.LastIndexOf(arr[i]) != -1)
                    stat = stat.Substring(stat.LastIndexOf("."));
            return stat;
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                string selectedpath = d.Parent.FullName + d.Name;
                if (folderBrowserDialog1.SelectedPath.LastIndexOf(".{") == -1)
                {
                    this.setpassword(folderBrowserDialog1.SelectedPath);

                    if (!d.Root.Equals(d.Parent.FullName))
                        d.MoveTo(d.Parent.FullName + "\\" + d.Name + status);
                    else d.MoveTo(d.Parent.FullName + d.Name + status);
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                    MessageBox.Show("Đã khóa thành công", "Thành công ...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    status = getstatus(status);
                    bool s = checkpassword();
                    if (s)
                    {
                        File.Delete(folderBrowserDialog1.SelectedPath + "\\p.xml");
                        d.MoveTo(folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(".")));
                        textBox1.Text = folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf("."));
                        MessageBox.Show("Mở khóa thành công", "Thành công ...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("xui", "Thành công ...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }

        }
        private bool checkpassword()
        {
            XmlTextReader read;
            if (pathkey == null)
                read = new XmlTextReader(folderBrowserDialog1.SelectedPath + "\\p.xml");
            else
                read = new XmlTextReader(pathkey + "\\p.xml");
            if (read.ReadState == ReadState.Error)
                return true;
            else
            {
                try
                {
                    while (read.Read())
                    {
                        if (read.NodeType == XmlNodeType.Text)
                        {
                            unlock c = new unlock();
                            c.pass = read.Value;
                            if (c.ShowDialog() == DialogResult.OK)
                            {
                                read.Close();
                                return true;
                            }
                        }
                    }
                }
                catch { return true; }

            }
            read.Close();
            return true;
        }

        private Boolean setpassword(string path)
        {
            lockey p = new lockey();
            p.path = path;
            p.ShowDialog(); 
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.pathkey != null)
            {

                DirectoryInfo d = new DirectoryInfo(pathkey);
                string selectedpath = d.Parent.FullName + d.Name;
                if (pathkey.LastIndexOf(".{") == -1)
                {
                    textBox1.Text = pathkey;
                    DialogResult r;
                    r = MessageBox.Show("Bạn muốn tạo mật khẩu không ? ", "Vấn đề ...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        setpassword(pathkey);
                    }
                    status = arr[0];
                    if (!d.Root.Equals(d.Parent.FullName))
                        d.MoveTo(d.Parent.FullName + "\\" + d.Name + status);
                    else d.MoveTo(d.Parent.FullName + d.Name + status);
                }
                else
                {
                    status = getstatus(status);
                    bool s = checkpassword();
                    if (s)
                    {
                        File.Delete(folderBrowserDialog1.SelectedPath + "\\p.xml");
                        d.MoveTo(folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf(".")));
                        textBox1.Text = folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf("."));
                        MessageBox.Show("Mở khóa thành công", "Thành công ...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
