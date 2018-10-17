using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace lockfolrder_1660454
{
    public partial class lockey : Form
    {
        public string path;
        public lockey()
        {
            InitializeComponent();
        }

        private void khóa_Click(object sender, EventArgs e)
        {
            if (pass1.Text.Equals(pass1.Text))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement xmlelem;
                XmlNode xmlnode;
                XmlText xmltext;
                xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xmldoc.AppendChild(xmlnode);
                xmlelem = xmldoc.CreateElement("", "ROOT", "");
                xmltext = xmldoc.CreateTextNode(pass1.Text);
                xmlelem.AppendChild(xmltext);
                xmldoc.AppendChild(xmlelem);
                xmldoc.Save(path + "\\p.xml");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu không giống nhau", "Cảnh báo...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pass1.Clear();
                pass1.Clear();
                pass1.Focus();
            }
        }
    }
}
