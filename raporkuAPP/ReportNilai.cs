using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace raporkuAPP
{
    public partial class ReportNilai : UserControl
    {
        string idkelas;
        public static String baseUri = Data.Uri;
        public ReportNilai()
        {
            InitializeComponent();
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            //using (Bitmap b = new Bitmap(this.Width, this.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(b))
            //    {
            //        g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
            //    }
            //    Document doc = new Document();
            //    iTextSharp.text.Image i = iTextSharp.text.Image.GetInstance(b, System.Drawing.Imaging.ImageFormat.Bmp);
            //    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"D:\output.pdf", FileMode.Create));
            //    doc.SetPageSize(new iTextSharp.text.Rectangle(this.Size.Width + doc.LeftMargin + doc.RightMargin, this.Size.Height + doc.TopMargin + doc.BottomMargin));

            //    doc.Open();

            //    doc.Add(i);
            //    doc.Close();
            //}

        }

        private void ReportNilai_Load(object sender, EventArgs e)
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
            comboBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                idkelas = "1";
                //pem1.Text = "BIOLOGI";
                //pem2.Text = "MATEMATIKA";
                //pem3.Text = "FISIKA";
                //pem4.Text = "KIMIA";
                getData();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                idkelas = "2";
                //pem1.Text = "GEOGRAFI";
                //pem2.Text = "SOSIOLOGI";
                //pem3.Text = "EKONOMI";
                //pem4.Text = "SEJARAH";
                getData();
            }
        }

        private void getData()
        {
            List<Siswa> isiswa = new List<Siswa>();

            String result = new WebClient().DownloadString(baseUri + "getKelasSiswa/id=" + idkelas);

            isiswa = JsonConvert.DeserializeObject<List<Siswa>>(result);

            var bindingList = new BindingList<Siswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string idsiswa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            //label_nama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            List<ReportNilaiSiswa> isiswa = new List<ReportNilaiSiswa>();

            String result = new WebClient().DownloadString(baseUri + "reportNilaiSiswa/ids=" + idsiswa);

            isiswa = JsonConvert.DeserializeObject<List<ReportNilaiSiswa>>(result);
           
            //Rapot rp = new Rapot();
            //if (rp.id_mapel == "1")
            //{
            //    mapel = "BIOLOGI";
            //}

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = isiswa;
            dataGridView2.DataSource = bindingSource1.DataSource;

            ////var bindingList = new BindingList<Rapot>(isiswa);
            ////var source = new BindingSource(bindingList, null);
            ///
            //dataGridView2.DataSource = bindingSource1.DataSource;
            //dataGridView2.Rows.Add();
            //dataGridView2.Rows[0].Cells["Column1"].Value = mapel;
            //dataGridView2.Rows[0].Cells["Column2"].Value = "nilai";


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterSem();
        }

        private void filterSem()
        {
            List<ReportNilaiSiswa> isiswa = new List<ReportNilaiSiswa>();

            String result = new WebClient().DownloadString(baseUri + "filterSemesterv2/Semester=" + comboBox2.Text);

            isiswa = JsonConvert.DeserializeObject<List<ReportNilaiSiswa>>(result);

            var bindingList = new BindingList<ReportNilaiSiswa>(isiswa);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }

        private void bt_export_Click_1(object sender, EventArgs e)
        {

        }
    }
}
