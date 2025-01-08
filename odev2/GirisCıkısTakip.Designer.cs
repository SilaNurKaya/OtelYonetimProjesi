namespace odev2
{
    partial class GirisCıkısTakip
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
            this.girisCıkısTakibiGrpBox = new System.Windows.Forms.GroupBox();
            this.tarihAralıgıGrpBox = new System.Windows.Forms.GroupBox();
            this.baslangıcTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.bitisTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.baslangıcTarihiLbl = new System.Windows.Forms.Label();
            this.bitisTarihiLbl = new System.Windows.Forms.Label();
            this.filtrelemeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.girisCıkısYapmaGrpBox = new System.Windows.Forms.GroupBox();
            this.girisYapmaBtn = new System.Windows.Forms.Button();
            this.cıkısYapmaBtn = new System.Windows.Forms.Button();
            this.dinamikToplamKonukLbl = new System.Windows.Forms.Label();
            this.dinamikGenelBilgilerPnl = new System.Windows.Forms.Panel();
            this.girisYapaccakSayisiLbl = new System.Windows.Forms.Label();
            this.cıkısYapacakSayisiLbl = new System.Windows.Forms.Label();
            this.girisCıkısTakibiGrpBox.SuspendLayout();
            this.tarihAralıgıGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.girisCıkısYapmaGrpBox.SuspendLayout();
            this.dinamikGenelBilgilerPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisCıkısTakibiGrpBox
            // 
            this.girisCıkısTakibiGrpBox.Controls.Add(this.dinamikGenelBilgilerPnl);
            this.girisCıkısTakibiGrpBox.Controls.Add(this.girisCıkısYapmaGrpBox);
            this.girisCıkısTakibiGrpBox.Controls.Add(this.tarihAralıgıGrpBox);
            this.girisCıkısTakibiGrpBox.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisCıkısTakibiGrpBox.Location = new System.Drawing.Point(0, 0);
            this.girisCıkısTakibiGrpBox.Name = "girisCıkısTakibiGrpBox";
            this.girisCıkısTakibiGrpBox.Size = new System.Drawing.Size(1235, 700);
            this.girisCıkısTakibiGrpBox.TabIndex = 0;
            this.girisCıkısTakibiGrpBox.TabStop = false;
            this.girisCıkısTakibiGrpBox.Text = "Giriş - Çıkış Takibi";
            // 
            // tarihAralıgıGrpBox
            // 
            this.tarihAralıgıGrpBox.Controls.Add(this.filtrelemeBtn);
            this.tarihAralıgıGrpBox.Controls.Add(this.bitisTarihiLbl);
            this.tarihAralıgıGrpBox.Controls.Add(this.baslangıcTarihiLbl);
            this.tarihAralıgıGrpBox.Controls.Add(this.bitisTarihiDtp);
            this.tarihAralıgıGrpBox.Controls.Add(this.baslangıcTarihiDtp);
            this.tarihAralıgıGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihAralıgıGrpBox.Location = new System.Drawing.Point(42, 49);
            this.tarihAralıgıGrpBox.Name = "tarihAralıgıGrpBox";
            this.tarihAralıgıGrpBox.Size = new System.Drawing.Size(1148, 128);
            this.tarihAralıgıGrpBox.TabIndex = 0;
            this.tarihAralıgıGrpBox.TabStop = false;
            this.tarihAralıgıGrpBox.Text = "Tarih Aralığı";
            // 
            // baslangıcTarihiDtp
            // 
            this.baslangıcTarihiDtp.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangıcTarihiDtp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangıcTarihiDtp.Location = new System.Drawing.Point(23, 77);
            this.baslangıcTarihiDtp.Name = "baslangıcTarihiDtp";
            this.baslangıcTarihiDtp.Size = new System.Drawing.Size(360, 34);
            this.baslangıcTarihiDtp.TabIndex = 0;
            // 
            // bitisTarihiDtp
            // 
            this.bitisTarihiDtp.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarihiDtp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarihiDtp.Location = new System.Drawing.Point(485, 77);
            this.bitisTarihiDtp.Name = "bitisTarihiDtp";
            this.bitisTarihiDtp.Size = new System.Drawing.Size(360, 34);
            this.bitisTarihiDtp.TabIndex = 1;
            // 
            // baslangıcTarihiLbl
            // 
            this.baslangıcTarihiLbl.AutoSize = true;
            this.baslangıcTarihiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangıcTarihiLbl.Location = new System.Drawing.Point(18, 39);
            this.baslangıcTarihiLbl.Name = "baslangıcTarihiLbl";
            this.baslangıcTarihiLbl.Size = new System.Drawing.Size(179, 25);
            this.baslangıcTarihiLbl.TabIndex = 2;
            this.baslangıcTarihiLbl.Text = "Başlangıç Tarihi:";
            // 
            // bitisTarihiLbl
            // 
            this.bitisTarihiLbl.AutoSize = true;
            this.bitisTarihiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarihiLbl.Location = new System.Drawing.Point(480, 39);
            this.bitisTarihiLbl.Name = "bitisTarihiLbl";
            this.bitisTarihiLbl.Size = new System.Drawing.Size(127, 25);
            this.bitisTarihiLbl.TabIndex = 3;
            this.bitisTarihiLbl.Text = "Bitiş Tarihi:";
            // 
            // filtrelemeBtn
            // 
            this.filtrelemeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrelemeBtn.Location = new System.Drawing.Point(922, 74);
            this.filtrelemeBtn.Name = "filtrelemeBtn";
            this.filtrelemeBtn.Size = new System.Drawing.Size(151, 37);
            this.filtrelemeBtn.TabIndex = 4;
            this.filtrelemeBtn.Text = "Filtrele";
            this.filtrelemeBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // girisCıkısYapmaGrpBox
            // 
            this.girisCıkısYapmaGrpBox.Controls.Add(this.cıkısYapmaBtn);
            this.girisCıkısYapmaGrpBox.Controls.Add(this.girisYapmaBtn);
            this.girisCıkısYapmaGrpBox.Controls.Add(this.dataGridView1);
            this.girisCıkısYapmaGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisCıkısYapmaGrpBox.Location = new System.Drawing.Point(42, 192);
            this.girisCıkısYapmaGrpBox.Name = "girisCıkısYapmaGrpBox";
            this.girisCıkısYapmaGrpBox.Size = new System.Drawing.Size(1148, 368);
            this.girisCıkısYapmaGrpBox.TabIndex = 2;
            this.girisCıkısYapmaGrpBox.TabStop = false;
            this.girisCıkısYapmaGrpBox.Text = "Giriş - Çıkış Yap";
            // 
            // girisYapmaBtn
            // 
            this.girisYapmaBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapmaBtn.Location = new System.Drawing.Point(922, 67);
            this.girisYapmaBtn.Name = "girisYapmaBtn";
            this.girisYapmaBtn.Size = new System.Drawing.Size(151, 73);
            this.girisYapmaBtn.TabIndex = 2;
            this.girisYapmaBtn.Text = "Giriş Yap";
            this.girisYapmaBtn.UseVisualStyleBackColor = true;
            // 
            // cıkısYapmaBtn
            // 
            this.cıkısYapmaBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısYapmaBtn.Location = new System.Drawing.Point(922, 236);
            this.cıkısYapmaBtn.Name = "cıkısYapmaBtn";
            this.cıkısYapmaBtn.Size = new System.Drawing.Size(151, 73);
            this.cıkısYapmaBtn.TabIndex = 3;
            this.cıkısYapmaBtn.Text = "Çıkış Yap";
            this.cıkısYapmaBtn.UseVisualStyleBackColor = true;
            // 
            // dinamikToplamKonukLbl
            // 
            this.dinamikToplamKonukLbl.AutoSize = true;
            this.dinamikToplamKonukLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dinamikToplamKonukLbl.Location = new System.Drawing.Point(43, 42);
            this.dinamikToplamKonukLbl.Name = "dinamikToplamKonukLbl";
            this.dinamikToplamKonukLbl.Size = new System.Drawing.Size(238, 25);
            this.dinamikToplamKonukLbl.TabIndex = 3;
            this.dinamikToplamKonukLbl.Text = "Toplam Konaklayan: 0";
            // 
            // dinamikGenelBilgilerPnl
            // 
            this.dinamikGenelBilgilerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dinamikGenelBilgilerPnl.Controls.Add(this.cıkısYapacakSayisiLbl);
            this.dinamikGenelBilgilerPnl.Controls.Add(this.girisYapaccakSayisiLbl);
            this.dinamikGenelBilgilerPnl.Controls.Add(this.dinamikToplamKonukLbl);
            this.dinamikGenelBilgilerPnl.Location = new System.Drawing.Point(42, 578);
            this.dinamikGenelBilgilerPnl.Name = "dinamikGenelBilgilerPnl";
            this.dinamikGenelBilgilerPnl.Size = new System.Drawing.Size(1148, 104);
            this.dinamikGenelBilgilerPnl.TabIndex = 3;
            // 
            // girisYapaccakSayisiLbl
            // 
            this.girisYapaccakSayisiLbl.AutoSize = true;
            this.girisYapaccakSayisiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapaccakSayisiLbl.Location = new System.Drawing.Point(489, 42);
            this.girisYapaccakSayisiLbl.Name = "girisYapaccakSayisiLbl";
            this.girisYapaccakSayisiLbl.Size = new System.Drawing.Size(201, 25);
            this.girisYapaccakSayisiLbl.TabIndex = 4;
            this.girisYapaccakSayisiLbl.Text = "Giriş Yapacaklar: 0";
            // 
            // cıkısYapacakSayisiLbl
            // 
            this.cıkısYapacakSayisiLbl.AutoSize = true;
            this.cıkısYapacakSayisiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısYapacakSayisiLbl.Location = new System.Drawing.Point(891, 42);
            this.cıkısYapacakSayisiLbl.Name = "cıkısYapacakSayisiLbl";
            this.cıkısYapacakSayisiLbl.Size = new System.Drawing.Size(204, 25);
            this.cıkısYapacakSayisiLbl.TabIndex = 5;
            this.cıkısYapacakSayisiLbl.Text = "Çıkış Yapacaklar: 0";
            // 
            // GirisCıkısTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.girisCıkısTakibiGrpBox);
            this.Name = "GirisCıkısTakip";
            this.Size = new System.Drawing.Size(1250, 700);
            this.girisCıkısTakibiGrpBox.ResumeLayout(false);
            this.tarihAralıgıGrpBox.ResumeLayout(false);
            this.tarihAralıgıGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.girisCıkısYapmaGrpBox.ResumeLayout(false);
            this.dinamikGenelBilgilerPnl.ResumeLayout(false);
            this.dinamikGenelBilgilerPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox girisCıkısTakibiGrpBox;
        private System.Windows.Forms.GroupBox tarihAralıgıGrpBox;
        private System.Windows.Forms.DateTimePicker baslangıcTarihiDtp;
        private System.Windows.Forms.DateTimePicker bitisTarihiDtp;
        private System.Windows.Forms.Label baslangıcTarihiLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button filtrelemeBtn;
        private System.Windows.Forms.Label bitisTarihiLbl;
        private System.Windows.Forms.GroupBox girisCıkısYapmaGrpBox;
        private System.Windows.Forms.Button cıkısYapmaBtn;
        private System.Windows.Forms.Button girisYapmaBtn;
        private System.Windows.Forms.Label dinamikToplamKonukLbl;
        private System.Windows.Forms.Panel dinamikGenelBilgilerPnl;
        private System.Windows.Forms.Label girisYapaccakSayisiLbl;
        private System.Windows.Forms.Label cıkısYapacakSayisiLbl;
    }
}
