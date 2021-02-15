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

        #region Load Finish Orede form
        private void FinishOrder_Load(object sender, EventArgs e)
        {
            txtTotal.Text = UserControlersSell.totalPrice.ToString();
        }
        #endregion

        #region Button Done
        private void btnDone_Click(object sender, EventArgs e)
        {
            InsertInDatabase();
            this.Close();
        }
        #endregion

        #region Inser Sold books in database
        private void InsertInDatabase()
        {
            DateTime time = DateTime.Now;

            SqlCommand sqlCommand = new SqlCommand
                ("INSERT INTO[dbo].[Sold] ([NetAmount], [NetDiscount], [TotalAmount], [Date], [BookId], [UserId]) VALUES (@PriceBookAfterDiscount, @DiscountPrecent, @TotalPrice, @Time, @SellId, @UserId) ", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PriceBookAfterDiscount", UserControlersSell.priceBookAfterDiscount.ToString());
            sqlCommand.Parameters.AddWithValue("@DiscountPrecent", UserControlersSell.discountPrecent.ToString());
            sqlCommand.Parameters.AddWithValue("@TotalPrice", UserControlersSell.totalPrice.ToString()); 
            sqlCommand.Parameters.AddWithValue("@Time", time);
            sqlCommand.Parameters.AddWithValue("@SellId", UserControlersSell.id);
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
            var changeMoney = Math.Round(Double.Parse(txtPaid.Text) - Double.Parse(txtTotal.Text));
            labelZero.Text = changeMoney.ToString();
        }
        #endregion
    }
}
