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

namespace DYGO_GIRIS
{
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
            panel2.Parent = bakiyearkaplan;
            panel1.Parent = bakiyearkaplan;
            btnyükle.Parent = bakiyearkaplan;
        }


        public void para()
        {

            string getir = " select * from Bakiyeler ";
            SqlCommand komut = new SqlCommand(getir, con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(100,0,0,0);

            string getir = " select * from Bakiyeler ";
            SqlCommand komut = new SqlCommand(getir, con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");
        int i = 0;
        private void btnyükle_Click(object sender, EventArgs e)
        {

           if(TXTuyeid.Text != "" && TXTbakiye.Text != "")
            {
                bakiyesınıf.bakiye = TXTbakiye.Text;
                bakiyesınıf.bid = TXTuyeid.Text;
                con.Open();
                string getir = (" update   Bakiyeler set bakiye=@bakiye   where bid=@bid");      
            SqlCommand komut = new SqlCommand(getir, con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            komut.Parameters.AddWithValue("@bakiye",bakiyesınıf.bakiye);
                komut.Parameters.AddWithValue("@bid", bakiyesınıf.bid);

                DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
                komut.ExecuteNonQuery();
            con.Close();
                para();
            }
           


            




        }
    }
}
