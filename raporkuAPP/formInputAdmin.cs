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
    public partial class formInputAdmin : Form
    {
        public static String baseUri = "http://localhost:1313/Service1.svc/";
        public formInputAdmin()
        {
            InitializeComponent();
        }

        static void addData(WaliKelas waliKelas)
        {
            string request = JsonConvert.SerializeObject(waliKelas);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "adddataWaliKelas", request);
            MessageBox.Show(response);
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            WaliKelas waliKelas = new WaliKelas();
            waliKelas.nama_walikelas = namaWali_TB.Text;
            waliKelas.uname_walikelas = userWali_TB.Text;
            waliKelas.passw_walikelas = passWali_TB.Text;

            if (Kelas_CB.SelectedIndex == 0)
            {
                waliKelas.id_kelas = "1";
            }
            else if (Kelas_CB.SelectedIndex == 1)
            {
                waliKelas.id_kelas = "2";
            }

            addData(waliKelas);

            //List<WaliKelas> walis = new List<WaliKelas>();

            //String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");

            //walis = JsonConvert.DeserializeObject<List<WaliKelas>>(result);

            //var bindingList = new BindingList<WaliKelas>(walis);
            //var source = new BindingSource(bindingList, null);
            //dataGridView1.DataSource = source;
        }
    }

    public class WaliKelas
    {
        
        //public string id_walikelas { get; set; }
        public string nama_walikelas { get; set; }
        public string uname_walikelas { get; set; }
        public string passw_walikelas { get; set; }
        public string id_kelas { get; set; }
    }
}
