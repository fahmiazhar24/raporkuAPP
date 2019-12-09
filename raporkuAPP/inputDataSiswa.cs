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
            siswa.jenis_kelamin = jeniskelamin_CB.SelectedItem.ToString();
            siswa.alamat = alamat_tb.Text;
            siswa.nama_agama = agama_cb.SelectedItem.ToString();
            siswa.nama_ibu = ibu_tb.Text;
            siswa.nama_ayah = ayah_tb.Text;
            siswa.nomor_ortu = nomorortu_tb.Text;
            siswa.status_kawin = statuskawin_tb.Text;
            siswa.id_walikelas = walikelas_cb.SelectedItem.ToString();
            siswa.id_kelas = kelas_cb.SelectedItem.ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void walikelas_cb_Click(object sender, EventArgs e)
        {
            List<WaliKelas> wali = new List<WaliKelas>();

            String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");

            wali = JsonConvert.DeserializeObject<List<WaliKelas>>(result);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = wali;

            walikelas_cb.DataSource = bindingSource1.DataSource;

            //DataSet dataSet = new DataSet();
            //walikelas_cb.DataSource = dataSet.Tables[1];
            walikelas_cb.DisplayMember = "nama_walikelas";
            walikelas_cb.ValueMember = "nama_walikelas";




        }
    }

    public class Siswa
    {
        public string tempat_lahir { get; set; }
        
        public string tgl_lahir { get; set; }
        
        public string id_kelas { get; set; }
        
        public string nama_siswa { get; set; }
        
        public string id_siswa { get; set; }
        
        public string id_walikelas { get; set; }
        
        public string alamat { get; set; }
        
        public string nama_ibu { get; set; }
        
        public string nomor_ortu { get; set; }
        
        public string jenis_kelamin { get; set; }
        
        public string status_kawin { get; set; }
        
        public string nama_ayah { get; set; }
        
        public string nama_agama { get; set; }
    }
}
