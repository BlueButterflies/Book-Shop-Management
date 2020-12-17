namespace BookShopManagementSystem.Forms
{
    partial class RegisterNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewUser));
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.picturePanelOne = new System.Windows.Forms.PictureBox();
            this.labelShopOne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.dargControl = new BookShopManagementSystem.CostumControl.DargControl();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelOne)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUp.Controls.Add(this.btnBack);
            this.panelUp.Controls.Add(this.picturePanelOne);
            this.panelUp.Controls.Add(this.labelShopOne);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.ForeColor = System.Drawing.Color.Aqua;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(707, 73);
            this.panelUp.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(664, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 73);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picturePanelOne
            // 
            this.picturePanelOne.BackColor = System.Drawing.Color.CadetBlue;
            this.picturePanelOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.picturePanelOne.Image = ((System.Drawing.Image)(resources.GetObject("picturePanelOne.Image")));
            this.picturePanelOne.Location = new System.Drawing.Point(0, 0);
            this.picturePanelOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePanelOne.Name = "picturePanelOne";
            this.picturePanelOne.Size = new System.Drawing.Size(66, 73);
            this.picturePanelOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanelOne.TabIndex = 3;
            this.picturePanelOne.TabStop = false;
            // 
            // labelShopOne
            // 
            this.labelShopOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelShopOne.AutoSize = true;
            this.labelShopOne.BackColor = System.Drawing.Color.CadetBlue;
            this.labelShopOne.Font = new System.Drawing.Font("Comic Sans MS", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopOne.ForeColor = System.Drawing.Color.White;
            this.labelShopOne.Location = new System.Drawing.Point(247, 9);
            this.labelShopOne.Name = "labelShopOne";
            this.labelShopOne.Size = new System.Drawing.Size(212, 50);
            this.labelShopOne.TabIndex = 2;
            this.labelShopOne.Text = "Books Shop";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 27);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Copyrights © 2020.All rights reserved  by BlueButterfliesDev";
            // 
            // labelRole
            // 
            this.labelRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(441, 247);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 32);
            this.labelRole.TabIndex = 10;
            this.labelRole.Text = "Role";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(256, 333);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 46);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(439, 166);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(70, 32);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtEmail.Location = new System.Drawing.Point(445, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // labelPass
            // 
            this.labelPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(52, 248);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(112, 32);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Password";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPhone.Location = new System.Drawing.Point(58, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullName.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtFullName.Location = new System.Drawing.Point(445, 129);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(210, 26);
            this.txtFullName.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(52, 166);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(76, 32);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPass.Location = new System.Drawing.Point(58, 283);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(210, 26);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(439, 94);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(120, 32);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRole.ForeColor = System.Drawing.Color.CadetBlue;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboBoxRole.Location = new System.Drawing.Point(445, 282);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(210, 27);
            this.comboBoxRole.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtUserName.Location = new System.Drawing.Point(58, 129);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(52, 94);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(134, 32);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // dargControl
            // 
            this.dargControl.SelectControl = this;
            // 
            // RegisterNewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterNewUser";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelOne)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox picturePanelOne;
        private System.Windows.Forms.Label labelShopOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelUserName;
        private CostumControl.DargControl dargControl;
        private System.Windows.Forms.Button btnBack;
    }
}