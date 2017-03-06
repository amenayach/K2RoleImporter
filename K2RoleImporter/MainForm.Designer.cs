namespace K2RoleImporter
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.tbSecurity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.tbBrowseRoleFile = new System.Windows.Forms.TextBox();
            this.lblBrowseRoleFile = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAddRoles = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbTestUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(80, 27);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(221, 20);
            this.tbHost.TabIndex = 0;
            // 
            // tbDomain
            // 
            this.tbDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomain.Location = new System.Drawing.Point(405, 65);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(221, 20);
            this.tbDomain.TabIndex = 3;
            // 
            // tbSecurity
            // 
            this.tbSecurity.Location = new System.Drawing.Point(80, 65);
            this.tbSecurity.Name = "tbSecurity";
            this.tbSecurity.Size = new System.Drawing.Size(221, 20);
            this.tbSecurity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Security label";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(405, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(221, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(80, 100);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(221, 20);
            this.tbUserId.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "User Id";
            // 
            // numPort
            // 
            this.numPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPort.Location = new System.Drawing.Point(405, 28);
            this.numPort.Maximum = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(221, 20);
            this.numPort.TabIndex = 1;
            // 
            // tbBrowseRoleFile
            // 
            this.tbBrowseRoleFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrowseRoleFile.Location = new System.Drawing.Point(101, 138);
            this.tbBrowseRoleFile.Name = "tbBrowseRoleFile";
            this.tbBrowseRoleFile.Size = new System.Drawing.Size(498, 20);
            this.tbBrowseRoleFile.TabIndex = 10;
            // 
            // lblBrowseRoleFile
            // 
            this.lblBrowseRoleFile.AutoSize = true;
            this.lblBrowseRoleFile.Location = new System.Drawing.Point(12, 141);
            this.lblBrowseRoleFile.Name = "lblBrowseRoleFile";
            this.lblBrowseRoleFile.Size = new System.Drawing.Size(85, 13);
            this.lblBrowseRoleFile.TabIndex = 11;
            this.lblBrowseRoleFile.Text = "Browse roles file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(605, 136);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(21, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAddRoles
            // 
            this.btnAddRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoles.Location = new System.Drawing.Point(467, 164);
            this.btnAddRoles.Name = "btnAddRoles";
            this.btnAddRoles.Size = new System.Drawing.Size(159, 34);
            this.btnAddRoles.TabIndex = 13;
            this.btnAddRoles.Text = "&Add roles";
            this.btnAddRoles.UseVisualStyleBackColor = true;
            this.btnAddRoles.Click += new System.EventHandler(this.btnAddRoles_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Location = new System.Drawing.Point(15, 216);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(611, 185);
            this.tbStatus.TabIndex = 14;
            this.tbStatus.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // tbTestUser
            // 
            this.tbTestUser.Location = new System.Drawing.Point(80, 172);
            this.tbTestUser.Name = "tbTestUser";
            this.tbTestUser.Size = new System.Drawing.Size(221, 20);
            this.tbTestUser.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Test User";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 413);
            this.Controls.Add(this.tbTestUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnAddRoles);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbBrowseRoleFile);
            this.Controls.Add(this.lblBrowseRoleFile);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.tbSecurity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "K2 Roles Importer";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.TextBox tbSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox tbBrowseRoleFile;
        private System.Windows.Forms.Label lblBrowseRoleFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAddRoles;
        private System.Windows.Forms.RichTextBox tbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbTestUser;
        private System.Windows.Forms.Label label7;
    }
}

