using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lockfolrder_1660454
{
    public partial class unlock : Form
    {
        public string pass;
        public bool status;
        public unlock()
        {
            status = false;
            InitializeComponent();
        }

        private void mo_Click(object sender, EventArgs e)
        {
           
            if (pass2.Text.Equals(pass))
            {
                status = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Lỗi ... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
        }
    }
}
