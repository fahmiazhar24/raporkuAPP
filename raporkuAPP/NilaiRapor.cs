using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace raporkuAPP
{
    public partial class NilaiRapor : UserControl
    {
        string idkelas, idsiswa, minat1, minat2;
        public static String baseUri = Data.Uri;
        public NilaiRapor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                idkelas = "1";
                pem1.Text = "BIOLOGI";
                pem2.Text = "MATEMATIKA";
                pem3.Text = "FISIKA";
                pem4.Text = "KIMIA";
                getData();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                idkelas = "2";
                pem1.Text = "GEOGRAFI";
                pem2.Text = "SOSIOLOGI";
                pem3.Text = "EKONOMI";
                pem4.Text = "SEJARAH";
                getData();
            }
        }
        static void addData(Rapot siswa)
        {
            string request = JsonConvert.SerializeObject(siswa);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "adddataRapot", request);
            MessageBox.Show(response);
        }

        private void getData()
        {
            List<Siswa> isiswa = new List<Siswa>();

            String result = new WebClient().DownloadString(baseUri + "getKelasSiswa/id=" + idkelas);

            isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            var bindingList = new BindingList<Siswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            //List<Siswa> isiswa = new List<Siswa>();

            //String result = new WebClient().DownloadString(baseUri + "dataSiswa");

            //isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            //var bindingList = new BindingList<Siswa>(isiswa);
            //var source = new BindingSource(bindingList, null);
            //dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            idsiswa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            label_nama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            List<Rapot> isiswa = new List<Rapot>();

            String result = new WebClient().DownloadString(baseUri + "getNilaiRapot/id=" + idkelas);

            isiswa = JsonConvert.DeserializeObject<List<Rapot>>(result);

            var bindingList = new BindingList<Rapot>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                minat1 = "1";
                minat2 = "2";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                minat1 = "9";
                minat2 = "10";
            }
            Rapot min1 = new Rapot();
            min1.id_siswa = idsiswa;
            min1.id_mapel = minat2;
            min1.id_rapot = idsiswa;
            min1.semester = comboBox2.SelectedItem.ToString();
            min1.nilai = comboBox3.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                min1.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                min1.id_kelas = "2";
            }

            Rapot min2 = new Rapot();
            min2.id_siswa = idsiswa;
            min2.id_mapel = minat1;
            min2.id_rapot = idsiswa;
            min2.semester = comboBox2.SelectedItem.ToString();
            min2.nilai = comboBox4.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                min2.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                min2.id_kelas = "2";
            }

            addData(min1);
            addData(min2);
        }
    }
}
