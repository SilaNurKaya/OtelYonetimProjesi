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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.hosgeldinizLbl = new System.Windows.Forms.Label();
            this.otelAdıLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hosgeldinizLbl
            // 
            this.hosgeldinizLbl.AutoSize = true;
            this.hosgeldinizLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hosgeldinizLbl.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinizLbl.Location = new System.Drawing.Point(321, 246);
            this.hosgeldinizLbl.Name = "hosgeldinizLbl";
            this.hosgeldinizLbl.Size = new System.Drawing.Size(560, 108);
            this.hosgeldinizLbl.TabIndex = 0;
            this.hosgeldinizLbl.Text = "Hoş Geldiniz!";
            // 
            // otelAdıLbl
            // 
            this.otelAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otelAdıLbl.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otelAdıLbl.ForeColor = System.Drawing.Color.MistyRose;
            this.otelAdıLbl.Location = new System.Drawing.Point(224, 26);
            this.otelAdıLbl.Name = "otelAdıLbl";
            this.otelAdıLbl.Size = new System.Drawing.Size(748, 220);
            this.otelAdıLbl.TabIndex = 1;
            this.otelAdıLbl.Text = "KOMOREBI VISTA HOTEL";
            this.otelAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otelAdıLbl.Click += new System.EventHandler(this.otelAdıLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "İşlem yapmak için giriş sayfasına gidiniz.";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otelAdıLbl);
            this.Controls.Add(this.hosgeldinizLbl);
            this.Name = "AnaSayfa";
            this.Size = new System.Drawing.Size(1200, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hosgeldinizLbl;
        private System.Windows.Forms.Label otelAdıLbl;
        private System.Windows.Forms.Label label1;
    }
}
