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
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (UcusKod.Text == "" || Fsrc.Text == "" || FVarıs.Text == "" || FTarih.Text == " " || KoltukNum.Text == "" )
            {

                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UcusTbl values (" + UcusKod.Text + " ,' " + Fsrc.SelectedItem.ToString() + "',' " + FVarıs.SelectedItem.ToString() + "',' " + FTarih.Text + "',' " + KoltukNum.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uçuş Başarıyla Kaydedildi.");
                    Con.Close();
                  
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UcusKod.Text = "";
            Fsrc.SelectedItem = "";
            FVarıs.SelectedItem = "";
            FTarih.Text = "";
            KoltukNum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlights viewflt = new ViewFlights();
            viewflt.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Show();
        }
    }
}
