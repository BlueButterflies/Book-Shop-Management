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
    public partial class UserControlersSales : UserControl
    {
        public UserControlersSales()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            FinishOrder finishOrder = new FinishOrder();

            finishOrder.ShowDialog();
        }

    }
}
