using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HavayoluYönetimSistemi
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (YolcuId.Text == "" || Yolcuİsmi.Text == "" || YolcuNo.Text == "" || YolcuAdres.Text == " " || NationalitiyCb.Text == ""  || GenderCb.Text == "" || TelefonTb.Text == "")
            {

                MessageBox.Show("Eksik Bilgi");
            }
       else
            {
                try
                {
                    Con.Open();
                    string query= "insert into YolcuTbl values (" + YolcuId.Text + " ,' " + Yolcuİsmi.Text + "',' " + YolcuNo.Text + "',' " + YolcuAdres.Text + "',' " + NationalitiyCb.SelectedItem.ToString() + "',' " + GenderCb.SelectedItem.ToString() + "',' " + TelefonTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yolcu Başarıyla Kaydedildi."); 
                    Con.Close();
                } catch(Exception Ex )
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        
        
        
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YolcuId.Text = "";
            Yolcuİsmi.Text = "";
            YolcuNo.Text = "";
            YolcuAdres.Text = " ";
            NationalitiyCb.SelectedItem = "";
            GenderCb.SelectedItem = "";
             TelefonTb.Text = "";
        }
    }
    }

