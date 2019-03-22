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
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            var Ctx = new vtdi_gatelog_dbEntities();
            var user = Ctx.Users.Any(q => q.UserName == username && q.Password == password);

            if (user)
            {
                MessageBox.Show($"Welcome{username}");
                var parent = (Form1)this.MdiParent;
                parent.isloggedin= true;
                this.Close();

            }else { MessageBox.Show("Invalid credentials"); }

        }
    }
}
