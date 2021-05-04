using BookShopManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.Forms
{
    public partial class FinishOrder : Form
    {
        //Connect with database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public FinishOrder()
        {
            InitializeComponent();
        }

        #region Load Finish Order 
        private void FinishOrder_Load(object sender, EventArgs e)
        {
            txtTotal.Text = UserControlersSell.totalPrice.ToString();
        }
        #endregion

        #region Button Done
        private void btnDone_Click(object sender, EventArgs e)
        {
            InsertInDatabase();
            //UpdateAndDeleteFromDatabase();
            MessageBox.Show("Sold it!");
            this.Close();
        }
        #endregion

        #region Inser Sold books in database
        private void InsertInDatabase()
        {
            DateTime time = DateTime.Now;

            SqlCommand sqlCommand = new SqlCommand
                ("INSERT INTO[dbo].[Sold] ([NetAmount], [NetDiscount], [TotalAmount], [Date], [UserId]) VALUES (@PriceBookAfterDiscount, @DiscountPrecent, @TotalPrice, @Time, @UserId) ", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PriceBookAfterDiscount", UserControlersSell.priceBookBeforeDiscount.ToString());
            sqlCommand.Parameters.AddWithValue("@DiscountPrecent", UserControlersSell.discountPrecent.ToString());
            sqlCommand.Parameters.AddWithValue("@TotalPrice", UserControlersSell.totalPrice.ToString());
            sqlCommand.Parameters.AddWithValue("@Time", time);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion

        #region Button Close
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Change Money
        private void btnChangeMoney_Click(object sender, EventArgs e)
        {
            var changeMoney = Double.Parse(txtPaid.Text) - Double.Parse(txtTotal.Text);
            labelZero.Text = string.Format($"{changeMoney:F2}");
        }
        #endregion

       /* #region Update and Delete from Books table- database
        private void UpdateAndDeleteFromDatabase()
        {
            sqlConnection.Open();
            int totalQuantity = UserControlersSell.quantityDatabase;
            SqlCommand sqlCommand = new SqlCommand();

            if(UserControlersSell.quantityDatabase > UserControlersSell.quantitySell)
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
       */
    }
}
