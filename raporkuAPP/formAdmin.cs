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
        public static String baseUri = "http://localhost:1313/Service1.svc/";
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

    }
}
