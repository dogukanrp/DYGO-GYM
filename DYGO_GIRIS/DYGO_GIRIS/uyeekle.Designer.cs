using System;
using System.Windows.Forms;

namespace DYGO_GIRIS
{
    partial class uyeekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeekle));
            this.uyewp = new System.Windows.Forms.PictureBox();
            this.uyeekle_isim = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.uyeekle_soyad = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.uyeekle_cinsiyet = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDG = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPOSTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtADRES = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKAYIT = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.dateTimePickerKAYIT = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUYELIKTURU = new System.Windows.Forms.ComboBox();
            this.comboBoxUYELIKSURE = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTELEFON = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uyewp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uyewp
            // 
            this.uyewp.Image = ((System.Drawing.Image)(resources.GetObject("uyewp.Image")));
            this.uyewp.Location = new System.Drawing.Point(-4, -2);
            this.uyewp.Name = "uyewp";
            this.uyewp.Size = new System.Drawing.Size(1115, 688);
            this.uyewp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uyewp.TabIndex = 0;
            this.uyewp.TabStop = false;
            // 
            // uyeekle_isim
            // 
            this.uyeekle_isim.BackColor = System.Drawing.Color.Black;
            this.uyeekle_isim.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeekle_isim.ForeColor = System.Drawing.Color.White;
            this.uyeekle_isim.Image = ((System.Drawing.Image)(resources.GetObject("uyeekle_isim.Image")));
            this.uyeekle_isim.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uyeekle_isim.Location = new System.Drawing.Point(47, 143);
            this.uyeekle_isim.Name = "uyeekle_isim";
            this.uyeekle_isim.Size = new System.Drawing.Size(172, 56);
            this.uyeekle_isim.TabIndex = 1;
            this.uyeekle_isim.Text = "İSİM ";
            this.uyeekle_isim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAD
            // 
            this.txtAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAD.Location = new System.Drawing.Point(246, 153);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(252, 34);
            this.txtAD.TabIndex = 2;
            // 
            // uyeekle_soyad
            // 
            this.uyeekle_soyad.BackColor = System.Drawing.Color.Black;
            this.uyeekle_soyad.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeekle_soyad.ForeColor = System.Drawing.Color.White;
            this.uyeekle_soyad.Image = ((System.Drawing.Image)(resources.GetObject("uyeekle_soyad.Image")));
            this.uyeekle_soyad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeekle_soyad.Location = new System.Drawing.Point(43, 219);
            this.uyeekle_soyad.Name = "uyeekle_soyad";
            this.uyeekle_soyad.Size = new System.Drawing.Size(176, 66);
            this.uyeekle_soyad.TabIndex = 3;
            this.uyeekle_soyad.Text = "SOY İSİM";
            this.uyeekle_soyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSOYAD.Location = new System.Drawing.Point(246, 235);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(252, 34);
            this.txtSOYAD.TabIndex = 4;
            // 
            // uyeekle_cinsiyet
            // 
            this.uyeekle_cinsiyet.BackColor = System.Drawing.Color.Black;
            this.uyeekle_cinsiyet.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeekle_cinsiyet.ForeColor = System.Drawing.Color.White;
            this.uyeekle_cinsiyet.Image = ((System.Drawing.Image)(resources.GetObject("uyeekle_cinsiyet.Image")));
            this.uyeekle_cinsiyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeekle_cinsiyet.Location = new System.Drawing.Point(47, 300);
            this.uyeekle_cinsiyet.Name = "uyeekle_cinsiyet";
            this.uyeekle_cinsiyet.Size = new System.Drawing.Size(172, 55);
            this.uyeekle_cinsiyet.TabIndex = 5;
            this.uyeekle_cinsiyet.Text = "CİNSİYET";
            this.uyeekle_cinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Black;
            this.radioButton1.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton1.Location = new System.Drawing.Point(246, 300);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 50);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "ERKEK";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Black;
            this.radioButton2.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Location = new System.Drawing.Point(381, 300);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 50);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "KADIN";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(31, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "DOĞUM TARİHİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerDG
            // 
            this.dateTimePickerDG.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDG.Location = new System.Drawing.Point(246, 386);
            this.dateTimePickerDG.Name = "dateTimePickerDG";
            this.dateTimePickerDG.Size = new System.Drawing.Size(197, 28);
            this.dateTimePickerDG.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(577, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-POSTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPOSTA
            // 
            this.txtPOSTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPOSTA.Location = new System.Drawing.Point(792, 153);
            this.txtPOSTA.Name = "txtPOSTA";
            this.txtPOSTA.Size = new System.Drawing.Size(286, 34);
            this.txtPOSTA.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(577, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "KAYIT TARİHİ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(577, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "ÜYELİK TÜRÜ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(568, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "ÜYELİK SÜRESİ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(577, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 56);
            this.label6.TabIndex = 15;
            this.label6.Text = "ADRES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtADRES
            // 
            this.txtADRES.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADRES.Location = new System.Drawing.Point(792, 450);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(286, 171);
            this.txtADRES.TabIndex = 16;
            this.txtADRES.Text = "";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(43, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 64);
            this.label7.TabIndex = 17;
            this.label7.Text = "TELEFON";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKAYIT
            // 
            this.btnKAYIT.BackColor = System.Drawing.Color.Transparent;
            this.btnKAYIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKAYIT.Image = ((System.Drawing.Image)(resources.GetObject("btnKAYIT.Image")));
            this.btnKAYIT.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKAYIT.Location = new System.Drawing.Point(187, 579);
            this.btnKAYIT.Name = "btnKAYIT";
            this.btnKAYIT.Size = new System.Drawing.Size(256, 75);
            this.btnKAYIT.TabIndex = 19;
            this.btnKAYIT.UseVisualStyleBackColor = false;
            this.btnKAYIT.Click += new System.EventHandler(this.btnKAYIT_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Transparent;
            this.btnRESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRESET.Image = ((System.Drawing.Image)(resources.GetObject("btnRESET.Image")));
            this.btnRESET.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRESET.Location = new System.Drawing.Point(495, 579);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(256, 75);
            this.btnRESET.TabIndex = 19;
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // dateTimePickerKAYIT
            // 
            this.dateTimePickerKAYIT.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerKAYIT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKAYIT.Location = new System.Drawing.Point(792, 231);
            this.dateTimePickerKAYIT.Name = "dateTimePickerKAYIT";
            this.dateTimePickerKAYIT.Size = new System.Drawing.Size(183, 28);
            this.dateTimePickerKAYIT.TabIndex = 21;
            // 
            // comboBoxUYELIKTURU
            // 
            this.comboBoxUYELIKTURU.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUYELIKTURU.FormattingEnabled = true;
            this.comboBoxUYELIKTURU.Items.AddRange(new object[] {
            "BRONZE ",
            "SILVER",
            "GOLD"});
            this.comboBoxUYELIKTURU.Location = new System.Drawing.Point(792, 309);
            this.comboBoxUYELIKTURU.Name = "comboBoxUYELIKTURU";
            this.comboBoxUYELIKTURU.Size = new System.Drawing.Size(183, 31);
            this.comboBoxUYELIKTURU.TabIndex = 22;
            // 
            // comboBoxUYELIKSURE
            // 
            this.comboBoxUYELIKSURE.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUYELIKSURE.FormattingEnabled = true;
            this.comboBoxUYELIKSURE.Items.AddRange(new object[] {
            "1  AY",
            "3 AY",
            "6 AY ",
            "1 YIL"});
            this.comboBoxUYELIKSURE.Location = new System.Drawing.Point(792, 384);
            this.comboBoxUYELIKSURE.Name = "comboBoxUYELIKSURE";
            this.comboBoxUYELIKSURE.Size = new System.Drawing.Size(183, 31);
            this.comboBoxUYELIKSURE.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtTELEFON
            // 
            this.txtTELEFON.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTELEFON.Location = new System.Drawing.Point(246, 462);
            this.txtTELEFON.Name = "txtTELEFON";
            this.txtTELEFON.Size = new System.Drawing.Size(252, 35);
            this.txtTELEFON.TabIndex = 25;
            // 
            // uyeekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 683);
            this.Controls.Add(this.txtTELEFON);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxUYELIKSURE);
            this.Controls.Add(this.comboBoxUYELIKTURU);
            this.Controls.Add(this.dateTimePickerKAYIT);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.btnKAYIT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtADRES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPOSTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.uyeekle_cinsiyet);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.uyeekle_soyad);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.uyeekle_isim);
            this.Controls.Add(this.uyewp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uyeekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYE EKLE";
            this.Load += new System.EventHandler(this.uyeekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyewp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.PictureBox uyewp;
        private System.Windows.Forms.Label uyeekle_isim;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label uyeekle_soyad;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label uyeekle_cinsiyet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPOSTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtADRES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKAYIT;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.DateTimePicker dateTimePickerKAYIT;
        private System.Windows.Forms.ComboBox comboBoxUYELIKTURU;
        private System.Windows.Forms.ComboBox comboBoxUYELIKSURE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox txtTELEFON;
    }
}