using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.UserControls
{
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        private void LoadChart() //Create Chart for Dash Board
        {
            chartReport.Series["Report"].Points.AddXY("Jan", 500);
            chartReport.Series["Report"].Points.AddXY("Feb", 60);
            chartReport.Series["Report"].Points.AddXY("Mar", 100);
            chartReport.Series["Report"].Points.AddXY("Apr", 1000);
            chartReport.Series["Report"].Points.AddXY("May", 800);
            chartReport.Series["Report"].Points.AddXY("Jun", 500);
            chartReport.Series["Report"].Points.AddXY("Jul", 500);
            chartReport.Series["Report"].Points.AddXY("Ago", 500);
            chartReport.Series["Report"].Points.AddXY("Set", 500);
            chartReport.Series["Report"].Points.AddXY("Oct", 500);
            chartReport.Series["Report"].Points.AddXY("Nov", 500);
            chartReport.Series["Report"].Points.AddXY("Dec", 500);
        }

        private void btnRefresh_Click(object sender, EventArgs e) //Load from button Refresh
        {
            LoadChart();
        }

    }
}
