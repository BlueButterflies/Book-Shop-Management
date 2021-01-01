using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem.CostumControl
{
    class DargControl : Component
    {
        private Control handerControl;

        public Control SelectControl 
        {
            get 
            { 
                return this.handerControl;
            }
            set
            {
                this.handerControl = value;
                this.handerControl.MouseDown += new MouseEventHandler(this.DargFormMoueDown);
            } 
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int message, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DargFormMoueDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;

            if (flag)
            {
                DargControl.ReleaseCapture();
                DargControl.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
