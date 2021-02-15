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
    public partial class UpdateBook : Form
    {
        //Connect with database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UpdateBook()
        {
            InitializeComponent();

            ChargeComboBox();
        }

        #region Close buttons
        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Clear 
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxses();
        }

        private void ClearTextBoxses()
        {
            ComboTitle.Text = "Select";
            txtAuthor.Text = "";
            txtBarCode.Text = "";
            txtTracking.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtQuantity.Text = "";
            txtPublish.Text = "";
            txtCategories.Text = "";
        }
        #endregion

        #region Button  🗸 
        private void btnChargeOtherInfo_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT [id],[Tracking], [Title], [Author], [Quantity], [CostPrice], [SellingPrice], [Categories], [Publisher], [Barcode] FROM [dbo].[Books] WHERE [Title] = '" + ComboTitle.SelectedItem.ToString() + "' AND [UserId] = @UserId", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (ComboTitle.Items != null)
            {
                if (reader.Read())
                {
                    txtTracking.Text = reader["Tracking"].ToString();
                    txtAuthor.Text = reader["Author"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtCostPrice.Text = reader["CostPrice"].ToString();
                    txtSellingPrice.Text = reader["SellingPrice"].ToString();
                    txtCategories.Text = reader["Categories"].ToString();
                    txtPublish.Text = reader["Publisher"].ToString();
                    txtBarCode.Text = reader["Barcode"].ToString();
                }
            }
            sqlCommand.Parameters.Clear();
            sqlConnection.Close();
        }
        #endregion

        #region Charge Combo Box
        private void ChargeComboBox()
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT [Title] FROM [dbo].[Books] WHERE [UserId] = @UserId", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);
            sqlCommand.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                ComboTitle.Items.Add(item["Title"].ToString());
            }
            sqlConnection.Close();
        }
        #endregion

        #region Button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string command = @"UPDATE [dbo].[Books] SET [Quantity] = @Quantity,  [SellingPrice] = @SellingPrice WHERE [Title] = @Title AND [UserId] = @UserId";

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    sqlCommand.Parameters.AddWithValue("@SellingPrice", txtSellingPrice.Text);
                    sqlCommand.Parameters.AddWithValue("@Title", ComboTitle.Text);
                    sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Update");
                    ClearTextBoxses();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed update");
            }
        }
        #endregion
    }
}
