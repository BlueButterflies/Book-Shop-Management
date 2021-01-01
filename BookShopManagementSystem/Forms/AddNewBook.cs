using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookShopManagementSystem.Forms
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtTracking.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtBarCode.Text = "";
            txtAuthor.Text = "";
            comboBoxCategory.Text = "";
            txtPublish.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnCloseWin_Click(sender, e);
        }

        private void checkBoxBarCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBarCode.Checked)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");



            SqlCommand sqlCommand = new SqlCommand
                (@"INSERT INTO[dbo].[books]
            ([TrackingId],[Title],[Author],[Quantity],[CostPrice],[SellingPrice],[Categories],[BarCode],[Publisher])
            VALUES('" + txtTracking.Text + "', '" + txtTitle.Text + "', '" + txtAuthor.Text + "', '" + txtQuantity.Text + "', '" + txtCostPrice + "', '" + txtSellingPrice + "', '" + comboBoxCategory.Items + "', '" + txtBarCode + "', '" + txtPublish.Text + "')", sqlConnection);
          
            
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Add book Successfully");

        }
    }
}
