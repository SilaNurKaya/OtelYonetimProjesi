namespace odev2
{
    partial class AnaSayfa
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.hosgeldinizLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hosgeldinizLbl
            // 
            this.hosgeldinizLbl.AutoSize = true;
            this.hosgeldinizLbl.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinizLbl.Location = new System.Drawing.Point(310, 155);
            this.hosgeldinizLbl.Name = "hosgeldinizLbl";
            this.hosgeldinizLbl.Size = new System.Drawing.Size(560, 108);
            this.hosgeldinizLbl.TabIndex = 0;
            this.hosgeldinizLbl.Text = "Hoş Geldiniz!";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hosgeldinizLbl);
            this.Name = "AnaSayfa";
            this.Size = new System.Drawing.Size(1200, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hosgeldinizLbl;
    }
}
