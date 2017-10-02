namespace VeriMadenciligi_Goruntu
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.R_Mod = new System.Windows.Forms.Label();
            this.R_Medyan = new System.Windows.Forms.Label();
            this.R_Ortalama = new System.Windows.Forms.Label();
            this.R_Varyans = new System.Windows.Forms.Label();
            this.R_Ssapma = new System.Windows.Forms.Label();
            this.R_Carpiklik = new System.Windows.Forms.Label();
            this.R_Basiklik = new System.Windows.Forms.Label();
            this.R_DKatsayisi = new System.Windows.Forms.Label();
            this.R_Min = new System.Windows.Forms.Label();
            this.R_Max = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Max = new System.Windows.Forms.Label();
            this.B_Min = new System.Windows.Forms.Label();
            this.B_DKatsayisi = new System.Windows.Forms.Label();
            this.B_Basiklik = new System.Windows.Forms.Label();
            this.B_Carpiklik = new System.Windows.Forms.Label();
            this.B_Ssapma = new System.Windows.Forms.Label();
            this.B_Varyans = new System.Windows.Forms.Label();
            this.B_Ortalama = new System.Windows.Forms.Label();
            this.B_Medyan = new System.Windows.Forms.Label();
            this.B_Mod = new System.Windows.Forms.Label();
            this.G_Max = new System.Windows.Forms.Label();
            this.G_Min = new System.Windows.Forms.Label();
            this.G_DKatsayisi = new System.Windows.Forms.Label();
            this.G_Basiklik = new System.Windows.Forms.Label();
            this.G_Carpiklik = new System.Windows.Forms.Label();
            this.G_Ssapma = new System.Windows.Forms.Label();
            this.G_Varyans = new System.Windows.Forms.Label();
            this.G_Ortalama = new System.Windows.Forms.Label();
            this.G_Medyan = new System.Windows.Forms.Label();
            this.G_Mod = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resim Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medyan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ortalama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "S. Sapma :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Çarpıklık :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Basıklık :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Değişim Katsayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Min :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Max :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Varyans :";
            // 
            // R_Mod
            // 
            this.R_Mod.AutoSize = true;
            this.R_Mod.Location = new System.Drawing.Point(122, 66);
            this.R_Mod.Name = "R_Mod";
            this.R_Mod.Size = new System.Drawing.Size(19, 13);
            this.R_Mod.TabIndex = 13;
            this.R_Mod.Text = "....";
            // 
            // R_Medyan
            // 
            this.R_Medyan.AutoSize = true;
            this.R_Medyan.Location = new System.Drawing.Point(121, 94);
            this.R_Medyan.Name = "R_Medyan";
            this.R_Medyan.Size = new System.Drawing.Size(19, 13);
            this.R_Medyan.TabIndex = 14;
            this.R_Medyan.Text = "....";
            // 
            // R_Ortalama
            // 
            this.R_Ortalama.AutoSize = true;
            this.R_Ortalama.Location = new System.Drawing.Point(122, 120);
            this.R_Ortalama.Name = "R_Ortalama";
            this.R_Ortalama.Size = new System.Drawing.Size(19, 13);
            this.R_Ortalama.TabIndex = 15;
            this.R_Ortalama.Text = "....";
            // 
            // R_Varyans
            // 
            this.R_Varyans.AutoSize = true;
            this.R_Varyans.Location = new System.Drawing.Point(122, 147);
            this.R_Varyans.Name = "R_Varyans";
            this.R_Varyans.Size = new System.Drawing.Size(19, 13);
            this.R_Varyans.TabIndex = 16;
            this.R_Varyans.Text = "....";
            // 
            // R_Ssapma
            // 
            this.R_Ssapma.AutoSize = true;
            this.R_Ssapma.Location = new System.Drawing.Point(122, 171);
            this.R_Ssapma.Name = "R_Ssapma";
            this.R_Ssapma.Size = new System.Drawing.Size(19, 13);
            this.R_Ssapma.TabIndex = 17;
            this.R_Ssapma.Text = "....";
            // 
            // R_Carpiklik
            // 
            this.R_Carpiklik.AutoSize = true;
            this.R_Carpiklik.Location = new System.Drawing.Point(122, 200);
            this.R_Carpiklik.Name = "R_Carpiklik";
            this.R_Carpiklik.Size = new System.Drawing.Size(19, 13);
            this.R_Carpiklik.TabIndex = 18;
            this.R_Carpiklik.Text = "....";
            // 
            // R_Basiklik
            // 
            this.R_Basiklik.AutoSize = true;
            this.R_Basiklik.Location = new System.Drawing.Point(122, 225);
            this.R_Basiklik.Name = "R_Basiklik";
            this.R_Basiklik.Size = new System.Drawing.Size(19, 13);
            this.R_Basiklik.TabIndex = 19;
            this.R_Basiklik.Text = "....";
            // 
            // R_DKatsayisi
            // 
            this.R_DKatsayisi.AutoSize = true;
            this.R_DKatsayisi.Location = new System.Drawing.Point(122, 255);
            this.R_DKatsayisi.Name = "R_DKatsayisi";
            this.R_DKatsayisi.Size = new System.Drawing.Size(19, 13);
            this.R_DKatsayisi.TabIndex = 20;
            this.R_DKatsayisi.Text = "....";
            // 
            // R_Min
            // 
            this.R_Min.AutoSize = true;
            this.R_Min.Location = new System.Drawing.Point(122, 282);
            this.R_Min.Name = "R_Min";
            this.R_Min.Size = new System.Drawing.Size(19, 13);
            this.R_Min.TabIndex = 21;
            this.R_Min.Text = "....";
            // 
            // R_Max
            // 
            this.R_Max.AutoSize = true;
            this.R_Max.Location = new System.Drawing.Point(122, 309);
            this.R_Max.Name = "R_Max";
            this.R_Max.Size = new System.Drawing.Size(19, 13);
            this.R_Max.TabIndex = 22;
            this.R_Max.Text = "....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Max);
            this.groupBox1.Controls.Add(this.B_Min);
            this.groupBox1.Controls.Add(this.B_DKatsayisi);
            this.groupBox1.Controls.Add(this.B_Basiklik);
            this.groupBox1.Controls.Add(this.B_Carpiklik);
            this.groupBox1.Controls.Add(this.B_Ssapma);
            this.groupBox1.Controls.Add(this.B_Varyans);
            this.groupBox1.Controls.Add(this.B_Ortalama);
            this.groupBox1.Controls.Add(this.B_Medyan);
            this.groupBox1.Controls.Add(this.B_Mod);
            this.groupBox1.Controls.Add(this.G_Max);
            this.groupBox1.Controls.Add(this.G_Min);
            this.groupBox1.Controls.Add(this.G_DKatsayisi);
            this.groupBox1.Controls.Add(this.G_Basiklik);
            this.groupBox1.Controls.Add(this.G_Carpiklik);
            this.groupBox1.Controls.Add(this.G_Ssapma);
            this.groupBox1.Controls.Add(this.G_Varyans);
            this.groupBox1.Controls.Add(this.G_Ortalama);
            this.groupBox1.Controls.Add(this.G_Medyan);
            this.groupBox1.Controls.Add(this.G_Mod);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.R_Max);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.R_Min);
            this.groupBox1.Controls.Add(this.R_DKatsayisi);
            this.groupBox1.Controls.Add(this.R_Basiklik);
            this.groupBox1.Controls.Add(this.R_Carpiklik);
            this.groupBox1.Controls.Add(this.R_Ssapma);
            this.groupBox1.Controls.Add(this.R_Varyans);
            this.groupBox1.Controls.Add(this.R_Ortalama);
            this.groupBox1.Controls.Add(this.R_Medyan);
            this.groupBox1.Controls.Add(this.R_Mod);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(396, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 336);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatislikler";
            // 
            // B_Max
            // 
            this.B_Max.AutoSize = true;
            this.B_Max.Location = new System.Drawing.Point(361, 309);
            this.B_Max.Name = "B_Max";
            this.B_Max.Size = new System.Drawing.Size(19, 13);
            this.B_Max.TabIndex = 45;
            this.B_Max.Text = "....";
            // 
            // B_Min
            // 
            this.B_Min.AutoSize = true;
            this.B_Min.Location = new System.Drawing.Point(361, 282);
            this.B_Min.Name = "B_Min";
            this.B_Min.Size = new System.Drawing.Size(19, 13);
            this.B_Min.TabIndex = 44;
            this.B_Min.Text = "....";
            // 
            // B_DKatsayisi
            // 
            this.B_DKatsayisi.AutoSize = true;
            this.B_DKatsayisi.Location = new System.Drawing.Point(361, 255);
            this.B_DKatsayisi.Name = "B_DKatsayisi";
            this.B_DKatsayisi.Size = new System.Drawing.Size(19, 13);
            this.B_DKatsayisi.TabIndex = 43;
            this.B_DKatsayisi.Text = "....";
            // 
            // B_Basiklik
            // 
            this.B_Basiklik.AutoSize = true;
            this.B_Basiklik.Location = new System.Drawing.Point(361, 225);
            this.B_Basiklik.Name = "B_Basiklik";
            this.B_Basiklik.Size = new System.Drawing.Size(19, 13);
            this.B_Basiklik.TabIndex = 42;
            this.B_Basiklik.Text = "....";
            // 
            // B_Carpiklik
            // 
            this.B_Carpiklik.AutoSize = true;
            this.B_Carpiklik.Location = new System.Drawing.Point(361, 200);
            this.B_Carpiklik.Name = "B_Carpiklik";
            this.B_Carpiklik.Size = new System.Drawing.Size(19, 13);
            this.B_Carpiklik.TabIndex = 41;
            this.B_Carpiklik.Text = "....";
            // 
            // B_Ssapma
            // 
            this.B_Ssapma.AutoSize = true;
            this.B_Ssapma.Location = new System.Drawing.Point(361, 171);
            this.B_Ssapma.Name = "B_Ssapma";
            this.B_Ssapma.Size = new System.Drawing.Size(19, 13);
            this.B_Ssapma.TabIndex = 40;
            this.B_Ssapma.Text = "....";
            // 
            // B_Varyans
            // 
            this.B_Varyans.AutoSize = true;
            this.B_Varyans.Location = new System.Drawing.Point(361, 147);
            this.B_Varyans.Name = "B_Varyans";
            this.B_Varyans.Size = new System.Drawing.Size(19, 13);
            this.B_Varyans.TabIndex = 39;
            this.B_Varyans.Text = "....";
            // 
            // B_Ortalama
            // 
            this.B_Ortalama.AutoSize = true;
            this.B_Ortalama.Location = new System.Drawing.Point(361, 120);
            this.B_Ortalama.Name = "B_Ortalama";
            this.B_Ortalama.Size = new System.Drawing.Size(19, 13);
            this.B_Ortalama.TabIndex = 38;
            this.B_Ortalama.Text = "....";
            // 
            // B_Medyan
            // 
            this.B_Medyan.AutoSize = true;
            this.B_Medyan.Location = new System.Drawing.Point(360, 94);
            this.B_Medyan.Name = "B_Medyan";
            this.B_Medyan.Size = new System.Drawing.Size(19, 13);
            this.B_Medyan.TabIndex = 37;
            this.B_Medyan.Text = "....";
            // 
            // B_Mod
            // 
            this.B_Mod.AutoSize = true;
            this.B_Mod.Location = new System.Drawing.Point(361, 66);
            this.B_Mod.Name = "B_Mod";
            this.B_Mod.Size = new System.Drawing.Size(19, 13);
            this.B_Mod.TabIndex = 36;
            this.B_Mod.Text = "....";
            // 
            // G_Max
            // 
            this.G_Max.AutoSize = true;
            this.G_Max.Location = new System.Drawing.Point(236, 309);
            this.G_Max.Name = "G_Max";
            this.G_Max.Size = new System.Drawing.Size(19, 13);
            this.G_Max.TabIndex = 35;
            this.G_Max.Text = "....";
            // 
            // G_Min
            // 
            this.G_Min.AutoSize = true;
            this.G_Min.Location = new System.Drawing.Point(236, 282);
            this.G_Min.Name = "G_Min";
            this.G_Min.Size = new System.Drawing.Size(19, 13);
            this.G_Min.TabIndex = 34;
            this.G_Min.Text = "....";
            // 
            // G_DKatsayisi
            // 
            this.G_DKatsayisi.AutoSize = true;
            this.G_DKatsayisi.Location = new System.Drawing.Point(236, 255);
            this.G_DKatsayisi.Name = "G_DKatsayisi";
            this.G_DKatsayisi.Size = new System.Drawing.Size(19, 13);
            this.G_DKatsayisi.TabIndex = 33;
            this.G_DKatsayisi.Text = "....";
            // 
            // G_Basiklik
            // 
            this.G_Basiklik.AutoSize = true;
            this.G_Basiklik.Location = new System.Drawing.Point(236, 225);
            this.G_Basiklik.Name = "G_Basiklik";
            this.G_Basiklik.Size = new System.Drawing.Size(19, 13);
            this.G_Basiklik.TabIndex = 32;
            this.G_Basiklik.Text = "....";
            // 
            // G_Carpiklik
            // 
            this.G_Carpiklik.AutoSize = true;
            this.G_Carpiklik.Location = new System.Drawing.Point(236, 200);
            this.G_Carpiklik.Name = "G_Carpiklik";
            this.G_Carpiklik.Size = new System.Drawing.Size(19, 13);
            this.G_Carpiklik.TabIndex = 31;
            this.G_Carpiklik.Text = "....";
            // 
            // G_Ssapma
            // 
            this.G_Ssapma.AutoSize = true;
            this.G_Ssapma.Location = new System.Drawing.Point(236, 171);
            this.G_Ssapma.Name = "G_Ssapma";
            this.G_Ssapma.Size = new System.Drawing.Size(19, 13);
            this.G_Ssapma.TabIndex = 30;
            this.G_Ssapma.Text = "....";
            // 
            // G_Varyans
            // 
            this.G_Varyans.AutoSize = true;
            this.G_Varyans.Location = new System.Drawing.Point(236, 147);
            this.G_Varyans.Name = "G_Varyans";
            this.G_Varyans.Size = new System.Drawing.Size(19, 13);
            this.G_Varyans.TabIndex = 29;
            this.G_Varyans.Text = "....";
            // 
            // G_Ortalama
            // 
            this.G_Ortalama.AutoSize = true;
            this.G_Ortalama.Location = new System.Drawing.Point(236, 120);
            this.G_Ortalama.Name = "G_Ortalama";
            this.G_Ortalama.Size = new System.Drawing.Size(19, 13);
            this.G_Ortalama.TabIndex = 28;
            this.G_Ortalama.Text = "....";
            // 
            // G_Medyan
            // 
            this.G_Medyan.AutoSize = true;
            this.G_Medyan.Location = new System.Drawing.Point(235, 94);
            this.G_Medyan.Name = "G_Medyan";
            this.G_Medyan.Size = new System.Drawing.Size(19, 13);
            this.G_Medyan.TabIndex = 27;
            this.G_Medyan.Text = "....";
            // 
            // G_Mod
            // 
            this.G_Mod.AutoSize = true;
            this.G_Mod.Location = new System.Drawing.Point(236, 66);
            this.G_Mod.Name = "G_Mod";
            this.G_Mod.Size = new System.Drawing.Size(19, 13);
            this.G_Mod.TabIndex = 26;
            this.G_Mod.Text = "....";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "G";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme - Veri Madencilği";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label R_Mod;
        private System.Windows.Forms.Label R_Medyan;
        private System.Windows.Forms.Label R_Ortalama;
        private System.Windows.Forms.Label R_Varyans;
        private System.Windows.Forms.Label R_Ssapma;
        private System.Windows.Forms.Label R_Carpiklik;
        private System.Windows.Forms.Label R_Basiklik;
        private System.Windows.Forms.Label R_DKatsayisi;
        private System.Windows.Forms.Label R_Min;
        private System.Windows.Forms.Label R_Max;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label B_Max;
        private System.Windows.Forms.Label B_Min;
        private System.Windows.Forms.Label B_DKatsayisi;
        private System.Windows.Forms.Label B_Basiklik;
        private System.Windows.Forms.Label B_Carpiklik;
        private System.Windows.Forms.Label B_Ssapma;
        private System.Windows.Forms.Label B_Varyans;
        private System.Windows.Forms.Label B_Ortalama;
        private System.Windows.Forms.Label B_Medyan;
        private System.Windows.Forms.Label B_Mod;
        private System.Windows.Forms.Label G_Max;
        private System.Windows.Forms.Label G_Min;
        private System.Windows.Forms.Label G_DKatsayisi;
        private System.Windows.Forms.Label G_Basiklik;
        private System.Windows.Forms.Label G_Carpiklik;
        private System.Windows.Forms.Label G_Ssapma;
        private System.Windows.Forms.Label G_Varyans;
        private System.Windows.Forms.Label G_Ortalama;
        private System.Windows.Forms.Label G_Medyan;
        private System.Windows.Forms.Label G_Mod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

