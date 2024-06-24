using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluYönetimSistemi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıAdı.Text = "";
            SifreTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullanıcıAdı.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve Şifreyi Giriniz");
            }
            else if (KullanıcıAdı.Text == "Admin" && SifreTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void SifreTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
