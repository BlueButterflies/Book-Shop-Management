using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookShopManagementSystem.Forms
{
    public partial class AddNewBook : Form
    {
        //Connect with database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public AddNewBook()
        {
            InitializeComponent();
        }

        #region Button X
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtTracking.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtBarCode.Text = "";
            txtAuthor.Text = "";
            comboBoxCategory.Text = "";
            txtPublish.Text = "";
            imageBarcode.Image = null;
        }
        #endregion

        #region Button Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnCloseWin_Click(sender, e);
        }
        #endregion

        #region Button Add new book
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                           (@"INSERT INTO[dbo].[Books]
            ([Tracking],[Title],[Author],[Quantity],[CostPrice],[SellingPrice],[Categories],[Barcode],[Publisher],[UserId])
            VALUES(@Tracking, @Title, @Author, @Quantity, @CostPrice, @SellingPrice, @Categories, @Barcode, @Publisher, @UserId)", sqlConnection);
          
            sqlCommand.Parameters.AddWithValue("@Tracking", txtTracking.Text);
            sqlCommand.Parameters.AddWithValue("@Title", txtTitle.Text);
            sqlCommand.Parameters.AddWithValue("@Author", txtAuthor.Text);
            sqlCommand.Parameters.AddWithValue("@Quatity", txtQuantity.Text);
            sqlCommand.Parameters.AddWithValue("@CostPrice", txtSellingPrice.Text);
            sqlCommand.Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text);
            sqlCommand.Parameters.AddWithValue("@Categories", comboBoxCategory.Text);
            sqlCommand.Parameters.AddWithValue("@Barcode", txtBarCode.Text);
            sqlCommand.Parameters.AddWithValue("@Publisher", txtPublish.Text);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Add book successfully");

            btnClear_Click(sender, e);
        }
        #endregion

        #region View barcode image
        private void checkBoxBarCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBarCode.Checked == true)
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

                var barcodeImage = barcode.Draw(txtBarCode.Text, 50);

                Bitmap resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

                using (var graphics = Graphics.FromImage(resultImage))
                using (var font = new Font("Consolas", 12))
                using (var brush = new SolidBrush(Color.Black))
                using (var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                    LineAlignment = StringAlignment.Far
                })
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(barcodeImage, 0, 0);
                    graphics.DrawString(txtBarCode.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
                }

                imageBarcode.Image = resultImage;
            }
        }
        #endregion
    }
}
