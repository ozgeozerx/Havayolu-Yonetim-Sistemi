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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BiletTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con); SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" select YolcuId from YolcuTbl" , Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("YolcuId", typeof(int));
            dt.Load(rdr);
            YlcIdCb.ValueMember = "YolcuId";
            YlcIdCb.DataSource = dt;
            Con.Close();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" select FKod from UcusTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FKod", typeof(int));
            dt.Load(rdr);
            UcusKodu.ValueMember = "FKod";
            UcusKodu.DataSource = dt;
            Con.Close();
        }

        string pname, ppass, pnat;
        private void fetchpassenger()
        {
            Con.Open();
            string query = "select * from YolcuTbl where YolcuId=" + YlcIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["Yolcuİsmi"].ToString();
                ppass = dr["Pasaport"].ToString();
                pnat = dr["YolcuUyruk"].ToString();
                YlcNameTb.Text = pname;
                PasTb.Text = ppass;
                YlcUyruk.Text = pnat;
            }
            Con.Close();

        }
    
            private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YlcIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BiletId.Text == "" || YlcNameTb.Text == "" )
            {

                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BiletTbl values (" + BiletId.Text + " ,' " + UcusKodu.SelectedValue.ToString() + "',' " + YlcIdCb.SelectedValue.ToString() + "',' " + YlcNameTb.Text + "',' " + PasTb.Text + "',' " + YlcUyruk.Text + "',' " + TutarTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon Başarıyla Kaydedildi.");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            YlcNameTb.Text = "";
            PasTb.Text = "";
            YlcUyruk.Text = "";
            TutarTb.Text = "";
            BiletId.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();

        }
    }
}
