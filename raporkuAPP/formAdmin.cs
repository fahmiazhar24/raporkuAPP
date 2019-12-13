using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raporkuAPP
{
    public partial class formAdmin : Form
    {
        public static string cekLog;
        public formAdmin()
        {
            InitializeComponent();

            sidePanel.Height = btInputWali.Height;
            sidePanel.Top = btInputWali.Top;
            inputDataWali1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btInputWali.Height;
            sidePanel.Top = btInputWali.Top;
            inputDataWali1.BringToFront();
        }

        private void btInputSiswa_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btInputSiswa.Height;
            sidePanel.Top = btInputSiswa.Top;
            inputDataSiswa1.BringToFront();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            //loginAdmin loginAdmin = new loginAdmin();
            //this.Hide();
            //loginAdmin.Show();
            cekLog = "1";
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }
    }
}
