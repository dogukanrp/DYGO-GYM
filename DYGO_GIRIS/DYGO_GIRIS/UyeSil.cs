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
    public partial class UyeSil : Form
    {
        public UyeSil()
        {
            InitializeComponent();

            btnSİL.Parent = uyesilarkaplan;
            panel1.Parent = uyesilarkaplan;
        }

        private void UyeSil_Load(object sender, EventArgs e)
        {
           panel1.BackColor = Color.FromArgb(100,0,0,0);

            listele();


        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");





        public void uyesil()
        {


            if(MessageBox.Show("Verileriniz silinecektir. Onaylıyor musunuz?","ÜYEYİ SİL",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtUYEsil.Text != "")
                {
                    string getir = " delete  from UyeEkle where uyeid = " + txtUYEsil.Text + "";
                    SqlCommand komut = new SqlCommand(getir, con);
                    SqlDataAdapter ad = new SqlDataAdapter(komut);

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;

                    con.Close();
                    listele();

                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Bir ID Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else
            {
                this.Activate();
                string getir = " select * from UyeEkle ";
                SqlCommand komut = new SqlCommand(getir, con);
                SqlDataAdapter ad = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }








            /*if (txtUYEsil.Text != "")
            {
                string getir = " delete  from UyeEkle where uyeid = " + txtUYEsil.Text + "";
             //   SqlCommand komut = new SqlCommand(getir, con);
                SqlDataAdapter ad = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir ID Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */

        }







        private void txtUYEsil_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {

            uyesil();




        }

        void listele()
        {
            string getir = " select * from UyeEkle ";
            SqlCommand komut = new SqlCommand(getir, con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            
        }
    }
}
