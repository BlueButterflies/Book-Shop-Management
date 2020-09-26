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
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void btnCloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
            txtTitle.Text = "";
            txtRemarkers.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtBarCode.Text = "";
            textAuthor.Text = "";
            comboBoxCategory.Text = "";
            txtPublish.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnCloseWin_Click(sender, e);
        }

        private void checkBoxBarCode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBarCode.Checked)
            {
                
            }
        }

        //    string barCode = txtBarCode.Text;
        //    try
        //    {
        //        Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
        //        //pictureBoxBarCode.Image = brCode.Draw(barCode, 20);
        //    }
        //    catch (Exception)
        //    {

        //    }
    }
}
