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

        private void btShow_Click(object sender, EventArgs e)
        {
            List<Siswa> isiswa = new List<Siswa>();

            String result = new WebClient().DownloadString(baseUri + "dataSiswa");

            isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            var bindingList = new BindingList<Siswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
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
