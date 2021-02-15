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
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlViewSoldRecord()
        {
            InitializeComponent();
            ChargeDataGrid();
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
    }
}
