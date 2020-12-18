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
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using BookShopManagementSystem.EncryptionAndDecryption;

namespace BookShopManagementSystem.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnBackCome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Get info from Database
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");

            string password = "";
            string email = "";

            sql.Open();
            SqlCommand sqlCommand = new SqlCommand
                (@"SELECT [Email], [Password] 
                   FROM [dbo].[users]
                   WHERE [UserName] = '" + txtUserName.Text + "'", sql);
            ;

            SqlDataReader readerDb = sqlCommand.ExecuteReader();
            if (readerDb.Read())
            {
                password = readerDb["Password"].ToString();   //get the user password and email from db if the user name is exist in that.  
                email = readerDb["Email"].ToString();
            }

            //Send email message
            try
            {
                string from = "dsvk23020818@outlook.it";
                string pass = "Vincenzokathryn1102";

                string subject = "Reset your password";
                string body = "As required - this is your password " + Cryptography.Decrypt(password) + "\n\n\nTeam BlueButterfliesDev";


                MailMessage message = new MailMessage(from, email, subject, body);

                SmtpClient smtpClient = new SmtpClient("smtp.outlook.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(from, pass);

                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtpClient.Send(message);

                MessageBox.Show("Required send successfully");

                //Close window after send message
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Close Database
            readerDb.Close();
            sqlCommand.Dispose();
            sql.Close();


        }
    }
}
