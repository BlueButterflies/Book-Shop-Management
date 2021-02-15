using BookShopManagementSystem.UserControls;
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

        #region Add Expense
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand
                (@"INSERT INTO[dbo].[Expense]
            ([Title],[Amount],[Description], [UserId])
            VALUES(@ExpenseTitle, @Amount, @Description, @UserId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@ExpenseTitle",txtExpenseTitle.Text);
            sqlCommand.Parameters.AddWithValue("@Amount",txtAmount.Text);
            sqlCommand.Parameters.AddWithValue("@Description", txtDescriptionExpense.Text);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Add expense successfully");
            sqlConnection.Close();
        }
        #endregion

        #region Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpenseTitle.Text = "";
            txtAmount.Text = "";
            txtDescriptionExpense.Text = "";
        }
        #endregion

        #region Buttons Close
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
