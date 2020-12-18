using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Forms;

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlPurchaseDetails : UserControl
    {
        public UserControlPurchaseDetails()
        {
            InitializeComponent();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();

            addNewBook.ShowDialog();
        }

    }
}
