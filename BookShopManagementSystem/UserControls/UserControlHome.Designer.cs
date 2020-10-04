namespace BookShopManagementSystem.UserControls
{
    partial class UserControlHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHome));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelcountCustomers = new System.Windows.Forms.Label();
            this.labelcUSTOMERS = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelSold = new System.Windows.Forms.Label();
            this.labelSoldBooks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSalesAndPurchase = new System.Windows.Forms.Label();
            this.labelPurchaseBooks = new System.Windows.Forms.Label();
            this.labelCountPurchase = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelReport = new System.Windows.Forms.Label();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.labelcountCustomers);
            this.panel3.Controls.Add(this.labelcUSTOMERS);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(600, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 80);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(154, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelcountCustomers
            // 
            this.labelcountCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcountCustomers.AutoSize = true;
            this.labelcountCustomers.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountCustomers.ForeColor = System.Drawing.Color.White;
            this.labelcountCustomers.Location = new System.Drawing.Point(75, 37);
            this.labelcountCustomers.Name = "labelcountCustomers";
            this.labelcountCustomers.Size = new System.Drawing.Size(48, 27);
            this.labelcountCustomers.TabIndex = 1;
            this.labelcountCustomers.Text = "520";
            // 
            // labelcUSTOMERS
            // 
            this.labelcUSTOMERS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcUSTOMERS.AutoSize = true;
            this.labelcUSTOMERS.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcUSTOMERS.ForeColor = System.Drawing.Color.White;
            this.labelcUSTOMERS.Location = new System.Drawing.Point(17, 10);
            this.labelcUSTOMERS.Name = "labelcUSTOMERS";
            this.labelcUSTOMERS.Size = new System.Drawing.Size(106, 27);
            this.labelcUSTOMERS.TabIndex = 0;
            this.labelcUSTOMERS.Text = "Customers";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(774, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(53, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelSold
            // 
            this.labelSold.AutoSize = true;
            this.labelSold.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSold.ForeColor = System.Drawing.Color.White;
            this.labelSold.Location = new System.Drawing.Point(3, 10);
            this.labelSold.Name = "labelSold";
            this.labelSold.Size = new System.Drawing.Size(110, 27);
            this.labelSold.TabIndex = 0;
            this.labelSold.Text = "Sold Books";
            // 
            // labelSoldBooks
            // 
            this.labelSoldBooks.AutoSize = true;
            this.labelSoldBooks.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoldBooks.ForeColor = System.Drawing.Color.White;
            this.labelSoldBooks.Location = new System.Drawing.Point(53, 37);
            this.labelSoldBooks.Name = "labelSoldBooks";
            this.labelSoldBooks.Size = new System.Drawing.Size(60, 27);
            this.labelSoldBooks.TabIndex = 1;
            this.labelSoldBooks.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelSoldBooks);
            this.panel1.Controls.Add(this.labelSold);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(33, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 80);
            this.panel1.TabIndex = 2;
            // 
            // labelSalesAndPurchase
            // 
            this.labelSalesAndPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSalesAndPurchase.AutoSize = true;
            this.labelSalesAndPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalesAndPurchase.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesAndPurchase.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelSalesAndPurchase.Location = new System.Drawing.Point(258, 12);
            this.labelSalesAndPurchase.Name = "labelSalesAndPurchase";
            this.labelSalesAndPurchase.Size = new System.Drawing.Size(352, 34);
            this.labelSalesAndPurchase.TabIndex = 0;
            this.labelSalesAndPurchase.Text = "Sales and Purchase Overview";
            // 
            // labelPurchaseBooks
            // 
            this.labelPurchaseBooks.AutoSize = true;
            this.labelPurchaseBooks.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseBooks.ForeColor = System.Drawing.Color.White;
            this.labelPurchaseBooks.Location = new System.Drawing.Point(3, 9);
            this.labelPurchaseBooks.Name = "labelPurchaseBooks";
            this.labelPurchaseBooks.Size = new System.Drawing.Size(152, 27);
            this.labelPurchaseBooks.TabIndex = 0;
            this.labelPurchaseBooks.Text = "Purchase Books";
            // 
            // labelCountPurchase
            // 
            this.labelCountPurchase.AutoSize = true;
            this.labelCountPurchase.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountPurchase.ForeColor = System.Drawing.Color.White;
            this.labelCountPurchase.Location = new System.Drawing.Point(95, 37);
            this.labelCountPurchase.Name = "labelCountPurchase";
            this.labelCountPurchase.Size = new System.Drawing.Size(60, 27);
            this.labelCountPurchase.TabIndex = 0;
            this.labelCountPurchase.Text = "1245";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(161, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelCountPurchase);
            this.panel2.Controls.Add(this.labelPurchaseBooks);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(321, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 80);
            this.panel2.TabIndex = 3;
            // 
            // labelReport
            // 
            this.labelReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReport.AutoSize = true;
            this.labelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReport.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelReport.Location = new System.Drawing.Point(36, 187);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(140, 27);
            this.labelReport.TabIndex = 5;
            this.labelReport.Text = "Yearly Report";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinner1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(469, 249);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(141, 135);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroProgressSpinner1.TabIndex = 8;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 60;
            // 
            // chartReport
            // 
            this.chartReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "Report";
            this.chartReport.ChartAreas.Add(chartArea2);
            this.chartReport.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Name = "Legend1";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(33, 226);
            this.chartReport.Name = "chartReport";
            this.chartReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            this.chartReport.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "Report";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.CadetBlue;
            series2.Legend = "Legend1";
            series2.Name = "Report";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ShadowColor = System.Drawing.Color.White;
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(391, 230);
            this.chartReport.TabIndex = 7;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinner2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(690, 249);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(137, 135);
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner2.TabIndex = 9;
            this.metroProgressSpinner2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(736, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paid";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(607, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "% Amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(505, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recived";
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroProgressSpinner2);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelSalesAndPurchase);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(861, 483);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelcountCustomers;
        private System.Windows.Forms.Label labelcUSTOMERS;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelSold;
        private System.Windows.Forms.Label labelSoldBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSalesAndPurchase;
        private System.Windows.Forms.Label labelPurchaseBooks;
        private System.Windows.Forms.Label labelCountPurchase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelReport;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
