using BookShopManagementSystem.UserControls;
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
using BookShopManagementSystem.Forms;

//TO DO Check if user is login and get your username  
namespace BookShopManagementSystem.Forms
{
    public partial class DaschBoard : Form
    {
        
        int PanelWigth;
        bool isCollapsed;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bookDb;Integrated Security=True");
        
        public DaschBoard()
        {
            InitializeComponent();

            UserControlHome userHome = new UserControlHome();//Charge  chart dashboard open after login
            AddControlerPanel(userHome);

            //string user = "";
            //string role = "";

            //#region Use database
            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand("select [UserName], [Role] From [dbo].[users]", sqlConnection);

            //SqlDataReader readerDb = sqlCommand.ExecuteReader();

            //if (readerDb.Read())
            //{
            //    user = readerDb["UserName"].ToString();
            //    role = readerDb["Role"].ToString();
            //}

            //sqlCommand.Parameters.Clear();
            //sqlConnection.Close();
            //#endregion

            labelWelcome.Text = "Welcome: " + LoginForm.userLogin;
            labelRole.Text = "Role: " + LoginForm.userRole;

            timerTimes.Start();
            PanelWigth = panelLeft.Width;
            isCollapsed = false;
        }

        private void btnCloseTwo_Click(object sender, EventArgs e)//Button Close Windows
        {
            this.Close();
        }

        #region Expanded and close panel Menu
        private void timerPanelLeft_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;

                if (panelLeft.Width >= PanelWigth)
                {
                    timerPanelLeft.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;

                if (panelLeft.Width <= 64)
                {
                    timerPanelLeft.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerPanelLeft.Start();
        }
        #endregion

        #region Move Side Panel with panel buttons

        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlerPanel(Control control)
        {
            control.Dock = DockStyle.Fill;

            panelUser.Controls.Clear();
            panelUser.Controls.Add(control);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnHome);

            UserControlHome userHome = new UserControlHome();
            AddControlerPanel(userHome);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSaleBooks);

            UserControlersSales sales = new UserControlersSales();
            AddControlerPanel(sales);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnView);

            UserControlViewSales userControlViewSales = new UserControlViewSales();
            AddControlerPanel(userControlViewSales);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnPurchase);

            UserControlPurchaseDetails purchaseDetails = new UserControlPurchaseDetails();
            AddControlerPanel(purchaseDetails);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnExpenses);

            UserControlManagerExpens expenses = new UserControlManagerExpens();
            AddControlerPanel(expenses);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnUser);

            UserControlMamagerUsers userControlMamagerUsers = new UserControlMamagerUsers();
            AddControlerPanel(userControlMamagerUsers);
        }

        #endregion

        private void timerTimes_Tick(object sender, EventArgs e)// View Time Now in User Page
        {
            DateTime time = DateTime.Now;

            labelTimeData.Text = time.ToString();
        }
    }
}
