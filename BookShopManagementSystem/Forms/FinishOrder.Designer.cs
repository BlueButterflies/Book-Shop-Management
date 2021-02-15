namespace BookShopManagementSystem.Forms
{
    partial class FinishOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFinilizate = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelZero = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCloseWin = new System.Windows.Forms.Button();
            this.picShoopTree = new System.Windows.Forms.PictureBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.btnChangeMoney = new System.Windows.Forms.Button();
            this.dargControl = new BookShopManagementSystem.CostumControl.DargControl();
            ((System.ComponentModel.ISupportInitialize)(this.picShoopTree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 446);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 456);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(548, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 466);
            this.panel4.TabIndex = 1;
            // 
            // labelFinilizate
            // 
            this.labelFinilizate.AutoSize = true;
            this.labelFinilizate.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinilizate.Location = new System.Drawing.Point(157, 149);
            this.labelFinilizate.Name = "labelFinilizate";
            this.labelFinilizate.Size = new System.Drawing.Size(245, 34);
            this.labelFinilizate.TabIndex = 0;
            this.labelFinilizate.Text = "Finalize Your Order";
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtTotal.Location = new System.Drawing.Point(233, 242);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(239, 28);
            this.txtTotal.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(87, 242);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(108, 22);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Amount";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(52, 405);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(143, 27);
            this.labelChange.TabIndex = 9;
            this.labelChange.Text = "Change Amout";
            // 
            // labelZero
            // 
            this.labelZero.AutoSize = true;
            this.labelZero.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZero.Location = new System.Drawing.Point(201, 405);
            this.labelZero.Name = "labelZero";
            this.labelZero.Size = new System.Drawing.Size(36, 27);
            this.labelZero.TabIndex = 10;
            this.labelZero.Text = "00";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(421, 397);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(91, 35);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCloseWin
            // 
            this.btnCloseWin.BackColor = System.Drawing.Color.White;
            this.btnCloseWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWin.FlatAppearance.BorderSize = 0;
            this.btnCloseWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWin.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWin.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnCloseWin.Location = new System.Drawing.Point(515, 10);
            this.btnCloseWin.Name = "btnCloseWin";
            this.btnCloseWin.Size = new System.Drawing.Size(33, 31);
            this.btnCloseWin.TabIndex = 12;
            this.btnCloseWin.Text = "X";
            this.btnCloseWin.UseVisualStyleBackColor = false;
            this.btnCloseWin.Click += new System.EventHandler(this.btnCloseWin_Click);
            // 
            // picShoopTree
            // 
            this.picShoopTree.Image = global::BookShopManagementSystem.Properties.Resources.icons8_books_32px_1;
            this.picShoopTree.Location = new System.Drawing.Point(167, 12);
            this.picShoopTree.Name = "picShoopTree";
            this.picShoopTree.Size = new System.Drawing.Size(225, 134);
            this.picShoopTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoopTree.TabIndex = 3;
            this.picShoopTree.TabStop = false;
            // 
            // txtPaid
            // 
            this.txtPaid.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPaid.Location = new System.Drawing.Point(233, 303);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(182, 28);
            this.txtPaid.TabIndex = 8;
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(87, 303);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(100, 22);
            this.labelPaid.TabIndex = 7;
            this.labelPaid.Text = "Paid Amount";
            // 
            // btnChangeMoney
            // 
            this.btnChangeMoney.BackColor = System.Drawing.Color.CadetBlue;
            this.btnChangeMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMoney.FlatAppearance.BorderSize = 0;
            this.btnChangeMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMoney.ForeColor = System.Drawing.Color.White;
            this.btnChangeMoney.Location = new System.Drawing.Point(421, 303);
            this.btnChangeMoney.Name = "btnChangeMoney";
            this.btnChangeMoney.Size = new System.Drawing.Size(51, 28);
            this.btnChangeMoney.TabIndex = 13;
            this.btnChangeMoney.Text = "✔";
            this.btnChangeMoney.UseVisualStyleBackColor = false;
            this.btnChangeMoney.Click += new System.EventHandler(this.btnChangeMoney_Click);
            // 
            // dargControl
            // 
            this.dargControl.SelectControl = this;
            // 
            // FinishOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 466);
            this.Controls.Add(this.btnChangeMoney);
            this.Controls.Add(this.btnCloseWin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.labelZero);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.picShoopTree);
            this.Controls.Add(this.labelFinilizate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FinishOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinishOrder";
            this.Load += new System.EventHandler(this.FinishOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShoopTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelFinilizate;
        private System.Windows.Forms.PictureBox picShoopTree;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelZero;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCloseWin;
        private CostumControl.DargControl dargControl;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Button btnChangeMoney;
    }
}