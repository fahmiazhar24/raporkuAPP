﻿using Newtonsoft.Json;
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
        string idwk, nama, user, pass, Kelas;
        public static String baseUri = Data.Uri;
        
        public formInputAdmin()
        {
            InitializeComponent();

            namaWali_TB.Text = "";

            getData();
        }

        private void getData()
        {
            List<WaliKelas> walis = new List<WaliKelas>();

            String result = new WebClient().DownloadString(baseUri + "dataWaliKelas");

            walis = JsonConvert.DeserializeObject<List<WaliKelas>>(result);

            var bindingList = new BindingList<WaliKelas>(walis);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
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

        static void updateData(WaliKelas wali)
        {
            string request = JsonConvert.SerializeObject(wali);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "updatedataWaliKelas", request);
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
            getData();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            idwk = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            nama = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            user = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            pass = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            Kelas = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            namaWali_TB.Text = nama;
            userWali_TB.Text = user;
            passWali_TB.Text = pass;

            if (Kelas == "1")
            {
                Kelas_CB.Text = "IPA";
            }
            else if (Kelas_CB.Text == "2")
            {
                Kelas = "IPS";
            }
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            WaliKelas wali = new WaliKelas();
            wali.id_walikelas = idwk;
            wali.nama_walikelas = namaWali_TB.Text;
            wali.uname_walikelas = userWali_TB.Text;
            wali.passw_walikelas = passWali_TB.Text;

            if (Kelas_CB.SelectedIndex == 0)
            {
                wali.id_kelas = "1";
            }
            else if (Kelas_CB.SelectedIndex == 1)
            {
                wali.id_kelas = "2";
            }

            updateData(wali);
            getData();
        }
    }

    //public class WaliKelas
    //{
        
    //    public string id_walikelas { get; set; }
    //    public string nama_walikelas { get; set; }
    //    public string uname_walikelas { get; set; }
    //    public string passw_walikelas { get; set; }
    //    public string id_kelas { get; set; }
    //}
}
