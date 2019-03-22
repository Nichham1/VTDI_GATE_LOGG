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
    public partial class GateLogForm : Form
    {
        private vtdi_gatelog_dbEntities1 Ctx;

        public GateLogForm()
        {
            InitializeComponent();
        }

        private void GateLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet2.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.vtdi_gatelog_dbDataSet2.VehicleType);
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet1.Itemtodeclear' table. You can move, or remove it, as needed.
            this.itemtodeclearTableAdapter.Fill(this.vtdi_gatelog_dbDataSet1.Itemtodeclear);
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet.purpose' table. You can move, or remove it, as needed.
            this.purposeTableAdapter.Fill(this.vtdi_gatelog_dbDataSet.purpose);
            Ctx = new vtdi_gatelog_dbEntities1();
        }

        private void Btsubmit_Click(object sender, EventArgs e)
        {
            var fname = Tbfirstname.Text;
            var lname = Tblastname.Text;
            var platenumber = Tblicense.Text;
            var purpose = Cbpurpose.SelectedValue;
            var item = Cbitemstodeclear.SelectedValue;
            var model = CbVehiclemod.SelectedValue;
            var datetime = DateTime.Now;

            Gateinout record = new Gateinout();


            record.Firstname = fname;
            record.LastName = lname;
            record.PlateNumber = platenumber;
            record.PurposeID = (int)purpose;
            record.ItemstodeclereID = Convert.ToInt32(item);
            record.VehicleTypeID = (int)model;
            record.Datetimein = datetime;

            Ctx.Gateinouts.Add(record);
            Ctx.SaveChanges();

            MessageBox.Show("Data logged");
        }

        private void Btreset_Click(object sender, EventArgs e)
        {
            Tbfirstname.Clear();
            Tblastname.Clear();
            Tblicense.Clear();
        }
    }
}
