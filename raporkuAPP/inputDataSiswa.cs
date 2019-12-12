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
    public partial class inputDataSiswa : UserControl
    {
        public static String baseUri = Data.Uri;
        string idsiswa, kelas;
        public inputDataSiswa()
        {
            InitializeComponent();
            //WaliKelas waliKelas = new WaliKelas();
            //String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");
            //DataSet dataSet = new DataSet();
            //walikelas_cb.DataSource = dataSet.Tables[1];
            //walikelas_cb.DisplayMember = "walikelas";
            //walikelas_cb.ValueMember = "Nama_Wali_Kelas";
        }

        private void getData()
        {
            List<Siswa> isiswa = new List<Siswa>();

            String result = new WebClient().DownloadString(baseUri + "dataSiswa");

            isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            var bindingList = new BindingList<Siswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        static void addData(Siswa siswa)
        {
            string request = JsonConvert.SerializeObject(siswa);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "adddataSiswa", request);
            MessageBox.Show(response);
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            List<Siswa> isiswa = new List<Siswa>();

            String result = new WebClient().DownloadString(baseUri + "dataSiswa");

            isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            var bindingList = new BindingList<Siswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        static void updateData(Siswa siswa)
        {
            string request = JsonConvert.SerializeObject(siswa);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "updatedatasiswa", request);
            MessageBox.Show(response);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Siswa siswa = new Siswa();
            siswa.nama_siswa = namaSiswa_TB.Text;
            siswa.tempat_lahir = tempatlahir_TB.Text;
            siswa.tgl_lahir = tglLahir_DTP.Value.ToString();
            //siswa.tgl_lahir = "11/11/2019";
            siswa.jenis_kelamin = jeniskelamin_CB.SelectedItem.ToString();
            siswa.alamat = alamat_tb.Text;
            siswa.nama_agama = agama_cb.SelectedItem.ToString();
            siswa.nama_ibu = ibu_tb.Text;
            siswa.nama_ayah = ayah_tb.Text;
            siswa.nomor_ortu = nomorortu_tb.Text;
            siswa.status_kawin = statuskawin_tb.Text;
            siswa.id_walikelas = walikelas_cb.SelectedValue.ToString();
            //siswa.id_kelas = kelas_cb.SelectedItem.ToString();
            if (kelas_cb.SelectedIndex == 0)
            {
                siswa.id_kelas = "1";
            }
            else if (kelas_cb.SelectedIndex == 1)
            {
                siswa.id_kelas = "2";
            }

            addData(siswa);
            getData();
        }

        private void getdatawali()
        {
            List<WaliKelas> wali = new List<WaliKelas>();

            String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");

            wali = JsonConvert.DeserializeObject<List<WaliKelas>>(result);
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            Siswa siswa = new Siswa();
            siswa.id_siswa = idsiswa;
            siswa.nama_siswa = namaSiswa_TB.Text;
            siswa.tempat_lahir = tempatlahir_TB.Text;
            siswa.tgl_lahir = tglLahir_DTP.Value.ToString();
            //siswa.tgl_lahir = "11/11/2019";
            siswa.jenis_kelamin = jeniskelamin_CB.SelectedItem.ToString();
            siswa.alamat = alamat_tb.Text;
            siswa.nama_agama = agama_cb.SelectedItem.ToString();
            siswa.nama_ibu = ibu_tb.Text;
            siswa.nama_ayah = ayah_tb.Text;
            siswa.nomor_ortu = nomorortu_tb.Text;
            siswa.status_kawin = statuskawin_tb.Text;
            siswa.id_walikelas = walikelas_cb.SelectedValue.ToString();
            //siswa.id_kelas = kelas_cb.SelectedItem.ToString();
            if (kelas_cb.SelectedIndex == 0)
            {
                siswa.id_kelas = "1";
            }
            else if (kelas_cb.SelectedIndex == 1)
            {
                siswa.id_kelas = "2";
            }

            updateData(siswa);
            getData();

            btSave.Enabled = true;
            button_update.Enabled = false;
        }

        private void inputDataSiswa_Load(object sender, EventArgs e)
        {
            kelas_cb.Enabled = false;
            button_update.Enabled = false;

            //get data to Combo box wali kelas
            List<WaliKelas> wali = new List<WaliKelas>();
            String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");
            wali = JsonConvert.DeserializeObject<List<WaliKelas>>(result);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = wali;

            walikelas_cb.DataSource = bindingSource1.DataSource;
            walikelas_cb.DisplayMember = "nama_walikelas";
            walikelas_cb.ValueMember = "id_walikelas";
            /////////////////////
        }

        private void walikelas_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (walikelas_cb.SelectedIndex == 0)
            {
                kelas_cb.SelectedIndex = 0;
            }
            else if (walikelas_cb.SelectedIndex == 1)
            {
                kelas_cb.SelectedIndex = 1;
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            namaSiswa_TB.Text = "";
            tempatlahir_TB.Text = "";
            alamat_tb.Text = "";
            agama_cb.SelectedItem = null;
            ibu_tb.Text = "";
            ayah_tb.Text = "";
            nomorortu_tb.Text = "";
            statuskawin_tb.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            idsiswa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            namaSiswa_TB.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            tempatlahir_TB.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tglLahir_DTP.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            jeniskelamin_CB.SelectedItem = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            alamat_tb.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            agama_cb.SelectedItem = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            ibu_tb.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            ayah_tb.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            namaSiswa_TB.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            nomorortu_tb.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            statuskawin_tb.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            walikelas_cb.SelectedValue = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            kelas = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

            if (kelas == "1")
            {
                kelas_cb.SelectedIndex = 0;
            }
            else if (kelas == "2")
            {
                kelas_cb.SelectedIndex = 1;
            }

            button_update.Enabled = true;
            btSave.Enabled = false;
        }
    }
}
