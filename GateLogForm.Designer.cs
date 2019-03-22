namespace VTDI_GATE_LOGG
{
    partial class GateLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btsubmit = new System.Windows.Forms.Button();
            this.Btreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbpurpose = new System.Windows.Forms.ComboBox();
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vtdi_gatelog_dbDataSet = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSet();
            this.Tbfirstname = new System.Windows.Forms.TextBox();
            this.Tblicense = new System.Windows.Forms.TextBox();
            this.Tblastname = new System.Windows.Forms.TextBox();
            this.Cbitemstodeclear = new System.Windows.Forms.ComboBox();
            this.CbVehiclemod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purposeTableAdapter = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSetTableAdapters.purposeTableAdapter();
            this.vtdi_gatelog_dbDataSet1 = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSet1();
            this.itemtodeclearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtodeclearTableAdapter = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSet1TableAdapters.ItemtodeclearTableAdapter();
            this.vtdi_gatelog_dbDataSet2 = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSet2();
            this.vehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypeTableAdapter = new VTDI_GATE_LOGG.vtdi_gatelog_dbDataSet2TableAdapters.VehicleTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtodeclearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btsubmit
            // 
            this.Btsubmit.Location = new System.Drawing.Point(131, 245);
            this.Btsubmit.Name = "Btsubmit";
            this.Btsubmit.Size = new System.Drawing.Size(75, 23);
            this.Btsubmit.TabIndex = 0;
            this.Btsubmit.Text = "Submit";
            this.Btsubmit.UseVisualStyleBackColor = true;
            this.Btsubmit.Click += new System.EventHandler(this.Btsubmit_Click);
            // 
            // Btreset
            // 
            this.Btreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btreset.Location = new System.Drawing.Point(252, 245);
            this.Btreset.Name = "Btreset";
            this.Btreset.Size = new System.Drawing.Size(75, 23);
            this.Btreset.TabIndex = 1;
            this.Btreset.Text = "Reset";
            this.Btreset.UseVisualStyleBackColor = true;
            this.Btreset.Click += new System.EventHandler(this.Btreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name ";
            // 
            // Cbpurpose
            // 
            this.Cbpurpose.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purposeBindingSource, "Id", true));
            this.Cbpurpose.DataSource = this.purposeBindingSource;
            this.Cbpurpose.DisplayMember = "Name";
            this.Cbpurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbpurpose.FormattingEnabled = true;
            this.Cbpurpose.Location = new System.Drawing.Point(252, 35);
            this.Cbpurpose.Name = "Cbpurpose";
            this.Cbpurpose.Size = new System.Drawing.Size(194, 21);
            this.Cbpurpose.TabIndex = 3;
            this.Cbpurpose.ValueMember = "Id";
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "purpose";
            this.purposeBindingSource.DataSource = this.vtdi_gatelog_dbDataSet;
            // 
            // vtdi_gatelog_dbDataSet
            // 
            this.vtdi_gatelog_dbDataSet.DataSetName = "vtdi_gatelog_dbDataSet";
            this.vtdi_gatelog_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tbfirstname
            // 
            this.Tbfirstname.Location = new System.Drawing.Point(12, 36);
            this.Tbfirstname.Name = "Tbfirstname";
            this.Tbfirstname.Size = new System.Drawing.Size(194, 20);
            this.Tbfirstname.TabIndex = 4;
            // 
            // Tblicense
            // 
            this.Tblicense.Location = new System.Drawing.Point(12, 175);
            this.Tblicense.Name = "Tblicense";
            this.Tblicense.Size = new System.Drawing.Size(194, 20);
            this.Tblicense.TabIndex = 4;
            // 
            // Tblastname
            // 
            this.Tblastname.Location = new System.Drawing.Point(12, 103);
            this.Tblastname.Name = "Tblastname";
            this.Tblastname.Size = new System.Drawing.Size(194, 20);
            this.Tblastname.TabIndex = 4;
            // 
            // Cbitemstodeclear
            // 
            this.Cbitemstodeclear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemtodeclearBindingSource, "Id", true));
            this.Cbitemstodeclear.DataSource = this.itemtodeclearBindingSource;
            this.Cbitemstodeclear.DisplayMember = "Name";
            this.Cbitemstodeclear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbitemstodeclear.FormattingEnabled = true;
            this.Cbitemstodeclear.Location = new System.Drawing.Point(252, 102);
            this.Cbitemstodeclear.Name = "Cbitemstodeclear";
            this.Cbitemstodeclear.Size = new System.Drawing.Size(194, 21);
            this.Cbitemstodeclear.TabIndex = 3;
            this.Cbitemstodeclear.ValueMember = "Id";
            // 
            // CbVehiclemod
            // 
            this.CbVehiclemod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehicleTypeBindingSource, "Id", true));
            this.CbVehiclemod.DataSource = this.vehicleTypeBindingSource;
            this.CbVehiclemod.DisplayMember = "Name";
            this.CbVehiclemod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVehiclemod.FormattingEnabled = true;
            this.CbVehiclemod.Location = new System.Drawing.Point(252, 174);
            this.CbVehiclemod.Name = "CbVehiclemod";
            this.CbVehiclemod.Size = new System.Drawing.Size(194, 21);
            this.CbVehiclemod.TabIndex = 3;
            this.CbVehiclemod.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purpose of Visit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Items to Declare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "License Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vebicle Model";
            // 
            // purposeTableAdapter
            // 
            this.purposeTableAdapter.ClearBeforeFill = true;
            // 
            // vtdi_gatelog_dbDataSet1
            // 
            this.vtdi_gatelog_dbDataSet1.DataSetName = "vtdi_gatelog_dbDataSet1";
            this.vtdi_gatelog_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtodeclearBindingSource
            // 
            this.itemtodeclearBindingSource.DataMember = "Itemtodeclear";
            this.itemtodeclearBindingSource.DataSource = this.vtdi_gatelog_dbDataSet1;
            // 
            // itemtodeclearTableAdapter
            // 
            this.itemtodeclearTableAdapter.ClearBeforeFill = true;
            // 
            // vtdi_gatelog_dbDataSet2
            // 
            this.vtdi_gatelog_dbDataSet2.DataSetName = "vtdi_gatelog_dbDataSet2";
            this.vtdi_gatelog_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTypeBindingSource
            // 
            this.vehicleTypeBindingSource.DataMember = "VehicleType";
            this.vehicleTypeBindingSource.DataSource = this.vtdi_gatelog_dbDataSet2;
            // 
            // vehicleTypeTableAdapter
            // 
            this.vehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // GateLogForm
            // 
            this.AcceptButton = this.Btsubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Btreset;
            this.ClientSize = new System.Drawing.Size(469, 323);
            this.Controls.Add(this.Tblastname);
            this.Controls.Add(this.Tblicense);
            this.Controls.Add(this.Tbfirstname);
            this.Controls.Add(this.CbVehiclemod);
            this.Controls.Add(this.Cbitemstodeclear);
            this.Controls.Add(this.Cbpurpose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btreset);
            this.Controls.Add(this.Btsubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "GateLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GateLogForm";
            this.Load += new System.EventHandler(this.GateLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtodeclearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelog_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btsubmit;
        private System.Windows.Forms.Button Btreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbpurpose;
        private System.Windows.Forms.TextBox Tbfirstname;
        private System.Windows.Forms.TextBox Tblicense;
        private System.Windows.Forms.TextBox Tblastname;
        private System.Windows.Forms.ComboBox Cbitemstodeclear;
        private System.Windows.Forms.ComboBox CbVehiclemod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private vtdi_gatelog_dbDataSet  vtdi_gatelog_dbDataSet;
        private System.Windows.Forms.BindingSource purposeBindingSource;
        private vtdi_gatelog_dbDataSetTableAdapters.purposeTableAdapter purposeTableAdapter;
        private vtdi_gatelog_dbDataSet1 vtdi_gatelog_dbDataSet1;
        private System.Windows.Forms.BindingSource itemtodeclearBindingSource;
        private vtdi_gatelog_dbDataSet1TableAdapters.ItemtodeclearTableAdapter itemtodeclearTableAdapter;
        private vtdi_gatelog_dbDataSet2 vtdi_gatelog_dbDataSet2;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource;
        private vtdi_gatelog_dbDataSet2TableAdapters.VehicleTypeTableAdapter vehicleTypeTableAdapter;
    }
}