namespace DYGO_GIRIS
{
    partial class UyeAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeAra));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnARA = new System.Windows.Forms.Button();
            this.pictureUYEARA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUYEARA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUYEARA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnARA
            // 
            this.btnARA.BackColor = System.Drawing.Color.Transparent;
            this.btnARA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnARA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnARA.ForeColor = System.Drawing.Color.Transparent;
            this.btnARA.Image = ((System.Drawing.Image)(resources.GetObject("btnARA.Image")));
            this.btnARA.Location = new System.Drawing.Point(427, 245);
            this.btnARA.Name = "btnARA";
            this.btnARA.Size = new System.Drawing.Size(228, 73);
            this.btnARA.TabIndex = 31;
            this.btnARA.UseVisualStyleBackColor = false;
            this.btnARA.Click += new System.EventHandler(this.btnARA_Click);
            // 
            // pictureUYEARA
            // 
            this.pictureUYEARA.Image = ((System.Drawing.Image)(resources.GetObject("pictureUYEARA.Image")));
            this.pictureUYEARA.Location = new System.Drawing.Point(-3, -1);
            this.pictureUYEARA.Name = "pictureUYEARA";
            this.pictureUYEARA.Size = new System.Drawing.Size(1108, 690);
            this.pictureUYEARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUYEARA.TabIndex = 32;
            this.pictureUYEARA.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "ÜYE İD";
            // 
            // txtUYEARA
            // 
            this.txtUYEARA.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUYEARA.Location = new System.Drawing.Point(147, 24);
            this.txtUYEARA.Name = "txtUYEARA";
            this.txtUYEARA.Size = new System.Drawing.Size(184, 31);
            this.txtUYEARA.TabIndex = 34;
            this.txtUYEARA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtUYEARA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(358, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 79);
            this.panel1.TabIndex = 35;
            // 
            // UyeAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnARA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureUYEARA);
            this.MaximizeBox = false;
            this.Name = "UyeAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeAra";
            this.Load += new System.EventHandler(this.UyeAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUYEARA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureUYEARA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUYEARA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnARA;
    }
}