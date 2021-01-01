using BookShopManagementSystem.EncryptionAndDecryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.Forms
{
    public partial class RegisterNewUser : Form
    {

        public RegisterNewUser()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.ShowDialog();
        }

        #region Button Register with execute in Database
        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");

            if (txtUserName.TextLength > 0 && txtFullName.TextLength > 0 && txtPhone.TextLength > 0
                && txtPass.TextLength > 0 && txtEmail.TextLength > 0)
            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" +
                   @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" +
                   @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);


                if (Regex.IsMatch(txtFullName.Text, @"^[a-zA-Z' ]+$") == true && Regex.IsMatch(txtPhone.Text, @"^[0-9()+ ]+$") == true
                    && regex.IsMatch(txtEmail.Text) == true)
                {
                    SqlCommand sqlCommand = new SqlCommand
                                     (@"INSERT INTO [dbo].[users]
                    ([UserName],[FullName],[Phone],[Email],[Password],[Role])
                    VALUES
                    ('" + txtUserName.Text + "', " +
                                        "'" + txtFullName.Text + "'," +
                                        "'" + txtPhone.Text + "'," +
                                        "'" + txtEmail.Text + "'," +
                                        "'" + Cryptography.Encrypt(txtPass.Text) + "'," +
                                        "'" + comboBoxRole.SelectedItem.ToString() + "')", sql);

                    sql.Open();
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Register Successfully");

                    LoginForm loginForm = new LoginForm();

                    this.Hide();

                    loginForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    if (Regex.IsMatch(txtFullName.Text, @"^[a-zA-Z' ]+$") == false)
                    {
                        MessageBox.Show("The field Full Name contains invalid characters");
                    }
                    else if (Regex.IsMatch(txtPhone.Text, @"^[0-9()+ ]+$") == false)
                    {
                        MessageBox.Show("The field Phone contains invalid characters");
                    }
                    else if (regex.IsMatch(txtEmail.Text) == false)
                    {
                        MessageBox.Show("Invalid email");
                    }
                }
            }
        }
        #endregion
    }
}
