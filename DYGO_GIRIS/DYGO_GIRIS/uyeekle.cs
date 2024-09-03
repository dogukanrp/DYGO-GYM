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
    public partial class uyeekle : Form
    {
        

        public uyeekle()
        {
            InitializeComponent();


            uyeekle_isim.Parent = uyewp;
            uyeekle_cinsiyet.Parent = uyewp;
            uyeekle_soyad.Parent = uyewp;
            btnKAYIT.Parent = uyewp;
            btnRESET.Parent = uyewp;

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KETUKRB\\MSSQLSERVER03;Initial Catalog=DYGO_GYM;User ID=sa;Password=1");

        private void uyeekle_Load(object sender, EventArgs e)
        {

        }

        private void btnKAYIT_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into UyeEkle (ad,soyad,cinsiyet,dogumgunu,telefon,eposta,uyeliksuresi,uyelikturu,adres,kayittarih) VALUES (@ad,@soyad,@cinsiyet,@dogumgunu,@telefon,@eposta,@uyeliksuresi,@ueylikturu,@adres,@kayittarih)",con);
            cmd.Parameters.AddWithValue("@ad", txtAD.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSOYAD.Text);
            if(radioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@cinsiyet", radioButton1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@cinsiyet", radioButton2.Text);
            }
            cmd.Parameters.AddWithValue("@dogumgunu", dateTimePickerDG.Value);
            cmd.Parameters.AddWithValue("@telefon", txtTELEFON.Text);
            cmd.Parameters.AddWithValue("@eposta",txtPOSTA.Text);
            cmd.Parameters.AddWithValue("@uyeliksuresi", comboBoxUYELIKSURE.SelectedItem);
            cmd.Parameters.AddWithValue("@ueylikturu", comboBoxUYELIKTURU.SelectedItem);
            cmd.Parameters.AddWithValue("@adres", txtADRES.Text);
            cmd.Parameters.AddWithValue("@kayittarih", dateTimePickerKAYIT.Value);
            con.Open();
            int donenDeger= cmd.ExecuteNonQuery();
            con.Close();

            if(donenDeger==2)
            {
                MessageBox.Show("kayıt başaraılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("kayıt sırasında hata oluştu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKAYIT_Click(object sender, EventArgs e, SqlConnection connection)
        {
            
            
            








        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtAD.Clear();
            txtSOYAD.Clear();
            
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtTELEFON.Clear();
            txtPOSTA.Clear();

            comboBoxUYELIKSURE.ResetText();
            comboBoxUYELIKTURU.ResetText();
            txtADRES.Clear();

            dateTimePickerDG.Value= DateTime.Now;
            dateTimePickerKAYIT.Value= DateTime.Now;
        }
    }
}
