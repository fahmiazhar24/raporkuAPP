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
        string idkelas, idsiswa, minat1, minat2, minat3, minat4, umum1, umum2, umum3, umum4, id_mapel, nilai;

        private void bt_Update_Click(object sender, EventArgs e)
        {
            bt_Update.Enabled = false;
            button2.Enabled = true;
            ClearForm();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterSem();
        }

        private void ClearForm()
        {
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox8.Text = null;
            comboBox9.Text = null;
            comboBox10.Text = null;
            label_nama.Text = "";
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            //idsiswa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            id_mapel = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            nilai = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            //MessageBox.Show(id_mapel + " " + nilai);
            if (id_mapel == "1" || id_mapel == "9")
            {
                if (nilai == "100") { comboBox3.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox3.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox3.SelectedIndex = 2; }
            }
            else if (id_mapel == "2" || id_mapel == "10")
            {
                if (nilai == "100") { comboBox4.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox4.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox4.SelectedIndex = 2; }
            }
            else if (id_mapel == "3" || id_mapel == "11")
            {
                if (nilai == "100") { comboBox5.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox5.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox5.SelectedIndex = 2; }
            }
            else if (id_mapel == "4" || id_mapel == "12")
            {
                if (nilai == "100") { comboBox6.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox6.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox6.SelectedIndex = 2; }
            }
            else if (id_mapel == "5" || id_mapel == "13")
            {
                if (nilai == "100") { comboBox10.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox10.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox10.SelectedIndex = 2; }
            }
            else if (id_mapel == "6" || id_mapel == "14")
            {
                if (nilai == "100") { comboBox9.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox9.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox9.SelectedIndex = 2; }
            }
            else if (id_mapel == "7" || id_mapel == "15")
            {
                if (nilai == "100") { comboBox8.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox8.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox8.SelectedIndex = 2; }
            }
            else if (id_mapel == "8" || id_mapel == "16")
            {
                if (nilai == "100") { comboBox7.SelectedIndex = 0; }
                else if (nilai == "90") { comboBox7.SelectedIndex = 1; }
                else if (nilai == "80") { comboBox7.SelectedIndex = 2; }
            }

            bt_Update.Enabled = true;
            button2.Enabled = false;
        }

        private void NilaiRapor_Load(object sender, EventArgs e)
        {
            string id_kel = formMain.idkelas;
            if (id_kel == "1")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (id_kel == "2")
            {
                comboBox1.SelectedIndex = 1;
            }

            bt_Update.Enabled = false;
        }

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

            String result = new WebClient().DownloadString(baseUri + "getNilaiRapot/id=" + idsiswa);

            isiswa = JsonConvert.DeserializeObject<List<Rapot>>(result);

            var bindingList = new BindingList<Rapot>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }

        private void filterSem()
        {
            List<Rapot> isiswa = new List<Rapot>();

            String result = new WebClient().DownloadString(baseUri + "filterSemester/Semester=" + comboBox2.Text);

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
                minat3 = "3";
                minat4 = "4";
                umum1 = "5";
                umum2 = "6";
                umum3 = "7";
                umum4 = "8";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                minat1 = "9";
                minat2 = "10";
                minat3 = "11";
                minat4 = "12";
                umum1 = "13";
                umum2 = "14";
                umum3 = "15";
                umum4 = "16";
            }

            //PEMINATAN
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

            Rapot min3 = new Rapot();
            min3.id_siswa = idsiswa;
            min3.id_mapel = minat3;
            min3.id_rapot = idsiswa;
            min3.semester = comboBox2.SelectedItem.ToString();
            min3.nilai = comboBox5.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                min3.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                min3.id_kelas = "2";
            }

            Rapot min4 = new Rapot();
            min4.id_siswa = idsiswa;
            min4.id_mapel = minat4;
            min4.id_rapot = idsiswa;
            min4.semester = comboBox2.SelectedItem.ToString();
            min4.nilai = comboBox6.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                min4.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                min4.id_kelas = "2";
            }
            //END PEMINATAN

            //UMUM
            Rapot mum1 = new Rapot();
            mum1.id_siswa = idsiswa;
            mum1.id_mapel = umum1;
            mum1.id_rapot = idsiswa;
            mum1.semester = comboBox2.SelectedItem.ToString();
            mum1.nilai = comboBox10.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                mum1.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mum1.id_kelas = "2";
            }

            Rapot mum2 = new Rapot();
            mum2.id_siswa = idsiswa;
            mum2.id_mapel = umum2;
            mum2.id_rapot = idsiswa;
            mum2.semester = comboBox2.SelectedItem.ToString();
            mum2.nilai = comboBox9.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                mum2.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mum2.id_kelas = "2";
            }

            Rapot mum3 = new Rapot();
            mum3.id_siswa = idsiswa;
            mum3.id_mapel = umum3;
            mum3.id_rapot = idsiswa;
            mum3.semester = comboBox2.SelectedItem.ToString();
            mum3.nilai = comboBox8.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                mum3.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mum3.id_kelas = "2";
            }

            Rapot mum4 = new Rapot();
            mum4.id_siswa = idsiswa;
            mum4.id_mapel = umum4;
            mum4.id_rapot = idsiswa;
            mum4.semester = comboBox2.SelectedItem.ToString();
            mum4.nilai = comboBox7.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 0)
            {
                mum4.id_kelas = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mum4.id_kelas = "2";
            }
            //END UMUM

            addData(min1);
            addData(min2);
            addData(min3);
            addData(min4);
            addData(mum1);
            addData(mum2);
            addData(mum3);
            addData(mum4);

            ClearForm();
        }

        static void updateData(Rapot rapot)
        {
            string request = JsonConvert.SerializeObject(rapot);
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //client.UploadString(baseUri + "adddata", request);
            string response = client.UploadString(baseUri + "updateNilaiRapot", request);
            MessageBox.Show(response);
        }
    }
}
