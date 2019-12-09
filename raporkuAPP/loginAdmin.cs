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
    public partial class loginAdmin : Form
    {
        public static String baseUri = "http://localhost:1313/Service1.svc/";
        public loginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();
                String result = new WebClient().DownloadString(baseUri + "getAdmin/id=" + textBox_uname.Text);
                admin = JsonConvert.DeserializeObject<Admin>(result);
                if (textBox_uname.Text == admin.uname_admin && textBox_passw.Text == admin.passw_admin)
                {
                    //MessageBox.Show("Username Benar");
                    formAdmin log = new formAdmin();
                    log.Show();
                    //username = textBox_username.Text;
                    //Welcome welcome = new Welcome();
                    //this.Hide();
                    //welcome.Show();
                }
                else if (textBox_uname.Text != admin.uname_admin && textBox_passw.Text == admin.passw_admin)
                {
                    MessageBox.Show("Username atau Password Salah");
                    //username = textBox_username.Text;
                    //Welcome welcome = new Welcome();
                    //this.Hide();
                    //welcome.Show();
                }
            }
            catch
            {
                if (textBox_uname.Text == "")
                {
                    MessageBox.Show("Isi Username Anda");
                }
                else if (textBox_passw.Text == "")
                {
                    MessageBox.Show("Isi Password Anda");
                }
                else
                {
                    MessageBox.Show("Username atau Password anda salah!!!");
                }
                //MessageBox.Show("Username Salah");
            }

        }

        public class Admin
        {
            public string id_admin { get; set; }
            public string uname_admin { get; set; }
            public string passw_admin { get; set; }
        }
    }
}
