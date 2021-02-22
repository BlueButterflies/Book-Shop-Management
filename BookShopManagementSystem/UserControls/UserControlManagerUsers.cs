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
    public partial class UserControlManagerUsers : UserControl
    {
        //Connect with database  
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

        public UserControlManagerUsers()
        {
            InitializeComponent();
        }

        #region Button Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtChangePass.Text = "";
            txtConfirmPass.Text = "";
            comboBoxRole.Text = "Select";
        }
        #endregion

        #region Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pass = "";

            if (txtPass.Text == txtChangePass.Text)
            {
                MessageBox.Show("Your new password it must be different from the old password.");
            }
            else
            {
                if (txtConfirmPass.Text != txtChangePass.Text)
                {
                    MessageBox.Show("New password and confirm password are not the same.");
                }
                else
                {
                    pass = txtConfirmPass.Text;

                    SqlCommand sqlCommand = new SqlCommand(@"UPDATE [dbo].[Users] SET [Phone] = @Phone, [Email] = @Email, [Password] =  @Password WHERE [id] = @Userid", sqlConnect);

                    sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@Password",EncryptionAndDecryption.Cryptography.Encrypt(pass));
                    sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Saved");
                }
            }
        }
        #endregion

        #region Method Select from database
        private void SelectFromDatabase()
        {
            string password = "";
            SqlCommand sqlCommand = new SqlCommand(@"SELECT [UserName],[FullName],[Phone],[Email],[Password],[Role] FROM [dbo].[Users] WHERE [id] = @UserId", sqlConnect);
            sqlCommand.Parameters.AddWithValue("@UserId", LoginForm.userId);

            sqlConnect.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                txtUserName.Text = sqlDataReader["UserName"].ToString();
                txtFullName.Text = sqlDataReader["FullName"].ToString();
                txtPhone.Text = sqlDataReader["Phone"].ToString();
                txtEmail.Text = sqlDataReader["Email"].ToString();
                password = sqlDataReader["Password"].ToString();
                comboBoxRole.Text = sqlDataReader["Role"].ToString();
            }

            sqlConnect.Close();
            txtPass.Text = EncryptionAndDecryption.Cryptography.Decrypt(password);
        }
        #endregion

        #region Load Control Manager Users
        private void UserControlMamagerUsers_Load(object sender, EventArgs e)
        {
            SelectFromDatabase();
        }
        #endregion
    }
}
