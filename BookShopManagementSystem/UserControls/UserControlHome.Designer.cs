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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelSold = new System.Windows.Forms.Label();
            this.labelSoldBooks = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSalesAndPurchase = new System.Windows.Forms.Label();
            this.labelPurchaseBooks = new System.Windows.Forms.Label();
            this.labelCountPurchase = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelReport = new System.Windows.Forms.Label();
            this.spinerRecivedBook = new MetroFramework.Controls.MetroProgressSpinner();
            this.spinerSoldBook = new MetroFramework.Controls.MetroProgressSpinner();
            this.labelsoldBook = new System.Windows.Forms.Label();
            this.labelRecivedBook = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSold
            // 
            this.labelSold.AutoSize = true;
            this.labelSold.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSold.ForeColor = System.Drawing.Color.White;
            this.labelSold.Location = new System.Drawing.Point(23, 14);
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
            this.labelSoldBooks.Location = new System.Drawing.Point(51, 41);
            this.labelSoldBooks.Name = "labelSoldBooks";
            this.labelSoldBooks.Size = new System.Drawing.Size(60, 27);
            this.labelSoldBooks.TabIndex = 1;
            this.labelSoldBooks.Text = "1000";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelSoldBooks);
            this.panel1.Controls.Add(this.labelSold);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(34, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 80);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(150, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelSalesAndPurchase
            // 
            this.labelSalesAndPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSalesAndPurchase.AutoSize = true;
            this.labelSalesAndPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSalesAndPurchase.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesAndPurchase.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelSalesAndPurchase.Location = new System.Drawing.Point(200, 2);
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
            this.labelCountPurchase.Location = new System.Drawing.Point(51, 37);
            this.labelCountPurchase.Name = "labelCountPurchase";
            this.labelCountPurchase.Size = new System.Drawing.Size(60, 27);
            this.labelCountPurchase.TabIndex = 0;
            this.labelCountPurchase.Text = "1245";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelCountPurchase);
            this.panel2.Controls.Add(this.labelPurchaseBooks);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(34, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 80);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(161, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelReport
            // 
            this.labelReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReport.AutoSize = true;
            this.labelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReport.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelReport.Location = new System.Drawing.Point(568, 66);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(154, 27);
            this.labelReport.TabIndex = 5;
            this.labelReport.Text = "Monthly Report";
            // 
            // spinerRecivedBook
            // 
            this.spinerRecivedBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spinerRecivedBook.BackColor = System.Drawing.Color.White;
            this.spinerRecivedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinerRecivedBook.Location = new System.Drawing.Point(345, 79);
            this.spinerRecivedBook.Maximum = 100;
            this.spinerRecivedBook.Name = "spinerRecivedBook";
            this.spinerRecivedBook.Size = new System.Drawing.Size(95, 97);
            this.spinerRecivedBook.Style = MetroFramework.MetroColorStyle.Lime;
            this.spinerRecivedBook.TabIndex = 8;
            this.spinerRecivedBook.Tag = "Sold Book %";
            this.spinerRecivedBook.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spinerRecivedBook.UseSelectable = true;
            this.spinerRecivedBook.Value = 85;
            // 
            // spinerSoldBook
            // 
            this.spinerSoldBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spinerSoldBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinerSoldBook.Location = new System.Drawing.Point(345, 230);
            this.spinerSoldBook.Maximum = 100;
            this.spinerSoldBook.Name = "spinerSoldBook";
            this.spinerSoldBook.Size = new System.Drawing.Size(95, 97);
            this.spinerSoldBook.Style = MetroFramework.MetroColorStyle.Teal;
            this.spinerSoldBook.TabIndex = 9;
            this.spinerSoldBook.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spinerSoldBook.UseSelectable = true;
            this.spinerSoldBook.Value = 85;
            // 
            // labelsoldBook
            // 
            this.labelsoldBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsoldBook.AutoSize = true;
            this.labelsoldBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelsoldBook.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsoldBook.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelsoldBook.Location = new System.Drawing.Point(331, 189);
            this.labelsoldBook.Name = "labelsoldBook";
            this.labelsoldBook.Size = new System.Drawing.Size(125, 27);
            this.labelsoldBook.TabIndex = 11;
            this.labelsoldBook.Text = "Sold Book %";
            // 
            // labelRecivedBook
            // 
            this.labelRecivedBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecivedBook.AutoSize = true;
            this.labelRecivedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRecivedBook.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecivedBook.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelRecivedBook.Location = new System.Drawing.Point(310, 341);
            this.labelRecivedBook.Name = "labelRecivedBook";
            this.labelRecivedBook.Size = new System.Drawing.Size(155, 27);
            this.labelRecivedBook.TabIndex = 10;
            this.labelRecivedBook.Text = "Recived Book %";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::BookShopManagementSystem.Properties.Resources.icons8_refresh_32px_1;
            this.btnRefresh.Location = new System.Drawing.Point(758, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(53, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chartReport
            // 
            this.chartReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(508, 110);
            this.chartReport.Name = "chartReport";
            this.chartReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.ZigZag;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.CornflowerBlue;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Report";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ShadowColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 4;
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(300, 270);
            this.chartReport.TabIndex = 12;
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.labelRecivedBook);
            this.Controls.Add(this.labelsoldBook);
            this.Controls.Add(this.spinerSoldBook);
            this.Controls.Add(this.spinerRecivedBook);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelSalesAndPurchase);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(811, 383);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private MetroFramework.Controls.MetroProgressSpinner spinerRecivedBook;
        private MetroFramework.Controls.MetroProgressSpinner spinerSoldBook;
        private System.Windows.Forms.Label labelsoldBook;
        private System.Windows.Forms.Label labelRecivedBook;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
    }
}
