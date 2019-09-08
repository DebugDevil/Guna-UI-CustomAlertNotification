using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAlertNotificationsCShrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frmAlert.alertTypeEnum type)
        {
            frmAlert f = new frmAlert();
            f.setAlert(msg, type);
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Alert("Success message", frmAlert.alertTypeEnum.Success);
        }

        private void GunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Alert("Warning message", frmAlert.alertTypeEnum.Warning);
        }

        private void GunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Alert("Error message", frmAlert.alertTypeEnum.Error);
        }

        private void GunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.Alert("Info message", frmAlert.alertTypeEnum.Info);
        }
    }
}
