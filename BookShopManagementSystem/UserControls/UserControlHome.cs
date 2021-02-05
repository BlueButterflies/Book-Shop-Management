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

            sqlConnection.Open();

            #region Get count all sales books
            SqlCommand sqlCommandSalesBook = new SqlCommand("SELECT COUNT(*) FROM[dbo].[Expense] WHERE [UserId] = '" + LoginForm.userId + "'", sqlConnection);

            int countSalesBook = (int)sqlCommandSalesBook.ExecuteScalar();

            labelSoldBooks.Text = countSalesBook.ToString();
            #endregion

            #region count all purchase books
            SqlCommand sqlCommandBookPurchase = new SqlCommand("SELECT COUNT(*) FROM[dbo].[Books] WHERE [UserId] = '"+LoginForm.userId+"'", sqlConnection);

            int countBookPurchase = (int)sqlCommandBookPurchase.ExecuteScalar();

            labelCountPurchase.Text = countBookPurchase.ToString();

            #endregion

            sqlConnection.Close();

            //The spiners in %
            spinerRecivedBook.Value = countBookPurchase / 100;
            spinerSoldBook.Value = countSalesBook / 100;
        }

        private void LoadChart() //Create Chart for Dash Board
        {
            chartReport.Series["Report"].Points.AddXY("Jan", 500);
            chartReport.Series["Report"].Points.AddXY("Feb", 60);
            chartReport.Series["Report"].Points.AddXY("Mar", 100);
            chartReport.Series["Report"].Points.AddXY("Apr", 1000);
            chartReport.Series["Report"].Points.AddXY("May", 800);
            chartReport.Series["Report"].Points.AddXY("Jun", 500);
            chartReport.Series["Report"].Points.AddXY("Jul", 500);
            chartReport.Series["Report"].Points.AddXY("Ago", 500);
            chartReport.Series["Report"].Points.AddXY("Set", 500);
            chartReport.Series["Report"].Points.AddXY("Oct", 500);
            chartReport.Series["Report"].Points.AddXY("Nov", 500);
            chartReport.Series["Report"].Points.AddXY("Dec", 500);
        }

        private void btnRefresh_Click(object sender, EventArgs e) //Load from button Refresh
        {
            LoadChart();
        }
    }
}
