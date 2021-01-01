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
using System.Data.SqlClient;

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

        private void table_phonebook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    //Selected Cell Position
                    dataGridPurchase.CurrentCell = dataGridPurchase.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridPurchase.Rows[e.RowIndex].Selected = true;
                    dataGridPurchase.Focus();

                //    //Veiw Context Menu
                //    //dataGridPurchase.ContextMenuStrip = contextMenu;
                //    Point positionContextMenu = new Point(MousePosition.X, MousePosition.Y);
                //    dataGridPurchase.ContextMenuStrip.Show(positionContextMenu);
                //    dataGridPurchase.ContextMenuStrip = null;
                }
                //else
                //{
                //    dataGridPurchase.ContextMenuStrip = null;
                //}
            }
        }

        private void dataGridPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");

            SqlCommand sqlCommand = new SqlCommand(@"SELECT [[TrackingId]]],[Title],[[Author]]],[Quantity],[CostPrice],[SellingPrice],[Categories],[BarCode],[Publisher] FROM [dbo].[books]");

            foreach(var item in sqlCommand.ToString())
            {
                dataGridPurchase.Rows[0].Cells[0].Value = item;
            }
        }
    }
}
