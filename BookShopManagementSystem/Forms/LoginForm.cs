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

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT [UserName], [Password] FROM [dbo].[users] WHERE [UserName] = '"+txtUser.Text+"'", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                password = reader["Password"].ToString();
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
                MessageBox.Show("Password is wrong");
            }

            sqlConnection.Close();
        }
    }
}
