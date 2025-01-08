namespace odev2
{
    partial class OdaSecenekleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaSecenekleri));
            this.odaBilgileriGrpBox = new System.Windows.Forms.GroupBox();
            this.odaIslemleriGrpBox = new System.Windows.Forms.GroupBox();
            this.odaNosuLbl = new System.Windows.Forms.Label();
            this.odaTipiLbl = new System.Windows.Forms.Label();
            this.odaDurumuLbl = new System.Windows.Forms.Label();
            this.odaNosuTxt = new System.Windows.Forms.TextBox();
            this.odaTipiTxt = new System.Windows.Forms.TextBox();
            this.odaDurumuCmbBox = new System.Windows.Forms.ComboBox();
            this.odaEkleBtn = new System.Windows.Forms.Button();
            this.odaDuzenleBtn = new System.Windows.Forms.Button();
            this.odaSilmeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaListeleBtn = new System.Windows.Forms.Button();
            this.odaSilmeGrpBox = new System.Windows.Forms.GroupBox();
            this.odaSilmeOdaNoLbl = new System.Windows.Forms.Label();
            this.odaSilmeOdaNoTxt = new System.Windows.Forms.TextBox();
            this.odaAramaKısmıTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.odaBilgileriGrpBox.SuspendLayout();
            this.odaIslemleriGrpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.odaSilmeGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // odaBilgileriGrpBox
            // 
            this.odaBilgileriGrpBox.Controls.Add(this.odaSilmeGrpBox);
            this.odaBilgileriGrpBox.Controls.Add(this.groupBox1);
            this.odaBilgileriGrpBox.Controls.Add(this.odaIslemleriGrpBox);
            this.odaBilgileriGrpBox.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaBilgileriGrpBox.Location = new System.Drawing.Point(0, 0);
            this.odaBilgileriGrpBox.Name = "odaBilgileriGrpBox";
            this.odaBilgileriGrpBox.Size = new System.Drawing.Size(1235, 700);
            this.odaBilgileriGrpBox.TabIndex = 0;
            this.odaBilgileriGrpBox.TabStop = false;
            this.odaBilgileriGrpBox.Text = "Oda Bilgileri";
            // 
            // odaIslemleriGrpBox
            // 
            this.odaIslemleriGrpBox.Controls.Add(this.odaDuzenleBtn);
            this.odaIslemleriGrpBox.Controls.Add(this.odaEkleBtn);
            this.odaIslemleriGrpBox.Controls.Add(this.odaDurumuCmbBox);
            this.odaIslemleriGrpBox.Controls.Add(this.odaTipiTxt);
            this.odaIslemleriGrpBox.Controls.Add(this.odaNosuTxt);
            this.odaIslemleriGrpBox.Controls.Add(this.odaDurumuLbl);
            this.odaIslemleriGrpBox.Controls.Add(this.odaTipiLbl);
            this.odaIslemleriGrpBox.Controls.Add(this.odaNosuLbl);
            this.odaIslemleriGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaIslemleriGrpBox.Location = new System.Drawing.Point(26, 49);
            this.odaIslemleriGrpBox.Name = "odaIslemleriGrpBox";
            this.odaIslemleriGrpBox.Size = new System.Drawing.Size(599, 307);
            this.odaIslemleriGrpBox.TabIndex = 0;
            this.odaIslemleriGrpBox.TabStop = false;
            this.odaIslemleriGrpBox.Text = "Oda İşlemleri";
            // 
            // odaNosuLbl
            // 
            this.odaNosuLbl.AutoSize = true;
            this.odaNosuLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaNosuLbl.Location = new System.Drawing.Point(6, 46);
            this.odaNosuLbl.Name = "odaNosuLbl";
            this.odaNosuLbl.Size = new System.Drawing.Size(98, 25);
            this.odaNosuLbl.TabIndex = 0;
            this.odaNosuLbl.Text = "Oda No:";
            // 
            // odaTipiLbl
            // 
            this.odaTipiLbl.AutoSize = true;
            this.odaTipiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaTipiLbl.Location = new System.Drawing.Point(6, 121);
            this.odaTipiLbl.Name = "odaTipiLbl";
            this.odaTipiLbl.Size = new System.Drawing.Size(107, 25);
            this.odaTipiLbl.TabIndex = 1;
            this.odaTipiLbl.Text = "Oda Tipi:";
            // 
            // odaDurumuLbl
            // 
            this.odaDurumuLbl.AutoSize = true;
            this.odaDurumuLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaDurumuLbl.Location = new System.Drawing.Point(6, 195);
            this.odaDurumuLbl.Name = "odaDurumuLbl";
            this.odaDurumuLbl.Size = new System.Drawing.Size(154, 25);
            this.odaDurumuLbl.TabIndex = 2;
            this.odaDurumuLbl.Text = "Oda Durumu:";
            // 
            // odaNosuTxt
            // 
            this.odaNosuTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaNosuTxt.Location = new System.Drawing.Point(11, 74);
            this.odaNosuTxt.Name = "odaNosuTxt";
            this.odaNosuTxt.Size = new System.Drawing.Size(303, 34);
            this.odaNosuTxt.TabIndex = 3;
            // 
            // odaTipiTxt
            // 
            this.odaTipiTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaTipiTxt.Location = new System.Drawing.Point(11, 149);
            this.odaTipiTxt.Name = "odaTipiTxt";
            this.odaTipiTxt.Size = new System.Drawing.Size(303, 34);
            this.odaTipiTxt.TabIndex = 4;
            // 
            // odaDurumuCmbBox
            // 
            this.odaDurumuCmbBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaDurumuCmbBox.FormattingEnabled = true;
            this.odaDurumuCmbBox.Location = new System.Drawing.Point(11, 229);
            this.odaDurumuCmbBox.Name = "odaDurumuCmbBox";
            this.odaDurumuCmbBox.Size = new System.Drawing.Size(303, 33);
            this.odaDurumuCmbBox.TabIndex = 5;
            this.odaDurumuCmbBox.SelectedIndexChanged += new System.EventHandler(this.odaDurumuCmbBox_SelectedIndexChanged);
            // 
            // odaEkleBtn
            // 
            this.odaEkleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaEkleBtn.Location = new System.Drawing.Point(389, 55);
            this.odaEkleBtn.Name = "odaEkleBtn";
            this.odaEkleBtn.Size = new System.Drawing.Size(120, 73);
            this.odaEkleBtn.TabIndex = 6;
            this.odaEkleBtn.Text = "Oda Ekle";
            this.odaEkleBtn.UseVisualStyleBackColor = true;
            // 
            // odaDuzenleBtn
            // 
            this.odaDuzenleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaDuzenleBtn.Location = new System.Drawing.Point(389, 173);
            this.odaDuzenleBtn.Name = "odaDuzenleBtn";
            this.odaDuzenleBtn.Size = new System.Drawing.Size(120, 73);
            this.odaDuzenleBtn.TabIndex = 7;
            this.odaDuzenleBtn.Text = "Oda Düzenle";
            this.odaDuzenleBtn.UseVisualStyleBackColor = true;
            // 
            // odaSilmeBtn
            // 
            this.odaSilmeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSilmeBtn.Location = new System.Drawing.Point(360, 173);
            this.odaSilmeBtn.Name = "odaSilmeBtn";
            this.odaSilmeBtn.Size = new System.Drawing.Size(120, 73);
            this.odaSilmeBtn.TabIndex = 8;
            this.odaSilmeBtn.Text = "Oda Sil";
            this.odaSilmeBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.odaAramaKısmıTxt);
            this.groupBox1.Controls.Add(this.odaListeleBtn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(26, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaListeleBtn
            // 
            this.odaListeleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaListeleBtn.Location = new System.Drawing.Point(39, 291);
            this.odaListeleBtn.Name = "odaListeleBtn";
            this.odaListeleBtn.Size = new System.Drawing.Size(1076, 42);
            this.odaListeleBtn.TabIndex = 1;
            this.odaListeleBtn.Text = "Oda Listele";
            this.odaListeleBtn.UseVisualStyleBackColor = true;
            // 
            // odaSilmeGrpBox
            // 
            this.odaSilmeGrpBox.Controls.Add(this.odaSilmeBtn);
            this.odaSilmeGrpBox.Controls.Add(this.odaSilmeOdaNoTxt);
            this.odaSilmeGrpBox.Controls.Add(this.odaSilmeOdaNoLbl);
            this.odaSilmeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSilmeGrpBox.Location = new System.Drawing.Point(661, 49);
            this.odaSilmeGrpBox.Name = "odaSilmeGrpBox";
            this.odaSilmeGrpBox.Size = new System.Drawing.Size(521, 307);
            this.odaSilmeGrpBox.TabIndex = 2;
            this.odaSilmeGrpBox.TabStop = false;
            this.odaSilmeGrpBox.Text = "Oda Sil";
            // 
            // odaSilmeOdaNoLbl
            // 
            this.odaSilmeOdaNoLbl.AutoSize = true;
            this.odaSilmeOdaNoLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSilmeOdaNoLbl.Location = new System.Drawing.Point(20, 46);
            this.odaSilmeOdaNoLbl.Name = "odaSilmeOdaNoLbl";
            this.odaSilmeOdaNoLbl.Size = new System.Drawing.Size(98, 25);
            this.odaSilmeOdaNoLbl.TabIndex = 0;
            this.odaSilmeOdaNoLbl.Text = "Oda No:";
            // 
            // odaSilmeOdaNoTxt
            // 
            this.odaSilmeOdaNoTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSilmeOdaNoTxt.Location = new System.Drawing.Point(25, 74);
            this.odaSilmeOdaNoTxt.Name = "odaSilmeOdaNoTxt";
            this.odaSilmeOdaNoTxt.Size = new System.Drawing.Size(303, 34);
            this.odaSilmeOdaNoTxt.TabIndex = 8;
            // 
            // odaAramaKısmıTxt
            // 
            this.odaAramaKısmıTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaAramaKısmıTxt.Location = new System.Drawing.Point(100, 38);
            this.odaAramaKısmıTxt.Name = "odaAramaKısmıTxt";
            this.odaAramaKısmıTxt.Size = new System.Drawing.Size(499, 30);
            this.odaAramaKısmıTxt.TabIndex = 2;
            this.odaAramaKısmıTxt.Text = "       Oda No veya Tipine Göre Arama...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OdaSecenekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.odaBilgileriGrpBox);
            this.Name = "OdaSecenekleri";
            this.Size = new System.Drawing.Size(1250, 700);
            this.odaBilgileriGrpBox.ResumeLayout(false);
            this.odaIslemleriGrpBox.ResumeLayout(false);
            this.odaIslemleriGrpBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.odaSilmeGrpBox.ResumeLayout(false);
            this.odaSilmeGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox odaBilgileriGrpBox;
        private System.Windows.Forms.GroupBox odaIslemleriGrpBox;
        private System.Windows.Forms.Label odaDurumuLbl;
        private System.Windows.Forms.Label odaTipiLbl;
        private System.Windows.Forms.Label odaNosuLbl;
        private System.Windows.Forms.TextBox odaTipiTxt;
        private System.Windows.Forms.TextBox odaNosuTxt;
        private System.Windows.Forms.ComboBox odaDurumuCmbBox;
        private System.Windows.Forms.Button odaSilmeBtn;
        private System.Windows.Forms.Button odaDuzenleBtn;
        private System.Windows.Forms.Button odaEkleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button odaListeleBtn;
        private System.Windows.Forms.GroupBox odaSilmeGrpBox;
        private System.Windows.Forms.Label odaSilmeOdaNoLbl;
        private System.Windows.Forms.TextBox odaSilmeOdaNoTxt;
        private System.Windows.Forms.TextBox odaAramaKısmıTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
