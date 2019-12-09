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
    public partial class raporku : Form
    {
        public raporku()
        {
            InitializeComponent();

            sidePanel.Height = btInpuNilai.Height;
            sidePanel.Top = btInpuNilai.Top;
            nilaiRapor1.BringToFront();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btReport.Height;
            sidePanel.Top = btReport.Top;
        }

        private void btInputNilai_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btInpuNilai.Height;
            sidePanel.Top = btInpuNilai.Top;
            nilaiRapor1.BringToFront();
        }
    }
}
