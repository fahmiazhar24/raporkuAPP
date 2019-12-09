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
    public partial class dataSiswa : Form
    {
        public dataSiswa()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            menuWali menu = new menuWali();
            menu.Show();
            this.Hide();
        }
    }
}
