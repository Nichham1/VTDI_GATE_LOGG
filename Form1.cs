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
        Boolean isloggedin = false;

        public void Loggedin()
        {
            LoginForm login = new LoginForm();
            login.Show();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loggedin();
        }
    }
}
