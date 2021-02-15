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
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlPurchaseDetails()
        {
            InitializeComponent();
            ChargeDataGrid();
        }

        #region Charge data table whit data from database
        private void ChargeDataGrid()
        {
            SqlCommand sqlCommand = new SqlCommand(@"SELECT [Tracking],[Title],[Author],[Quantity],[CostPrice],[SellingPrice],[Categories],[BarCode],[Publisher] FROM [dbo].[Books] WHERE [UserId] = @UserId");
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlCommand.Connection = sqlConnect;

            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);

            dataGridPurchase.DataSource = dataTable;
        }
        #endregion

        #region Add new book
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();

            addNewBook.ShowDialog();

            ChargeDataGrid();
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
            sqlConnect.Open();
            SqlDataAdapter adapt = new SqlDataAdapter();

            if (comboBoxSearchBy.Text == "Author")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Author] LIKE '" + txtSearch.Text + "'", sqlConnect);
            }
            else if (comboBoxSearchBy.Text == "Title")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Title] LIKE '" + txtSearch.Text + "'", sqlConnect);
            }
            else if (comboBoxSearchBy.Text == "Publisher")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [Publisher] LIKE '" + txtSearch.Text + "'", sqlConnect);
            }
            else if (comboBoxSearchBy.Text == "Barcode")
            {
                adapt = new SqlDataAdapter("SELECT * FROM [dbo].[Books] WHERE [BarCode] LIKE '" + txtSearch.Text + "'", sqlConnect);
            }

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridPurchase.DataSource = dt;

            sqlConnect.Close();
            txtSearch.Text = "";
            comboBoxSearchBy.Text = "Select";
        }
        #endregion

        #region Button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.ShowDialog();
        }
        #endregion
    }
}
