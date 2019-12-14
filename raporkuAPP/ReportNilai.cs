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
        string idkelas, idsiswa;
        public static String baseUri = Data.Uri;
        public ReportNilai()
        {
            InitializeComponent();
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


            ///

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            idsiswa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
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

        //private void bt_export_Click_1(object sender, EventArgs e)
        //{
        //    //// creating Excel Application  
        //    //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    //// creating new WorkBook within Excel application  
        //    //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    //// creating new Excelsheet in workbook  
        //    //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //    //// see the excel sheet behind the program  
        //    //app.Visible = true;
        //    //// get the reference of first sheet. By default its name is Sheet1.  
        //    //// store its reference to worksheet  
        //    //worksheet = workbook.Sheets["Sheet1"];
        //    //worksheet = workbook.ActiveSheet;
        //    //// changing the name of active sheet  
        //    //worksheet.Name = "Exported from gridview";
        //    //// storing header part in Excel  
        //    //for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
        //    //{
        //    //    worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
        //    //}
        //    //// storing Each row and column value to excel sheet  
        //    //for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
        //    //{
        //    //    for (int j = 0; j < dataGridView2.Columns.Count; j++)
        //    //    {
        //    //        worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
        //    //    }
        //    //}
        //    //// save the application  
        //    //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    //// Exit from the application  
        //    //app.Quit();

        //    //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //    //app.Visible = true;
        //    //worksheet = workbook.Sheets["Sheet1"];
        //    //worksheet = workbook.ActiveSheet;
        //    //for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
        //    //{
        //    //    worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
        //    //}
        //    //for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
        //    //{
        //    //    for (int j = 0; j < dataGridView2.Columns.Count; j++)
        //    //    {
        //    //        if (dataGridView2.Rows[i].Cells[j].Value != null)
        //    //        {
        //    //            worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
        //    //        }
        //    //        else
        //    //        {
        //    //            worksheet.Cells[i + 2, j + 1] = "";
        //    //        }
        //    //    }
        //    //}
        //    //SaveFileDialog sfd = new SaveFileDialog();
        //    //sfd.Filter = "Excel Documents (*.xls)|*.xls";
        //    //sfd.FileName = "export.xls";
        //    //if (sfd.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    //ToCsV(dataGridView1, @"c:\export.xls");
        //    //    ToCsV(dataGridView2, sfd.FileName); // Here dataGridview1 is your grid view name
        //    //}
        //    if (dataGridView2.Rows.Count > 0)
        //    {

        //        try
        //        {
        //            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

        //            ExcelApp.Application.Workbooks.Add(Type.Missing);

        //            Microsoft.Office.Interop.Excel.Application xlApp;
        //            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        //            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        //            object misValue = System.Reflection.Missing.Value;

        //            // Change properties of the Workbook 

        //            ExcelApp.Columns.ColumnWidth = 20;

        //            xlApp = new Microsoft.Office.Interop.Excel.Application();
        //            xlWorkBook = xlApp.Workbooks.Add(misValue);
        //            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

        //            // Storing header part in Excel

        //            for (int i = 1; i <= dataGridView2.Columns.Count; i++)
        //            {

        //                ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;

        //            }



        //            // Storing Each row and column value to excel sheet

        //            for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
        //            {
        //                for (int j = 0; j <= dataGridView2.ColumnCount - 1; j++)
        //                {
        //                    DataGridViewCell cell = dataGridView2[j, i];
        //                    ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
        //                }
        //            }

        //            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
        //            //{

        //            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //            //    {

        //            //        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

        //            //    }

        //            //}

        //            xlWorkBook.SaveAs("MasterReport.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        //            xlWorkBook.Close(true, misValue, misValue);
        //            xlApp.Quit();

        //            releaseObject(xlWorkSheet);
        //            releaseObject(xlWorkBook);
        //            releaseObject(xlApp);

        //            //ExcelApp.ActiveWorkbook.SaveCopyAs("C:\\Report.xls");

        //            //ExcelApp.ActiveWorkbook.Saved = true;

        //            //ExcelApp.Quit();

        //            MessageBox.Show("Excel file created , you can find the file in 'My Documents' Drive Name As MasterReport.xls", "Converted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("No Record Found to Convert, Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //    }
        //}

        private void copyAlltoClipboard()
        {
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        //private void ToCsV(DataGridView dGV, string filename)
        //{
        //    string stOutput = "";
        //    // Export titles:
        //    string sHeaders = "";

        //    for (int j = 0; j < dGV.Columns.Count; j++)
        //        sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
        //    stOutput += sHeaders + "\r\n";
        //    // Export data.
        //    for (int i = 0; i < dGV.RowCount - 1; i++)
        //    {
        //        string stLine = "";
        //        for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
        //            stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
        //        stOutput += stLine + "\r\n";
        //    }
        //    Encoding utf16 = Encoding.GetEncoding(1254);
        //    byte[] output = utf16.GetBytes(stOutput);
        //    FileStream fs = new FileStream(filename, FileMode.Create);
        //    BinaryWriter bw = new BinaryWriter(fs);
        //    bw.Write(output, 0, output.Length); //write the encoded file
        //    bw.Flush();
        //    bw.Close();
        //    fs.Close();
        //}
    }
}
