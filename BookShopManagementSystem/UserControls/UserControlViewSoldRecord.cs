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
    public partial class UserControlViewSoldRecord : UserControl
    {
        //Connect with database
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");
        private double totalPrice;

        public UserControlViewSoldRecord()
        {
            InitializeComponent();

            ChargeDataGrid();

            GetInfoFromTableSold();
        }

        #region Charge data table whit data from database
        private void ChargeDataGrid()
        {
            SqlCommand sqlCommand = new SqlCommand(@"SELECT [NetAmount],[NetDiscount],[TotalAmount],[Date] FROM [dbo].[Sold] WHERE [UserId] = @UserId");

            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlCommand.Connection = sqlConnect;

            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);

            dataGridSold.DataSource = dataTable;
        }
        #endregion

        #region Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChargeDataGrid();
        }
        #endregion

        #region Get Info From Database - Table Sold
        private void GetInfoFromTableSold()
        {
            SqlCommand sqlCommand = new SqlCommand(@"SELECT [TotalAmount] FROM [dbo].[Sold] WHERE [UserId] = @UserId", sqlConnect);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlConnect.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                totalPrice += double.Parse(dataReader["TotalAmount"].ToString());
            }

            sqlConnect.Close();

            labelTotal.Text = string.Format($"Recieved:  {totalPrice:F2}");
        }
        #endregion
    }
}
