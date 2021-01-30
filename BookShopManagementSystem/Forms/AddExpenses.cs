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
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand
                (@"INSERT INTO[dbo].[Expense]
            ([Title],[Amount],[Description], [UserId])
            VALUES('" + txtExpenseTitle.Text + "', '" +txtAmount.Text + "', '" + txtDescriptionExpense.Text + "', '"+LoginForm.userId+"')", sqlConnection);


            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Add expense successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpenseTitle.Text = "";
            txtAmount.Text = "";
            txtDescriptionExpense.Text = "";
        }

        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
