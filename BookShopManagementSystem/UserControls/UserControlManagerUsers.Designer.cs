namespace BookShopManagementSystem.UserControls
{
    partial class UserControlManagerUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelManageUser = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(59, 153);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(69, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Username";
            // 
            // labelManageUser
            // 
            this.labelManageUser.AutoSize = true;
            this.labelManageUser.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUser.Location = new System.Drawing.Point(333, 42);
            this.labelManageUser.Name = "labelManageUser";
            this.labelManageUser.Size = new System.Drawing.Size(178, 34);
            this.labelManageUser.TabIndex = 1;
            this.labelManageUser.Text = "Manager User";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtUserName.Location = new System.Drawing.Point(180, 150);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Enabled = false;
            this.comboBoxRole.ForeColor = System.Drawing.Color.CadetBlue;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(586, 244);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(210, 27);
            this.comboBoxRole.TabIndex = 3;
            this.comboBoxRole.Text = "Select";
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPass.Location = new System.Drawing.Point(586, 181);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(210, 26);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(479, 153);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 19);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtFullName.Location = new System.Drawing.Point(586, 146);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(210, 26);
            this.txtFullName.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(76, 188);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(45, 19);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPhone.Location = new System.Drawing.Point(180, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Location = new System.Drawing.Point(459, 223);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(115, 19);
            this.labelMobile.TabIndex = 8;
            this.labelMobile.Text = "Change Password";
            // 
            // txtChangePass
            // 
            this.txtChangePass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtChangePass.Location = new System.Drawing.Point(586, 212);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(210, 26);
            this.txtChangePass.TabIndex = 11;
            this.txtChangePass.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(459, 188);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(93, 19);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Old Password";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtEmail.Location = new System.Drawing.Point(180, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(987, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(77, 223);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 19);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(706, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(586, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Location = new System.Drawing.Point(38, 255);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(120, 19);
            this.labelConfirmPass.TabIndex = 19;
            this.labelConfirmPass.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtConfirmPass.Location = new System.Drawing.Point(180, 252);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(210, 26);
            this.txtConfirmPass.TabIndex = 18;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(498, 251);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(35, 19);
            this.labelRole.TabIndex = 20;
            this.labelRole.Text = "Role";
            // 
            // UserControlMamagerUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChangePass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelManageUser);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlMamagerUsers";
            this.Size = new System.Drawing.Size(835, 378);
            this.Load += new System.EventHandler(this.UserControlMamagerUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelManageUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label labelRole;
    }
}
