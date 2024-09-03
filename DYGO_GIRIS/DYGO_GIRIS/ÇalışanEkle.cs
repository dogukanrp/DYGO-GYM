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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DYGO_GIRIS
{
    public partial class calisanekle : Form
    {
        public calisanekle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUTTONkayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into CalisanEkle (calisanad,calisansoyad,calisancinsiyet,calisandogumgunu,calisantel,calisanmail,calisankayittarih,calisansehir) VALUES (@calisanad,@calisansoyad,@calisancinsiyet,@calisandogumgunu,@calisantel,@calisanmail,@calisankayittarih,@calisansehir)", con);
            cmd.Parameters.AddWithValue("@calisanad", TXTad.Text);
            cmd.Parameters.AddWithValue("@calisansoyad", TXTsoyad.Text);
            if (radioButtonERKEK.Checked)
            {
                cmd.Parameters.AddWithValue("@calisancinsiyet", radioButtonERKEK.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@calisancinsiyet",radioButtonKADIN.Text);
            }
            cmd.Parameters.AddWithValue("@calisandogumgunu", dateTimeCALISANdogum.Value);
            cmd.Parameters.AddWithValue("@calisantel", TXTtelefon.Text);
            cmd.Parameters.AddWithValue("@calisanmail", txtPOSTA.Text);
            cmd.Parameters.AddWithValue("@calisankayittarih", datetimeCALISANkayit.Value);
            cmd.Parameters.AddWithValue("@calisansehir", calisan_combobox.Text);
            
            con.Open();
            int donenDeger = cmd.ExecuteNonQuery();
            con.Close();

            if (donenDeger == 1)
            {
                MessageBox.Show("Kayıt Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("KAYIT SIRASINDA HATA OLUŞTU!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void BUTTONreset_Click(object sender, EventArgs e)
        {
            TXTad.Clear();
            TXTsoyad.Clear();
            radioButtonERKEK.Checked = false;
            radioButtonKADIN.Checked = false;
            TXTtelefon.Clear();
            dateTimeCALISANdogum.Value = DateTime.Now;
            datetimeCALISANkayit.Value = DateTime.Now;
            txtPOSTA.Clear();
            calisan_combobox.SelectedItem = null;
        }
    }
}
