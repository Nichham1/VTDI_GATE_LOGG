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
    public partial class UserManagementForm : Form
    {
        private vtdi_gatelog_dbEntities1 Ctx;

        public UserManagementForm()
        {
            InitializeComponent();
        }
    }
}
