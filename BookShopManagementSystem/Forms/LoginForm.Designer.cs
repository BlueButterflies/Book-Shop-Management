namespace BookShopManagementSystem.Forms
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
            this.labelForgotPass = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnCloseOne = new System.Windows.Forms.Button();
            this.picturePanelOne = new System.Windows.Forms.PictureBox();
            this.labelShopOne = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dargControl = new BookShopManagementSystem.CostumControl.DargControl();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelOne)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelForgotPass
            // 
            this.labelForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForgotPass.AutoSize = true;
            this.labelForgotPass.BackColor = System.Drawing.Color.White;
            this.labelForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelForgotPass.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelForgotPass.Location = new System.Drawing.Point(353, 321);
            this.labelForgotPass.Name = "labelForgotPass";
            this.labelForgotPass.Size = new System.Drawing.Size(136, 22);
            this.labelForgotPass.TabIndex = 4;
            this.labelForgotPass.Text = "Forgot Password?";
            this.labelForgotPass.Click += new System.EventHandler(this.labelForgotPass_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(217, 384);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(186, 41);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelUser.Location = new System.Drawing.Point(132, 162);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(118, 32);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.White;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelPass.Location = new System.Drawing.Point(132, 248);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(112, 32);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPass.Location = new System.Drawing.Point(138, 282);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(351, 37);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtUser.Location = new System.Drawing.Point(138, 198);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(351, 37);
            this.txtUser.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.White;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelLogin.Location = new System.Drawing.Point(239, 63);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(143, 68);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Login";
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUp.Controls.Add(this.btnCloseOne);
            this.panelUp.Controls.Add(this.picturePanelOne);
            this.panelUp.Controls.Add(this.labelShopOne);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.ForeColor = System.Drawing.Color.Aqua;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(621, 73);
            this.panelUp.TabIndex = 23;
            // 
            // btnCloseOne
            // 
            this.btnCloseOne.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCloseOne.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseOne.FlatAppearance.BorderSize = 0;
            this.btnCloseOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOne.Image = global::BookShopManagementSystem.Properties.Resources.icons8_double_left_32px;
            this.btnCloseOne.Location = new System.Drawing.Point(578, 0);
            this.btnCloseOne.Name = "btnCloseOne";
            this.btnCloseOne.Size = new System.Drawing.Size(43, 73);
            this.btnCloseOne.TabIndex = 4;
            this.btnCloseOne.UseVisualStyleBackColor = false;
            this.btnCloseOne.Click += new System.EventHandler(this.btnCloseOne_Click);
            // 
            // picturePanelOne
            // 
            this.picturePanelOne.BackColor = System.Drawing.Color.CadetBlue;
            this.picturePanelOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.picturePanelOne.Image = global::BookShopManagementSystem.Properties.Resources.icons8_books_32px;
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
            this.labelShopOne.Location = new System.Drawing.Point(204, 9);
            this.labelShopOne.Name = "labelShopOne";
            this.labelShopOne.Size = new System.Drawing.Size(212, 50);
            this.labelShopOne.TabIndex = 2;
            this.labelShopOne.Text = "Books Shop";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 27);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Copyrights © 2020.All rights reserved by BlueButterfliesDev";
            // 
            // dargControl
            // 
            this.dargControl.SelectControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.labelForgotPass);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelOne)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelForgotPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnCloseOne;
        private System.Windows.Forms.PictureBox picturePanelOne;
        private System.Windows.Forms.Label labelShopOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CostumControl.DargControl dargControl;
    }
}