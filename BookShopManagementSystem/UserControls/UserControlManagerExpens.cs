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
    public partial class UserControlManagerExpens : UserControl
    {
        public UserControlManagerExpens()
        {
            InitializeComponent();
        }

        private void btnAddNewExtens_Click(object sender, EventArgs e)
        {
            AddExpenses addExtenses = new AddExpenses();

            addExtenses.ShowDialog();
        }
    }
}
