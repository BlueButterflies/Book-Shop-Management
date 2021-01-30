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
        public UserControlPurchaseDetails()
        {
            InitializeComponent();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();

            addNewBook.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection sql_connect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");
            SqlCommand sql_command = new SqlCommand(@"SELECT [TrackingId],[Title],[Author],[Quantity],[CostPrice],[SellingPrice],[Categories],[BarCode],[Publisher] FROM [dbo].[Books] WHERE [UserId] = '"+LoginForm.userId+"'");
           

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_command.Connection = sql_connect;

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridPurchase.DataSource = dt;
        }
    }
}
