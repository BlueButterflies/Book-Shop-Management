using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Forms;
using System.Data.SqlClient;
using System.Runtime;
using System.Diagnostics;

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlersSell : UserControl
    {
        #region Variables
        public static double totalPrice;
        public static double discountPrecent;
        public static double priceBookBeforeDiscount;

        public static int id;
        public static int quantityDatabase;
        public static int quantitySell;

        //Connect with database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");
        #endregion

        public UserControlersSell()
        {
            InitializeComponent();
            ChargeComboBox();
        }

        #region Button Finish Order
        private void btnFinish_Click(object sender, EventArgs e)
        {
            FinishOrder finishOrder = new FinishOrder();

            finishOrder.ShowDialog();
        }
        #endregion

        #region Button Add to cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (quantityDatabase < int.Parse(txtQuantity.Text))
            {
                MessageBox.Show($"The books available are {quantityDatabase}");
            }

            totalPrice = Double.Parse(txtPrice.Text);
            totalPrice -= ((Double.Parse(txtPrice.Text) * Double.Parse(txtDiscount.Text)) / 100);
            totalPrice *= Double.Parse(txtQuantity.Text);

            //Give prices for insert in database 
            priceBookBeforeDiscount = double.Parse(txtPrice.Text) * Double.Parse(txtQuantity.Text);
            discountPrecent = ((Double.Parse(txtPrice.Text) * Double.Parse(txtDiscount.Text)) / 100) * Double.Parse(txtQuantity.Text);

            ListViewItem list = new ListViewItem();
            list.Text = ComboTitle.Text;
            list.SubItems.Add(txtQuantity.Text);
            list.SubItems.Add(totalPrice.ToString());

            listView.Items.Add(list);

            if (listView.Items.Count > 1)
            {
                totalPrice += totalPrice;
            }

            labelSumOfAmount.Text = $"{totalPrice:F2}"; 

            quantitySell = int.Parse(txtQuantity.Text);

            CleareTextboxes();
        }
        #endregion

        #region Button Delete ListView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            labelSumOfAmount.Text = "00";
        }
        #endregion

        #region Button Clear 
        private void btnClear_Click(object sender, EventArgs e)
        {
            CleareTextboxes();
        }

        private void CleareTextboxes()
        {
            ComboTitle.Text = "Select";
            txtAuthor.Text = "";
            txtBarCode.Text = "";
            txtTracking.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            txtQuantity.Text = "";
        }
        #endregion

        #region Charge Combo Box
        private void ChargeComboBox()
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT [Title] FROM [dbo].[Books] WHERE [UserId] = @UserId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);
            sqlCommand.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                ComboTitle.Items.Add(item["Title"].ToString());
            }
            sqlConnection.Close();
        }
        #endregion

        #region Button  🗸 
        private void btnChargeOtherInfo_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT [id],[Tracking], [Title], [Author], [Quantity],[SellingPrice],[Barcode] FROM [dbo].[Books] WHERE [Title] = @ComboTitle AND [UserId] = @Userid", sqlConnection);
            
            sqlCommand.Parameters.AddWithValue("@ComboTitle", ComboTitle.Text);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (ComboTitle.Items != null)
            {
                if (reader.Read())
                {
                    id = (int)reader["id"];
                    quantityDatabase = int.Parse(reader["Quantity"].ToString());
                    txtAuthor.Text = reader["Author"].ToString();
                    txtBarCode.Text = reader["Barcode"].ToString();
                    txtTracking.Text = reader["Tracking"].ToString();
                    txtPrice.Text = reader["SellingPrice"].ToString();
                }

            }
            sqlCommand.Parameters.Clear();
            sqlConnection.Close();
        }
        #endregion

        #region Update and Delete from Books table- database
        public void UpdateAndDeleteFromDatabase()
        {
            sqlConnection.Open();
            int totalQuantity = UserControlersSell.quantityDatabase;
            SqlCommand sqlCommand = new SqlCommand();

            if (UserControlersSell.quantityDatabase > UserControlersSell.quantitySell)
            {
                totalQuantity -= UserControlersSell.quantitySell;

                sqlCommand = new SqlCommand(@"UPDATE [dbo].[Books] SET [Quantity] = @Quantity WHERE [id] = @ID AND [UserId] = @UserId", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Quantity", totalQuantity);
                sqlCommand.Parameters.AddWithValue("@ID", UserControlersSell.id);
                sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);
            }

            if (UserControlersSell.quantityDatabase == 1 || UserControlersSell.quantityDatabase == UserControlersSell.quantitySell)
            {
                sqlCommand = new SqlCommand(@"DELETE FROM [dbo].[Books] WHERE [id] = @Id AND [UserId] = @UserId", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", UserControlersSell.id);
                sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);
            }

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
    }
}

