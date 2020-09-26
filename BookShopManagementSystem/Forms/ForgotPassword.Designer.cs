namespace BookShopManagementSystem.Forms
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnBackCome = new System.Windows.Forms.Button();
            this.picturePanelOne = new System.Windows.Forms.PictureBox();
            this.labelForgotPass = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dargControl = new BookShopManagementSystem.CostumControl.DargControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanelOne)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.CadetBlue;
            this.panelUp.Controls.Add(this.btnBackCome);
            this.panelUp.Controls.Add(this.picturePanelOne);
            this.panelUp.Controls.Add(this.labelForgotPass);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.ForeColor = System.Drawing.Color.Aqua;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(697, 73);
            this.panelUp.TabIndex = 1;
            // 
            // btnBackCome
            // 
            this.btnBackCome.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBackCome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBackCome.FlatAppearance.BorderSize = 0;
            this.btnBackCome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBackCome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCome.Image = ((System.Drawing.Image)(resources.GetObject("btnBackCome.Image")));
            this.btnBackCome.Location = new System.Drawing.Point(654, 0);
            this.btnBackCome.Name = "btnBackCome";
            this.btnBackCome.Size = new System.Drawing.Size(43, 73);
            this.btnBackCome.TabIndex = 4;
            this.btnBackCome.UseVisualStyleBackColor = false;
            this.btnBackCome.Click += new System.EventHandler(this.btnBackCome_Click);
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
            // labelForgotPass
            // 
            this.labelForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForgotPass.AutoSize = true;
            this.labelForgotPass.BackColor = System.Drawing.Color.CadetBlue;
            this.labelForgotPass.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPass.ForeColor = System.Drawing.Color.White;
            this.labelForgotPass.Location = new System.Drawing.Point(252, 12);
            this.labelForgotPass.Name = "labelForgotPass";
            this.labelForgotPass.Size = new System.Drawing.Size(256, 38);
            this.labelForgotPass.TabIndex = 2;
            this.labelForgotPass.Text = "Forgot Password ?";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(22, 145);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(653, 23);
            this.label.TabIndex = 2;
            this.label.Text = "Please enter you email address and we will mail you a link to reset your password" +
    ".";
            // 
            // txtResetPass
            // 
            this.txtResetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResetPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtResetPass.Location = new System.Drawing.Point(26, 217);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(638, 26);
            this.txtResetPass.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(168, 315);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(380, 53);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // dargControl
            // 
            this.dargControl.SelectControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 27);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Copyrights © 2020.All rights reserved  by BlueButterflies";
            // 
            // ForgotPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResetPass);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
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
        private System.Windows.Forms.Button btnBackCome;
        private System.Windows.Forms.PictureBox picturePanelOne;
        private System.Windows.Forms.Label labelForgotPass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.Button btnReset;
        private CostumControl.DargControl dargControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}