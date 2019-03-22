using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_GATE_LOGG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            LoginForm BtSubmit = new LoginForm();
            var username = tbUsername.Text;
            var password = tbPassword.Text;

            var Ctx = new vtdi_gatelog_dbEntities1();
            var user = Ctx.Users.Any(q => q.UserName == username && q.Password == password);

            if (user)
            {
                MessageBox.Show($"Welcome {username}");
                var parent = (Form1)this.MdiParent;
                parent.isloggedin= true;
                this.Close();

            }else { MessageBox.Show("Invalid credentials"); }

        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
                
        }
    }
}
