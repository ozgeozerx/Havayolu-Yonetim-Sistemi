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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from UcusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con); SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTbl addfl = new FlightTbl();
            addfl.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            KltSayısı.Text = "";
       

        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FlightDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = FlightDGV.SelectedRows[0];
                FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
                SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
                VarısCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
                KltSayısı.Text = FlightDGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Silinecek Uçuşu Girin.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " delete from UcusTbl where FKod = " + FcodeTb.Text + " ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uçuş Başarılı Bir Şekilde Silindi.");
                    populate();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || KltSayısı.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " update UcusTbl set Fsrc= '" + SrcCb.SelectedItem.ToString() + " ' ,FVarıs= '" + VarısCb.SelectedItem.ToString() + " ' ,FTarih= '" + UTarih.Value.Date.ToString() + " ',FKoltuk= '" + KltSayısı.Text + " where FKod=" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uçuş Başarıyla Güncellendi.");
                    populate();
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}