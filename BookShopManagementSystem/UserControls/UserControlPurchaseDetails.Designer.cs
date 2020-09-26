namespace BookShopManagementSystem.UserControls
{
    partial class UserControlPurchaseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPurchaseDetails));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridPurchase = new System.Windows.Forms.DataGridView();
            this.ColTracking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 10);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(851, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 473);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 10);
            this.panel3.TabIndex = 5;
            // 
            // dataGridPurchase
            // 
            this.dataGridPurchase.AllowUserToAddRows = false;
            this.dataGridPurchase.AllowUserToDeleteRows = false;
            this.dataGridPurchase.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTracking,
            this.ColBookTitle,
            this.ColAuthor,
            this.ColPublisher,
            this.ColQuantity,
            this.ColCostPrice,
            this.ColSelling,
            this.ColBarcode});
            this.dataGridPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPurchase.Location = new System.Drawing.Point(10, 67);
            this.dataGridPurchase.Name = "dataGridPurchase";
            this.dataGridPurchase.ReadOnly = true;
            this.dataGridPurchase.RowHeadersVisible = false;
            this.dataGridPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPurchase.Size = new System.Drawing.Size(841, 406);
            this.dataGridPurchase.TabIndex = 2;
            // 
            // ColTracking
            // 
            this.ColTracking.HeaderText = "Tracking ID";
            this.ColTracking.Name = "ColTracking";
            this.ColTracking.ReadOnly = true;
            this.ColTracking.Width = 150;
            // 
            // ColBookTitle
            // 
            this.ColBookTitle.HeaderText = "Book Title";
            this.ColBookTitle.Name = "ColBookTitle";
            this.ColBookTitle.ReadOnly = true;
            this.ColBookTitle.Width = 200;
            // 
            // ColAuthor
            // 
            this.ColAuthor.HeaderText = "Author";
            this.ColAuthor.Name = "ColAuthor";
            this.ColAuthor.ReadOnly = true;
            this.ColAuthor.Width = 200;
            // 
            // ColPublisher
            // 
            this.ColPublisher.HeaderText = "Publisher";
            this.ColPublisher.Name = "ColPublisher";
            this.ColPublisher.ReadOnly = true;
            this.ColPublisher.Width = 200;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantity";
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.ReadOnly = true;
            // 
            // ColCostPrice
            // 
            this.ColCostPrice.HeaderText = "Cost Price";
            this.ColCostPrice.Name = "ColCostPrice";
            this.ColCostPrice.ReadOnly = true;
            // 
            // ColSelling
            // 
            this.ColSelling.HeaderText = "Selling Price";
            this.ColSelling.Name = "ColSelling";
            this.ColSelling.ReadOnly = true;
            // 
            // ColBarcode
            // 
            this.ColBarcode.HeaderText = "Barcode";
            this.ColBarcode.Name = "ColBarcode";
            this.ColBarcode.ReadOnly = true;
            this.ColBarcode.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 473);
            this.panel1.TabIndex = 3;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.Image")));
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(168, 57);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = " Add New Book";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by";
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Location = new System.Drawing.Point(698, 17);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(137, 26);
            this.txtSearchBy.TabIndex = 2;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Tracking ID",
            "Book Title",
            "Author",
            "Publisher",
            "Barcode"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(554, 17);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(138, 27);
            this.comboBoxSearchBy.TabIndex = 4;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Image")));
            this.btnAddStock.Location = new System.Drawing.Point(168, 0);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(149, 57);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "  Add Stock";
            this.btnAddStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.btnAddStock);
            this.panel5.Controls.Add(this.comboBoxSearchBy);
            this.panel5.Controls.Add(this.txtSearchBy);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAddNewBook);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(841, 57);
            this.panel5.TabIndex = 1;
            // 
            // UserControlPurchaseDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridPurchase);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "UserControlPurchaseDetails";
            this.Size = new System.Drawing.Size(861, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTracking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Panel panel5;
    }
}
