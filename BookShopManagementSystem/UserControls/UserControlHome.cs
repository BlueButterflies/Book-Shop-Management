using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookShopManagementSystem.Forms;

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlHome : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlHome()
        {
            InitializeComponent();
            LoadChart();

            sqlConnection.Open();

            #region Get count all sold books
            SqlCommand sqlCommandSalesBook = new SqlCommand("SELECT COUNT(*) FROM[dbo].[Sold] WHERE [UserId] = @Userid", sqlConnection);
            sqlCommandSalesBook.Parameters.AddWithValue("@UserId", LoginForm.userId);

            int countSoldBook = (int)sqlCommandSalesBook.ExecuteScalar();

            labelSoldBooks.Text = countSoldBook.ToString();
            #endregion

            #region count all purchase books
            SqlCommand sqlCommandBookPurchase = new SqlCommand("SELECT COUNT(*) FROM[dbo].[Books] WHERE [UserId] = @UserId", sqlConnection);
            sqlCommandBookPurchase.Parameters.AddWithValue("@UserId", LoginForm.userId);

            int countBookPurchase = (int)sqlCommandBookPurchase.ExecuteScalar();

            labelCountPurchase.Text = countBookPurchase.ToString();

            #endregion

            sqlConnection.Close();

            //The spiners in %
            spinerRecivedBook.Value = countBookPurchase / 100;
            spinerSoldBook.Value = countSoldBook / 100;
        }

        private void LoadChart() //Create Chart for Dash Board
        {
            SqlCommand sqlCommand = new SqlCommand(@"SELECT [TotalAmount], MONTH([Date]) AS Month FROM [Sold] WHERE [UserId] =  @UserId ORDER BY [TotalAmount]", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                chartReport.Series["Report"].Points.AddXY(sqlDataReader["Month"], sqlDataReader["TotalAmount"]);
            }
            sqlConnection.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e) //Load from button Refresh
        {
            LoadChart();
        }

    }
}
