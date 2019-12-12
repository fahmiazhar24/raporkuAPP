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
        public loginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();
                String result = new WebClient().DownloadString(Data.Uri + "getAdmin/id=" + textBox_uname.Text);
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
                else if (textBox_passw.Text == "")
                {
                    MessageBox.Show("Isi Password Anda");
                }
                else if (textBox_uname.Text != admin.uname_admin)
                {
                    MessageBox.Show("Username Tidak Terdaftar");
                }
                else if (textBox_uname.Text != admin.uname_admin || textBox_passw.Text != admin.passw_admin)
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
            }

        }

        public class Admin
        {
            public string id_admin { get; set; }
            public string uname_admin { get; set; }
            public string passw_admin { get; set; }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            formMain formMain = new formMain();
            formMain.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_passw.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_passw.UseSystemPasswordChar = true;
            }
        }

        private void textBox_uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }

        private void textBox_passw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }
    }
}
