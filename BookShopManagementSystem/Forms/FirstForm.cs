using BookShopManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }


        private void btnCloseOne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// Link for Register Form
        {
            RegisterNewUser registerNewUser = new RegisterNewUser();

            this.Hide();

            registerNewUser.ShowDialog();

            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Link for Login Form
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.ShowDialog();

            this.Close();
        }
    }
}
