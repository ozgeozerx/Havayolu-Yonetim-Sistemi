using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavayoluYönetimSistemi
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from YolcuTbl";

            SqlDataAdapter sda = new SqlDataAdapter(query, Con); SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (YlcKimlik.Text == "")
            {
                MessageBox.Show("Silinecek Yolcuyu Girin.");
            } else
            {
                try
                {
                    Con.Open();
                    string query = " delete from YolcuTbl where YolcuId = " + YlcKimlik.Text + " ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yolcu Başarılı Bir Şekilde Silindi.");
                    populate();
                    Con.Close();
                } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (PassengerDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = PassengerDGV.SelectedRows[0];

                    YlcKimlik.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
                    YisimTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
                    PpassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
                    YolcuAdresTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
                    UyrukCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
                    CinsiyetCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        
        private void button3_Click(object sender, EventArgs e)
        {
            YlcKimlik.Text = " ";
            YisimTb.Text = " ";
            PpassTb.Text = " ";
            YolcuAdresTb.Text = " ";
            UyrukCb.SelectedItem = " ";
            CinsiyetCb.SelectedItem = " "; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (YlcKimlik.Text == "" || YisimTb.Text == "" || PpassTb.Text == "" || YolcuAdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " update YolcuTbl set Yolcuİsmi= '" + YisimTb.Text + " ' ,Pasaport= '" + PpassTb.Text + " ' ,YolcuAdres= '" + YolcuAdresTb.Text + " ',YolcuUyruk= '" + UyrukCb.SelectedItem.ToString() + " ',YolcuCinsiyet= '" + CinsiyetCb.SelectedItem.ToString() + " ',YolcuTel= '" + YtelTb.Text + " ' where YolcuId=" +YlcKimlik.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yolcu Başarıyla Güncellendi.");
                    populate();
                    Con.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
  }  }
