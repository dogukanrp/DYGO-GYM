namespace DYGO_GIRIS
{
    partial class UyeSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeSil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUYEsil = new System.Windows.Forms.TextBox();
            this.UYEid = new System.Windows.Forms.Label();
            this.btnSİL = new System.Windows.Forms.Button();
            this.uyesilarkaplan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyesilarkaplan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtUYEsil);
            this.panel1.Controls.Add(this.UYEid);
            this.panel1.Location = new System.Drawing.Point(45, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 73);
            this.panel1.TabIndex = 36;
            // 
            // txtUYEsil
            // 
            this.txtUYEsil.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUYEsil.Location = new System.Drawing.Point(160, 20);
            this.txtUYEsil.Name = "txtUYEsil";
            this.txtUYEsil.Size = new System.Drawing.Size(184, 31);
            this.txtUYEsil.TabIndex = 34;
            this.txtUYEsil.TextChanged += new System.EventHandler(this.txtUYEsil_TextChanged);
            // 
            // UYEid
            // 
            this.UYEid.AutoSize = true;
            this.UYEid.BackColor = System.Drawing.Color.Black;
            this.UYEid.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UYEid.ForeColor = System.Drawing.Color.White;
            this.UYEid.Location = new System.Drawing.Point(15, 27);
            this.UYEid.Name = "UYEid";
            this.UYEid.Size = new System.Drawing.Size(90, 24);
            this.UYEid.TabIndex = 33;
            this.UYEid.Text = "ÜYE İD";
            this.UYEid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.Color.Transparent;
            this.btnSİL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSİL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSİL.ForeColor = System.Drawing.Color.Transparent;
            this.btnSİL.Image = ((System.Drawing.Image)(resources.GetObject("btnSİL.Image")));
            this.btnSİL.Location = new System.Drawing.Point(728, 150);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(228, 73);
            this.btnSİL.TabIndex = 37;
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // uyesilarkaplan
            // 
            this.uyesilarkaplan.Image = ((System.Drawing.Image)(resources.GetObject("uyesilarkaplan.Image")));
            this.uyesilarkaplan.Location = new System.Drawing.Point(-5, -3);
            this.uyesilarkaplan.Name = "uyesilarkaplan";
            this.uyesilarkaplan.Size = new System.Drawing.Size(1111, 692);
            this.uyesilarkaplan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uyesilarkaplan.TabIndex = 38;
            this.uyesilarkaplan.TabStop = false;
            // 
            // UyeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 683);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uyesilarkaplan);
            this.MaximizeBox = false;
            this.Name = "UyeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeSil";
            this.Load += new System.EventHandler(this.UyeSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyesilarkaplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUYEsil;
        private System.Windows.Forms.Label UYEid;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.PictureBox uyesilarkaplan;
    }
}