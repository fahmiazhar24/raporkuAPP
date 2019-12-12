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
            //List<Siswa> isiswa = new List<Siswa>();

            //String result = new WebClient().DownloadString(Data.Uri + "datasiswa");

            //isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            //var bindingList = new BindingList<Siswa>(isiswa);
            //var source = new BindingSource(bindingList, null);
            //dataGridView1.DataSource = source;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raporkuDataSet1.siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.raporkuDataSet1.siswa);

        }
    }
}
