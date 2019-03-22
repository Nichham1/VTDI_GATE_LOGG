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
    public partial class Form1 : Form
    {
        public Boolean isloggedin = false;

        public void Loggedin()
        {
            LoginForm login = new LoginForm();
            login.MdiParent = this;
            login.Show();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin();} else{ MessageBox.Show("You are already logged in"); }
            
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin(); } else
            {
                UserManagementForm userm = new UserManagementForm();
                userm.MdiParent = this;
                userm.Show();  }
        }

        private void SchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin(); } else { MessageBox.Show("You clicked on Gatelist"); }
        }

        private void GateInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin(); } else {
                GateLogForm Gatelog = new GateLogForm();
                Gatelog.MdiParent = this;
                Gatelog.Show(); }
        }

        private void UserLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin(); } else { MessageBox.Show("You clicked on User logs "); }
        }

        private void GateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isloggedin == false) { Loggedin(); } else { MessageBox.Show("You cliked on Gate reports "); }
        }
    }
}
