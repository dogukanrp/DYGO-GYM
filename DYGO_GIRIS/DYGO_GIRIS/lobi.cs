using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYGO_GIRIS
{
    public partial class lobi : Form
    {
        public lobi()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.07; 
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }


        }

        private void lobi_Load(object sender, EventArgs e)
        {

        }

        private void lobi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ekipmanlar aletler = new Ekipmanlar();
            aletler.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Uygulamadan Çıkış Yapmak İstedğiğnize Emin Misiniz?","ÇIKIŞ",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
                {

                //Application.Exit();
                timer1.Start();


            }
            else
            {
                MessageBox.Show("Tekrardan Hoşgeldiniz.","HOŞGELDİNİZ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void çALIŞANEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calisanekle calisanlars = new calisanekle();
            calisanlars.Show();
        }

        private void üYEEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uyeekle yeni = new uyeekle();
            yeni.Show();
        }

        private void üYEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeAra uyeler = new UyeAra();
            uyeler.Show();
        }

        private void üYESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSil sil = new UyeSil();
            sil.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Oturumu Sonlandırmak İstediğinize Emin Misiniz?","EMİN MİSİN?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {

                
                girisekrani ge = new girisekrani();
                ge.Show();
                this.Hide();


            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bakiye bk = new Bakiye();  
            bk.Show();
        }
    }
}
