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
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();

            flowLayoutPanel1.Parent = pictureBox1;
            button1.Parent = flowLayoutPanel1;
        }
        lobi dogu = new lobi();
        private void girisekrani_Load(object sender, EventArgs e)
        {
           flowLayoutPanel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar= false;
                checkBox1.Text = "Göster";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "dogu" && textBox2.Text == "123") 
            {
                this.Hide();
                dogu.Show();


            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA PAROLA HATALI!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //this.Hide();
            //dogu.Show();

        }

        private void girisekrani_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
