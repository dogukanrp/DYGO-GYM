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
    public partial class Ekipmanlar : Form
    {
        public Ekipmanlar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");

        private void Ekipmanlar_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnKAYIT_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Ekipmanlar (Ekipman,Aciklama,Hedefbolge,Tarih,Maliyet) VALUES (@Ekipman , @Aciklama , @Hedefbolge , @Tarih , @Maliyet)",con);
            cmd.Parameters.AddWithValue("@Ekipman",txtEkipman.Text);
            cmd.Parameters.AddWithValue("@Aciklama",txtAciklama.Text);
            cmd.Parameters.AddWithValue("@Hedefbolge", txtHEDEF.Text);
            cmd.Parameters.AddWithValue("@Tarih", dateTimePickerEKIPMAN.Value);
            cmd.Parameters.AddWithValue("@Maliyet", txtMaliyet.Text);

            con.Open();
            int donenDeger = cmd.ExecuteNonQuery();
            con.Close();

            if (donenDeger == 1)
            {
                MessageBox.Show("Ekipman Bilgileri Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("KAYIT SIRASINDA HATA OLUŞTU!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }









        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtEkipman.Clear();
            txtAciklama.Clear();
            txtHEDEF.Clear();
            dateTimePickerEKIPMAN.Value = DateTime.Now;
            txtMaliyet.Clear();
            
            
            
        }

        private void btnLISTELE_Click(object sender, EventArgs e)
        {
            EkipmanListele el = new EkipmanListele();
            el.Show();
        }
    }
}
