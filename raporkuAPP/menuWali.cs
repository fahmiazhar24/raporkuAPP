using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raporkuAPP
{
    public partial class menuWali : Form
    {
        public static string cekLog;
        public menuWali()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cekLog = "1";
            formMain main = new formMain();
            main.Show();
            this.Hide();
        }

        private void btDataSiswa_Click(object sender, EventArgs e)
        {
            dataSiswa ds = new dataSiswa();
            ds.Show();
            this.Hide();
        }

        private void btInputRapor_Click(object sender, EventArgs e)
        {
            raporku raporku = new raporku();
            raporku.Show();
            this.Hide();
        }
    }
}
