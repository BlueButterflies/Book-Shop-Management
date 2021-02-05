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
using System.Data.Odbc;

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlPurchaseDetails : UserControl
    {
        SqlConnection sql_connect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlPurchaseDetails()
        {
            InitializeComponent();
            ChargeDataGrid();
        }

        #region Charge data table whit data from database
        private void ChargeDataGrid()
        {
            SqlCommand sql_command = new SqlCommand(@"SELECT [Tracking],[Title],[Author],[Quantity],[CostPrice],[SellingPrice],[Categories],[BarCode],[Publisher] FROM [dbo].[Books] WHERE [UserId] = '" + LoginForm.userId + "'");

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_command.Connection = sql_connect;

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridPurchase.DataSource = dt;
        }
        #endregion

        #region Add new book
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();

            addNewBook.ShowDialog();
        }
        #endregion

        #region Refresh table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChargeDataGrid();
        }

        #endregion

        #region Button  Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMethod();
        }
        #endregion

        #region Search from data table and database
        private void SearchMethod()
        {
            sql_connect.Open();
            SqlDataAdapter adapt = new SqlDataAdapter();
            if (comboBoxSearchBy.Text == "Author")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Author] LIKE '" + txtSearch.Text + "'", sql_connect);
            }
            else if (comboBoxSearchBy.Text == "Tracking")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Tracking] LIKE '" + txtSearch.Text + "'", sql_connect);
            }
            else if (comboBoxSearchBy.Text == "Title")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Title] LIKE '" + txtSearch.Text + "'", sql_connect);
            }
            else if (comboBoxSearchBy.Text == "Publisher")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Publisher] LIKE '" + txtSearch.Text + "'", sql_connect);
            }
            else if (comboBoxSearchBy.Text == "Barcode")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [BarCode] LIKE '" + txtSearch.Text + "'", sql_connect);
            }

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridPurchase.DataSource = dt;

            sql_connect.Close();
        }
        #endregion
    }
}
