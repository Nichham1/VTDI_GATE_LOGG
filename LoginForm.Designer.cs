namespace VTDI_GATE_LOGG
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btSubmit = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.pbUsericon = new System.Windows.Forms.PictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsericon)).BeginInit();
            this.SuspendLayout();
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(82, 203);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Submit ";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(188, 203);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.BtReset_Click);
            // 
            // pbUsericon
            // 
            this.pbUsericon.Image = ((System.Drawing.Image)(resources.GetObject("pbUsericon.Image")));
            this.pbUsericon.Location = new System.Drawing.Point(123, 30);
            this.pbUsericon.Name = "pbUsericon";
            this.pbUsericon.Size = new System.Drawing.Size(109, 91);
            this.pbUsericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsericon.TabIndex = 2;
            this.pbUsericon.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(43, 160);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(114, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(188, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(114, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(69, 144);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(63, 13);
            this.lbusername.TabIndex = 7;
            this.lbusername.Text = "User Name ";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(207, 144);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(56, 13);
            this.lbpassword.TabIndex = 5;
            this.lbpassword.Text = "Password ";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 276);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbUsericon);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbUsericon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox pbUsericon;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpassword;
    }
}