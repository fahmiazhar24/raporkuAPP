using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raporkuAPP
{
    public partial class formMain : Form
    {
        public static String baseUri = Data.Uri;
        public static string idkelas;
        public formMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new splashScreen());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginAdmin log = new loginAdmin();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WaliKelas waliKelas = new WaliKelas();
                String result = new WebClient().DownloadString(baseUri + "getWalikelas/username=" + textBox_.Text);
                waliKelas = JsonConvert.DeserializeObject<WaliKelas>(result);
                idkelas = waliKelas.id_kelas;
                if (textBox_.Text == waliKelas.uname_walikelas && textBox2.Text == waliKelas.passw_walikelas)
                {
                    //MessageBox.Show("Username Benar");
                    menuWali log = new menuWali();
                    this.Hide();
                    log.Show();
                    //username = textBox_username.Text;
                    //Welcome welcome = new Welcome();
                    //this.Hide();
                    //welcome.Show();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Isi Password Anda");
                }
                else if (textBox_.Text != waliKelas.uname_walikelas)
                {
                    MessageBox.Show("Username tidak terdaftar");
                }
                else if (textBox_.Text != waliKelas.uname_walikelas || textBox2.Text != waliKelas.passw_walikelas)
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
                if (textBox_.Text == "")
                {
                    MessageBox.Show("Isi Username Anda");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
