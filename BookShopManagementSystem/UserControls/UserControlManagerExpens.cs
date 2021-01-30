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

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlManagerExpens : UserControl
    {
        public UserControlManagerExpens()
        {
            InitializeComponent();
        }

        private void btnAddNewExtens_Click(object sender, EventArgs e)
        {
            AddExpenses addExtenses = new AddExpenses();

            addExtenses.ShowDialog();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection sql_connect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");
            SqlCommand sql_command = new SqlCommand(@"SELECT [Title],[Amount],[Description] FROM [dbo].[Expense] WHERE [UserId] = '" + LoginForm.userId + "'");

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_command.Connection = sql_connect;

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridPurchase.DataSource = dt;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
