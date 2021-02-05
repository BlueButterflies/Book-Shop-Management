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
        SqlConnection sql_connect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlManagerExpens()
        {
            InitializeComponent();
            ChargeDataGrid();
        }

        #region Charge data table whit data from database
        private void ChargeDataGrid()
        {
            SqlCommand sql_command = new SqlCommand(@"SELECT [Title],[Amount],[Description] FROM [dbo].[Expense] WHERE [UserId] = '" + LoginForm.userId + "'");

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_command.Connection = sql_connect;

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridExtenses.DataSource = dt;
        }
        #endregion

        #region Add new extense
        private void btnAddNewExtens_Click(object sender, EventArgs e)
        {
            AddExpenses addExtenses = new AddExpenses();

            addExtenses.ShowDialog();

            ChargeDataGrid();
        }
        #endregion

        #region Call ChargeDataGrid Method
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChargeDataGrid();
        }
        #endregion

        #region Remove all from data table and database
        //TODO create btn for delete whit select row
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridExtenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("There are no expense present for delete.");
                return;
            }
             if (MessageBox.Show("Are you sure want delete?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                    
                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM [dbo].[Expense] WHERE [UserId] = '" + LoginForm.userId + "'", sql_connect);

                        sql_connect.Open();
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Records has been Deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    ChargeDataGrid();
                    sql_connect.Close();
                
            }
        }

        #endregion

    }
}
