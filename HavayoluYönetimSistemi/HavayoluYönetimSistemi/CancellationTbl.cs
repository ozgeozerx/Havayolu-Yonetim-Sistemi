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
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=OZGEOZER0;Initial Catalog=HavayoluDb;Integrated Security=True");
        private void fillTicket()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" select BiletId from BiletTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BiletId", typeof(int));
            dt.Load(rdr);
            BltId.ValueMember = "BiletId";
            BltId.DataSource = dt;
            Con.Close();
        }
        private void fetchfcode()
        {
            Con.Open();
            string query = "select * from BiletTbl where BiletId=" + BltId.SelectedValue.ToString()+ "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                UKodTb.Text = dr["FKod"].ToString();
            }
            Con.Close();

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from IptalTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con); SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicket();
            populate();
        }

        private void BltId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Show();


        }
        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = " delete from BiletTbl where BiletId = " + BltId.SelectedValue.ToString() + " ;";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (IptalId.Text == "" || UKodTb.Text == "")
            {

                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into IptalTbl values (" + IptalId.Text + " ,' " + BltId.SelectedValue.ToString() + "',' " + UKodTb.Text + "',' " + IptalTrh.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilet Başarıyla İptal Edildi.");
                    Con.Close();
                    populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IptalId.Text = "";
            UKodTb.Text = "";

        }
    }
}
