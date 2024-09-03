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
    public partial class UyeAra : Form
    {
        public UyeAra()
        {
            InitializeComponent();

            btnARA.Parent = pictureUYEARA;
            panel1.Parent = pictureUYEARA;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");




        public void uyecagir()
        {


            if(txtUYEARA.Text != "")
            {
                string getir = " select * from UyeEkle where uyeid = " + txtUYEARA.Text + "";
                SqlCommand komut = new SqlCommand(getir, con);
                SqlDataAdapter ad = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir ID Giriniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            
        }










        private void UyeAra_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);

            string getir = " select * from UyeEkle ";
            SqlCommand komut = new SqlCommand(getir, con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnARA_Click(object sender, EventArgs e)
        {

            
            uyecagir();


        }
    }
}
