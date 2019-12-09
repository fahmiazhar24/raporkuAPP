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
            siswa.tgl_lahir = passWali_TB.Text;
            siswa.jenis_kelamin = namaSiswa_TB.Text;
            siswa.alamat = tempatlahir_TB.Text;
            siswa.nama_agama = passWali_TB.Text;
            siswa.nama_ibu = namaSiswa_TB.Text;
            siswa.nama_ayah = tempatlahir_TB.Text;
            siswa.nomor_ortu = passWali_TB.Text;
            siswa.status_kawin = namaSiswa_TB.Text;
            siswa.id_walikelas = tempatlahir_TB.Text;
            siswa.id_kelas = passWali_TB.Text;

            if (jeniskelamin_CB.SelectedIndex == 0)
            {
                waliKelas.id_kelas = "1";
            }
            else if (jeniskelamin_CB.SelectedIndex == 1)
            {
                waliKelas.id_kelas = "2";
            }

            addData(waliKelas);
            getData();
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
