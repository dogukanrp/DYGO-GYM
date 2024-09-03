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
    public partial class EkipmanListele : Form
    {
        public EkipmanListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");



        public void listele()
        {

            
            string getir = " select * from Ekipmanlar";
            SqlCommand komut = new SqlCommand(getir , con);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }




        private void EkipmanListele_Load(object sender, EventArgs e)
        {
            
            
            listele();

            

        }
    }
}
