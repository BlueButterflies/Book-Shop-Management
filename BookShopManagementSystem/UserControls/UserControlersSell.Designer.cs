namespace BookShopManagementSystem.UserControls
{
    partial class UserControlersSell
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSumOfAmount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.labelTracking = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.ComboTitle = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookshopDataSet2 = new BookShopManagementSystem.bookshopDataSet2();
            this.booksTableAdapter = new BookShopManagementSystem.bookshopDataSet2TableAdapters.BooksTableAdapter();
            this.btnChargeOtherInfo = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft.ForeColor = System.Drawing.Color.CadetBlue;
            this.panelLeft.Location = new System.Drawing.Point(544, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(267, 383);
            this.panelLeft.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listView);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 383);
            this.panel2.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnQuantity,
            this.columnAmount});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.ForeColor = System.Drawing.Color.CadetBlue;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(245, 152);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Book Title";
            this.columnTitle.Width = 100;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Qty";
            this.columnQuantity.Width = 50;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 90;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelSumOfAmount);
            this.panel5.Controls.Add(this.labelAmount);
            this.panel5.Controls.Add(this.btnFinish);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 231);
            this.panel5.TabIndex = 5;
            // 
            // labelSumOfAmount
            // 
            this.labelSumOfAmount.AutoSize = true;
            this.labelSumOfAmount.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumOfAmount.Location = new System.Drawing.Point(153, 107);
            this.labelSumOfAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumOfAmount.Name = "labelSumOfAmount";
            this.labelSumOfAmount.Size = new System.Drawing.Size(36, 27);
            this.labelSumOfAmount.TabIndex = 4;
            this.labelSumOfAmount.Text = "00";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(12, 107);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(144, 27);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Total Amount:";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Teal;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(17, 176);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(210, 42);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Firebrick;
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 56);
            this.panel8.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CadetBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 10);
            this.panel7.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(273, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 10);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(245, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 383);
            this.panel4.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(408, 328);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(129, 42);
            this.btnAddToCart.TabIndex = 15;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtPrice.Location = new System.Drawing.Point(304, 208);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarCode.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtBarCode.Location = new System.Drawing.Point(64, 211);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(175, 26);
            this.txtBarCode.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(300, 185);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 19);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            // 
            // labelBarCode
            // 
            this.labelBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Location = new System.Drawing.Point(60, 188);
            this.labelBarCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(66, 19);
            this.labelBarCode.TabIndex = 5;
            this.labelBarCode.Text = "Bar Code";
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(61, 254);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(79, 19);
            this.labelDiscount.TabIndex = 11;
            this.labelDiscount.Text = "Discount %";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtDiscount.Location = new System.Drawing.Point(64, 276);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(175, 26);
            this.txtDiscount.TabIndex = 12;
            // 
            // labelTracking
            // 
            this.labelTracking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTracking.AutoSize = true;
            this.labelTracking.Location = new System.Drawing.Point(300, 124);
            this.labelTracking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTracking.Name = "labelTracking";
            this.labelTracking.Size = new System.Drawing.Size(69, 19);
            this.labelTracking.TabIndex = 7;
            this.labelTracking.Text = "Tracking ";
            // 
            // txtTracking
            // 
            this.txtTracking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTracking.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtTracking.Location = new System.Drawing.Point(305, 150);
            this.txtTracking.Margin = new System.Windows.Forms.Padding(4);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(175, 26);
            this.txtTracking.TabIndex = 8;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(60, 124);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(53, 19);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtAuthor.Location = new System.Drawing.Point(64, 147);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(175, 26);
            this.txtAuthor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sell Books";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtQuantity.Location = new System.Drawing.Point(304, 276);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(175, 26);
            this.txtQuantity.TabIndex = 17;
            // 
            // ComboTitle
            // 
            this.ComboTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboTitle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksBindingSource, "Title", true));
            this.ComboTitle.ForeColor = System.Drawing.Color.CadetBlue;
            this.ComboTitle.FormattingEnabled = true;
            this.ComboTitle.Location = new System.Drawing.Point(65, 79);
            this.ComboTitle.Name = "ComboTitle";
            this.ComboTitle.Size = new System.Drawing.Size(337, 27);
            this.ComboTitle.TabIndex = 18;
            this.ComboTitle.Text = "Select Book";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookshopDataSet2;
            // 
            // bookshopDataSet2
            // 
            this.bookshopDataSet2.DataSetName = "bookshopDataSet2";
            this.bookshopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // btnChargeOtherInfo
            // 
            this.btnChargeOtherInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChargeOtherInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargeOtherInfo.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargeOtherInfo.Location = new System.Drawing.Point(442, 79);
            this.btnChargeOtherInfo.Name = "btnChargeOtherInfo";
            this.btnChargeOtherInfo.Size = new System.Drawing.Size(37, 27);
            this.btnChargeOtherInfo.TabIndex = 19;
            this.btnChargeOtherInfo.Text = "✔";
            this.btnChargeOtherInfo.UseVisualStyleBackColor = true;
            this.btnChargeOtherInfo.Click += new System.EventHandler(this.btnChargeOtherInfo_Click);
            // 
            // UserControlersSell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChargeOtherInfo);
            this.Controls.Add(this.ComboTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.labelTracking);
            this.Controls.Add(this.txtTracking);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.labelBarCode);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlersSell";
            this.Size = new System.Drawing.Size(811, 383);
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshopDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelSumOfAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labelTracking;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox ComboTitle;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bookshopDataSet2 bookshopDataSet2;
        private bookshopDataSet2TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Button btnChargeOtherInfo;
    }
}
