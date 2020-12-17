using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DaschBoard daschBoard = new DaschBoard();
            this.Hide();

            daschBoard.ShowDialog();

            this.Close();

        }
    }
}
