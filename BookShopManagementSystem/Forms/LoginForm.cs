using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookShopManagementSystem.EncryptionAndDecryption;

namespace BookShopManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public static string userLogin;
        public static  string userRole;
        public static int userId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCloseOne_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.ShowDialog();
        }

        private void labelForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string password = "";

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PO35QJG;Initial Catalog=bookshop;Integrated Security=True");

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT [id], [UserName], [Password], [Role] FROM [dbo].[Users] WHERE [UserName] = '"+txtUser.Text.Trim()+"'", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                password = reader["Password"].ToString().Trim();
                userRole = reader["Role"].ToString().Trim();
                userLogin = reader["UserName"].ToString().Trim();
                userId = (int)reader["id"]; 
            }
            
            if (Cryptography.Decrypt(password) == txtPass.Text)
            {
                DaschBoard daschBoard = new DaschBoard();
                this.Hide();
                daschBoard.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usename or Password is wrong");
            }

            sqlCommand.Parameters.Clear();
            sqlConnection.Close();
        }
    }
}
