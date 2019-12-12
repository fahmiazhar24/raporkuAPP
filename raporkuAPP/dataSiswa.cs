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
    public partial class dataSiswa : Form
    {
        public dataSiswa()
        {
            InitializeComponent();
            List<WaliKelas> walis = new List<WaliKelas>();

            String result = new WebClient().DownloadString(Data.Uri + "datasiswa");

            walis = JsonConvert.DeserializeObject<List<WaliKelas>>(result);

            var bindingList = new BindingList<WaliKelas>(walis);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            menuWali menu = new menuWali();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
