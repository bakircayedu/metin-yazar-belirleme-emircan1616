
namespace VeriYapilariProjeOdev
{
    partial class Form1
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnHeapAktar = new System.Windows.Forms.Button();
            this.btnAgacaTasi = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(86, 22);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(223, 27);
            this.btnMetinYukle.TabIndex = 2;
            this.btnMetinYukle.Text = "Metin Yukle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(86, 189);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(223, 29);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Metni Stack\'e Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnHeapAktar
            // 
            this.btnHeapAktar.Location = new System.Drawing.Point(437, 22);
            this.btnHeapAktar.Name = "btnHeapAktar";
            this.btnHeapAktar.Size = new System.Drawing.Size(223, 27);
            this.btnHeapAktar.TabIndex = 4;
            this.btnHeapAktar.Text = "heap\'e aktar";
            this.btnHeapAktar.UseVisualStyleBackColor = true;
            this.btnHeapAktar.Click += new System.EventHandler(this.btnHeapAktar_Click);
            // 
            // btnAgacaTasi
            // 
            this.btnAgacaTasi.Location = new System.Drawing.Point(444, 187);
            this.btnAgacaTasi.Name = "btnAgacaTasi";
            this.btnAgacaTasi.Size = new System.Drawing.Size(216, 31);
            this.btnAgacaTasi.TabIndex = 5;
            this.btnAgacaTasi.Text = "Ağaca Taşı";
            this.btnAgacaTasi.UseVisualStyleBackColor = true;
            this.btnAgacaTasi.Click += new System.EventHandler(this.btnAgacaTasi_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(86, 55);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(223, 82);
            this.txtMetin.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 82);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 392);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.btnAgacaTasi);
            this.Controls.Add(this.btnHeapAktar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnHeapAktar;
        private System.Windows.Forms.Button btnAgacaTasi;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox textBox1;
    }
}

