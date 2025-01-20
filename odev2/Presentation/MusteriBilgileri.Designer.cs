namespace odev2
{
    partial class MusteriBilgileri
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
            this.musteriBilgileriAlmaGrpBox = new System.Windows.Forms.GroupBox();
            this.musteriSilmeGrpBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.musteriSilmeUyarıLbl = new System.Windows.Forms.Label();
            this.musteriSilmeBtn = new System.Windows.Forms.Button();
            this.musteriTcNosuSilmeTxt = new System.Windows.Forms.TextBox();
            this.musteriTcNosuSilmeLbl = new System.Windows.Forms.Label();
            this.musteriDuzenlemeGrpBox = new System.Windows.Forms.GroupBox();
            this.musteriOdemeTuruDuzenlemeCmbBox = new System.Windows.Forms.ComboBox();
            this.musteriDuzenlemeBtn = new System.Windows.Forms.Button();
            this.musteriAdiSoyadiDuzenlemeTxt = new System.Windows.Forms.TextBox();
            this.musteriTcNosuDuzenlemeTxt = new System.Windows.Forms.TextBox();
            this.musteriTelNosuDuzenlemeTxt = new System.Windows.Forms.TextBox();
            this.musteriOdemeTuruDuzenlemeLbl = new System.Windows.Forms.Label();
            this.musteriTcNosuDuzenlemeLbl = new System.Windows.Forms.Label();
            this.musteriTelNosuDuzenlemeLbl = new System.Windows.Forms.Label();
            this.musteriAdıSoyadiDuzenleLbl = new System.Windows.Forms.Label();
            this.musteriEklemeGrpBox = new System.Windows.Forms.GroupBox();
            this.musteriOdemeTuruCmbBox = new System.Windows.Forms.ComboBox();
            this.musteriAdıSoyadıLbl = new System.Windows.Forms.Label();
            this.musteriEkleBtn = new System.Windows.Forms.Button();
            this.musteriAdiSoyadiTxt = new System.Windows.Forms.TextBox();
            this.musteriTelNosuLbl = new System.Windows.Forms.Label();
            this.musteriOdemeTuruLbl = new System.Windows.Forms.Label();
            this.musteriTcNosuTxt = new System.Windows.Forms.TextBox();
            this.musteriTelNosuTxt = new System.Windows.Forms.TextBox();
            this.musteriTcNosuLbl = new System.Windows.Forms.Label();
            this.musteriBilgileriAlmaGrpBox.SuspendLayout();
            this.musteriSilmeGrpBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.musteriDuzenlemeGrpBox.SuspendLayout();
            this.musteriEklemeGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriBilgileriAlmaGrpBox
            // 
            this.musteriBilgileriAlmaGrpBox.BackColor = System.Drawing.Color.LightCyan;
            this.musteriBilgileriAlmaGrpBox.Controls.Add(this.musteriSilmeGrpBox);
            this.musteriBilgileriAlmaGrpBox.Controls.Add(this.musteriDuzenlemeGrpBox);
            this.musteriBilgileriAlmaGrpBox.Controls.Add(this.musteriEklemeGrpBox);
            this.musteriBilgileriAlmaGrpBox.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBilgileriAlmaGrpBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.musteriBilgileriAlmaGrpBox.Location = new System.Drawing.Point(0, 3);
            this.musteriBilgileriAlmaGrpBox.Name = "musteriBilgileriAlmaGrpBox";
            this.musteriBilgileriAlmaGrpBox.Size = new System.Drawing.Size(1240, 700);
            this.musteriBilgileriAlmaGrpBox.TabIndex = 0;
            this.musteriBilgileriAlmaGrpBox.TabStop = false;
            this.musteriBilgileriAlmaGrpBox.Text = "Müşteri";
            this.musteriBilgileriAlmaGrpBox.Enter += new System.EventHandler(this.musteriBilgileriAlmaGrpBox_Enter);
            // 
            // musteriSilmeGrpBox
            // 
            this.musteriSilmeGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriSilmeGrpBox.Controls.Add(this.panel1);
            this.musteriSilmeGrpBox.Controls.Add(this.musteriSilmeBtn);
            this.musteriSilmeGrpBox.Controls.Add(this.musteriTcNosuSilmeTxt);
            this.musteriSilmeGrpBox.Controls.Add(this.musteriTcNosuSilmeLbl);
            this.musteriSilmeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSilmeGrpBox.Location = new System.Drawing.Point(842, 49);
            this.musteriSilmeGrpBox.Name = "musteriSilmeGrpBox";
            this.musteriSilmeGrpBox.Size = new System.Drawing.Size(378, 574);
            this.musteriSilmeGrpBox.TabIndex = 11;
            this.musteriSilmeGrpBox.TabStop = false;
            this.musteriSilmeGrpBox.Text = "Müşteri Sil";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.musteriSilmeUyarıLbl);
            this.panel1.Location = new System.Drawing.Point(23, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 151);
            this.panel1.TabIndex = 3;
            // 
            // musteriSilmeUyarıLbl
            // 
            this.musteriSilmeUyarıLbl.BackColor = System.Drawing.Color.Snow;
            this.musteriSilmeUyarıLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musteriSilmeUyarıLbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriSilmeUyarıLbl.Location = new System.Drawing.Point(25, 17);
            this.musteriSilmeUyarıLbl.Name = "musteriSilmeUyarıLbl";
            this.musteriSilmeUyarıLbl.Size = new System.Drawing.Size(283, 119);
            this.musteriSilmeUyarıLbl.TabIndex = 0;
            this.musteriSilmeUyarıLbl.Text = " Uyarı: Silinen müşteriler geri alınamaz!";
            this.musteriSilmeUyarıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musteriSilmeUyarıLbl.UseCompatibleTextRendering = true;
            this.musteriSilmeUyarıLbl.Click += new System.EventHandler(this.musteriSilmeUyarıLbl_Click);
            // 
            // musteriSilmeBtn
            // 
            this.musteriSilmeBtn.BackColor = System.Drawing.Color.Red;
            this.musteriSilmeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriSilmeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSilmeBtn.Location = new System.Drawing.Point(23, 496);
            this.musteriSilmeBtn.Name = "musteriSilmeBtn";
            this.musteriSilmeBtn.Size = new System.Drawing.Size(334, 37);
            this.musteriSilmeBtn.TabIndex = 2;
            this.musteriSilmeBtn.Text = "Müşteri Sil";
            this.musteriSilmeBtn.UseVisualStyleBackColor = false;
            this.musteriSilmeBtn.Click += new System.EventHandler(this.musteriSilmeBtn_Click);
            // 
            // musteriTcNosuSilmeTxt
            // 
            this.musteriTcNosuSilmeTxt.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold);
            this.musteriTcNosuSilmeTxt.Location = new System.Drawing.Point(23, 98);
            this.musteriTcNosuSilmeTxt.Name = "musteriTcNosuSilmeTxt";
            this.musteriTcNosuSilmeTxt.Size = new System.Drawing.Size(334, 40);
            this.musteriTcNosuSilmeTxt.TabIndex = 1;
            // 
            // musteriTcNosuSilmeLbl
            // 
            this.musteriTcNosuSilmeLbl.AutoSize = true;
            this.musteriTcNosuSilmeLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTcNosuSilmeLbl.Location = new System.Drawing.Point(6, 70);
            this.musteriTcNosuSilmeLbl.Name = "musteriTcNosuSilmeLbl";
            this.musteriTcNosuSilmeLbl.Size = new System.Drawing.Size(87, 25);
            this.musteriTcNosuSilmeLbl.TabIndex = 0;
            this.musteriTcNosuSilmeLbl.Text = "TC No:";
            // 
            // musteriDuzenlemeGrpBox
            // 
            this.musteriDuzenlemeGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriOdemeTuruDuzenlemeCmbBox);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriDuzenlemeBtn);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriAdiSoyadiDuzenlemeTxt);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriTcNosuDuzenlemeTxt);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriTelNosuDuzenlemeTxt);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriOdemeTuruDuzenlemeLbl);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriTcNosuDuzenlemeLbl);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriTelNosuDuzenlemeLbl);
            this.musteriDuzenlemeGrpBox.Controls.Add(this.musteriAdıSoyadiDuzenleLbl);
            this.musteriDuzenlemeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriDuzenlemeGrpBox.Location = new System.Drawing.Point(435, 49);
            this.musteriDuzenlemeGrpBox.Name = "musteriDuzenlemeGrpBox";
            this.musteriDuzenlemeGrpBox.Size = new System.Drawing.Size(378, 574);
            this.musteriDuzenlemeGrpBox.TabIndex = 10;
            this.musteriDuzenlemeGrpBox.TabStop = false;
            this.musteriDuzenlemeGrpBox.Text = "Müşteri Düzenle";
            // 
            // musteriOdemeTuruDuzenlemeCmbBox
            // 
            this.musteriOdemeTuruDuzenlemeCmbBox.FormattingEnabled = true;
            this.musteriOdemeTuruDuzenlemeCmbBox.Location = new System.Drawing.Point(16, 414);
            this.musteriOdemeTuruDuzenlemeCmbBox.Name = "musteriOdemeTuruDuzenlemeCmbBox";
            this.musteriOdemeTuruDuzenlemeCmbBox.Size = new System.Drawing.Size(345, 40);
            this.musteriOdemeTuruDuzenlemeCmbBox.TabIndex = 10;
            // 
            // musteriDuzenlemeBtn
            // 
            this.musteriDuzenlemeBtn.BackColor = System.Drawing.Color.Yellow;
            this.musteriDuzenlemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriDuzenlemeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriDuzenlemeBtn.Location = new System.Drawing.Point(16, 496);
            this.musteriDuzenlemeBtn.Name = "musteriDuzenlemeBtn";
            this.musteriDuzenlemeBtn.Size = new System.Drawing.Size(342, 37);
            this.musteriDuzenlemeBtn.TabIndex = 8;
            this.musteriDuzenlemeBtn.Text = "Müşteri Düzenle";
            this.musteriDuzenlemeBtn.UseVisualStyleBackColor = false;
            this.musteriDuzenlemeBtn.Click += new System.EventHandler(this.musteriDuzenlemeBtn_Click);
            // 
            // musteriAdiSoyadiDuzenlemeTxt
            // 
            this.musteriAdiSoyadiDuzenlemeTxt.Location = new System.Drawing.Point(11, 97);
            this.musteriAdiSoyadiDuzenlemeTxt.Name = "musteriAdiSoyadiDuzenlemeTxt";
            this.musteriAdiSoyadiDuzenlemeTxt.Size = new System.Drawing.Size(347, 40);
            this.musteriAdiSoyadiDuzenlemeTxt.TabIndex = 4;
            // 
            // musteriTcNosuDuzenlemeTxt
            // 
            this.musteriTcNosuDuzenlemeTxt.Location = new System.Drawing.Point(16, 309);
            this.musteriTcNosuDuzenlemeTxt.Name = "musteriTcNosuDuzenlemeTxt";
            this.musteriTcNosuDuzenlemeTxt.Size = new System.Drawing.Size(345, 40);
            this.musteriTcNosuDuzenlemeTxt.TabIndex = 6;
            // 
            // musteriTelNosuDuzenlemeTxt
            // 
            this.musteriTelNosuDuzenlemeTxt.Location = new System.Drawing.Point(16, 199);
            this.musteriTelNosuDuzenlemeTxt.Name = "musteriTelNosuDuzenlemeTxt";
            this.musteriTelNosuDuzenlemeTxt.Size = new System.Drawing.Size(345, 40);
            this.musteriTelNosuDuzenlemeTxt.TabIndex = 5;
            // 
            // musteriOdemeTuruDuzenlemeLbl
            // 
            this.musteriOdemeTuruDuzenlemeLbl.AutoSize = true;
            this.musteriOdemeTuruDuzenlemeLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriOdemeTuruDuzenlemeLbl.Location = new System.Drawing.Point(6, 385);
            this.musteriOdemeTuruDuzenlemeLbl.Name = "musteriOdemeTuruDuzenlemeLbl";
            this.musteriOdemeTuruDuzenlemeLbl.Size = new System.Drawing.Size(149, 25);
            this.musteriOdemeTuruDuzenlemeLbl.TabIndex = 3;
            this.musteriOdemeTuruDuzenlemeLbl.Text = "Ödeme Türü:";
            // 
            // musteriTcNosuDuzenlemeLbl
            // 
            this.musteriTcNosuDuzenlemeLbl.AutoSize = true;
            this.musteriTcNosuDuzenlemeLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTcNosuDuzenlemeLbl.Location = new System.Drawing.Point(6, 280);
            this.musteriTcNosuDuzenlemeLbl.Name = "musteriTcNosuDuzenlemeLbl";
            this.musteriTcNosuDuzenlemeLbl.Size = new System.Drawing.Size(87, 25);
            this.musteriTcNosuDuzenlemeLbl.TabIndex = 2;
            this.musteriTcNosuDuzenlemeLbl.Text = "TC No:";
            // 
            // musteriTelNosuDuzenlemeLbl
            // 
            this.musteriTelNosuDuzenlemeLbl.AutoSize = true;
            this.musteriTelNosuDuzenlemeLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTelNosuDuzenlemeLbl.Location = new System.Drawing.Point(6, 171);
            this.musteriTelNosuDuzenlemeLbl.Name = "musteriTelNosuDuzenlemeLbl";
            this.musteriTelNosuDuzenlemeLbl.Size = new System.Drawing.Size(128, 25);
            this.musteriTelNosuDuzenlemeLbl.TabIndex = 1;
            this.musteriTelNosuDuzenlemeLbl.Text = "Telefon No:";
            // 
            // musteriAdıSoyadiDuzenleLbl
            // 
            this.musteriAdıSoyadiDuzenleLbl.AutoSize = true;
            this.musteriAdıSoyadiDuzenleLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriAdıSoyadiDuzenleLbl.Location = new System.Drawing.Point(6, 70);
            this.musteriAdıSoyadiDuzenleLbl.Name = "musteriAdıSoyadiDuzenleLbl";
            this.musteriAdıSoyadiDuzenleLbl.Size = new System.Drawing.Size(142, 25);
            this.musteriAdıSoyadiDuzenleLbl.TabIndex = 0;
            this.musteriAdıSoyadiDuzenleLbl.Text = "Adı - Soyadı:";
            // 
            // musteriEklemeGrpBox
            // 
            this.musteriEklemeGrpBox.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriEklemeGrpBox.Controls.Add(this.musteriOdemeTuruCmbBox);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriAdıSoyadıLbl);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriEkleBtn);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriAdiSoyadiTxt);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriTelNosuLbl);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriOdemeTuruLbl);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriTcNosuTxt);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriTelNosuTxt);
            this.musteriEklemeGrpBox.Controls.Add(this.musteriTcNosuLbl);
            this.musteriEklemeGrpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEklemeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEklemeGrpBox.Location = new System.Drawing.Point(29, 49);
            this.musteriEklemeGrpBox.Name = "musteriEklemeGrpBox";
            this.musteriEklemeGrpBox.Size = new System.Drawing.Size(378, 574);
            this.musteriEklemeGrpBox.TabIndex = 9;
            this.musteriEklemeGrpBox.TabStop = false;
            this.musteriEklemeGrpBox.Text = "Müşteri Ekle";
            // 
            // musteriOdemeTuruCmbBox
            // 
            this.musteriOdemeTuruCmbBox.FormattingEnabled = true;
            this.musteriOdemeTuruCmbBox.Location = new System.Drawing.Point(11, 414);
            this.musteriOdemeTuruCmbBox.Name = "musteriOdemeTuruCmbBox";
            this.musteriOdemeTuruCmbBox.Size = new System.Drawing.Size(345, 40);
            this.musteriOdemeTuruCmbBox.TabIndex = 9;
            // 
            // musteriAdıSoyadıLbl
            // 
            this.musteriAdıSoyadıLbl.AutoSize = true;
            this.musteriAdıSoyadıLbl.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriAdıSoyadıLbl.Location = new System.Drawing.Point(1, 67);
            this.musteriAdıSoyadıLbl.Name = "musteriAdıSoyadıLbl";
            this.musteriAdıSoyadıLbl.Size = new System.Drawing.Size(141, 28);
            this.musteriAdıSoyadıLbl.TabIndex = 1;
            this.musteriAdıSoyadıLbl.Text = "Adı - Soyadı:";
            // 
            // musteriEkleBtn
            // 
            this.musteriEkleBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.musteriEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEkleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEkleBtn.Location = new System.Drawing.Point(11, 496);
            this.musteriEkleBtn.Name = "musteriEkleBtn";
            this.musteriEkleBtn.Size = new System.Drawing.Size(345, 37);
            this.musteriEkleBtn.TabIndex = 8;
            this.musteriEkleBtn.Text = "Müşteri Ekle";
            this.musteriEkleBtn.UseVisualStyleBackColor = false;
            this.musteriEkleBtn.Click += new System.EventHandler(this.musteriEkleBtn_Click);
            // 
            // musteriAdiSoyadiTxt
            // 
            this.musteriAdiSoyadiTxt.Location = new System.Drawing.Point(11, 98);
            this.musteriAdiSoyadiTxt.Name = "musteriAdiSoyadiTxt";
            this.musteriAdiSoyadiTxt.Size = new System.Drawing.Size(345, 40);
            this.musteriAdiSoyadiTxt.TabIndex = 0;
            // 
            // musteriTelNosuLbl
            // 
            this.musteriTelNosuLbl.AutoSize = true;
            this.musteriTelNosuLbl.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriTelNosuLbl.Location = new System.Drawing.Point(1, 168);
            this.musteriTelNosuLbl.Name = "musteriTelNosuLbl";
            this.musteriTelNosuLbl.Size = new System.Drawing.Size(131, 28);
            this.musteriTelNosuLbl.TabIndex = 3;
            this.musteriTelNosuLbl.Text = "Telefon No:";
            // 
            // musteriOdemeTuruLbl
            // 
            this.musteriOdemeTuruLbl.AutoSize = true;
            this.musteriOdemeTuruLbl.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriOdemeTuruLbl.Location = new System.Drawing.Point(1, 382);
            this.musteriOdemeTuruLbl.Name = "musteriOdemeTuruLbl";
            this.musteriOdemeTuruLbl.Size = new System.Drawing.Size(146, 28);
            this.musteriOdemeTuruLbl.TabIndex = 4;
            this.musteriOdemeTuruLbl.Text = "Ödeme Türü:";
            // 
            // musteriTcNosuTxt
            // 
            this.musteriTcNosuTxt.Location = new System.Drawing.Point(11, 308);
            this.musteriTcNosuTxt.Name = "musteriTcNosuTxt";
            this.musteriTcNosuTxt.Size = new System.Drawing.Size(347, 40);
            this.musteriTcNosuTxt.TabIndex = 5;
            // 
            // musteriTelNosuTxt
            // 
            this.musteriTelNosuTxt.Location = new System.Drawing.Point(11, 199);
            this.musteriTelNosuTxt.Name = "musteriTelNosuTxt";
            this.musteriTelNosuTxt.Size = new System.Drawing.Size(347, 40);
            this.musteriTelNosuTxt.TabIndex = 6;
            // 
            // musteriTcNosuLbl
            // 
            this.musteriTcNosuLbl.AutoSize = true;
            this.musteriTcNosuLbl.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musteriTcNosuLbl.Location = new System.Drawing.Point(1, 277);
            this.musteriTcNosuLbl.Name = "musteriTcNosuLbl";
            this.musteriTcNosuLbl.Size = new System.Drawing.Size(85, 28);
            this.musteriTcNosuLbl.TabIndex = 2;
            this.musteriTcNosuLbl.Text = "TC No:";
            // 
            // MusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.musteriBilgileriAlmaGrpBox);
            this.Name = "MusteriBilgileri";
            this.Size = new System.Drawing.Size(1250, 700);
            this.Load += new System.EventHandler(this.MusteriBilgileri_Load);
            this.musteriBilgileriAlmaGrpBox.ResumeLayout(false);
            this.musteriSilmeGrpBox.ResumeLayout(false);
            this.musteriSilmeGrpBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.musteriDuzenlemeGrpBox.ResumeLayout(false);
            this.musteriDuzenlemeGrpBox.PerformLayout();
            this.musteriEklemeGrpBox.ResumeLayout(false);
            this.musteriEklemeGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox musteriBilgileriAlmaGrpBox;
        private System.Windows.Forms.Label musteriOdemeTuruLbl;
        private System.Windows.Forms.Label musteriTelNosuLbl;
        private System.Windows.Forms.Label musteriTcNosuLbl;
        private System.Windows.Forms.Label musteriAdıSoyadıLbl;
        private System.Windows.Forms.TextBox musteriAdiSoyadiTxt;
        private System.Windows.Forms.TextBox musteriTelNosuTxt;
        private System.Windows.Forms.TextBox musteriTcNosuTxt;
        private System.Windows.Forms.Button musteriEkleBtn;
        private System.Windows.Forms.GroupBox musteriEklemeGrpBox;
        private System.Windows.Forms.GroupBox musteriDuzenlemeGrpBox;
        private System.Windows.Forms.TextBox musteriTcNosuDuzenlemeTxt;
        private System.Windows.Forms.TextBox musteriTelNosuDuzenlemeTxt;
        private System.Windows.Forms.TextBox musteriAdiSoyadiDuzenlemeTxt;
        private System.Windows.Forms.Label musteriOdemeTuruDuzenlemeLbl;
        private System.Windows.Forms.Label musteriTcNosuDuzenlemeLbl;
        private System.Windows.Forms.Label musteriTelNosuDuzenlemeLbl;
        private System.Windows.Forms.Label musteriAdıSoyadiDuzenleLbl;
        private System.Windows.Forms.Button musteriDuzenlemeBtn;
        private System.Windows.Forms.GroupBox musteriSilmeGrpBox;
        private System.Windows.Forms.TextBox musteriTcNosuSilmeTxt;
        private System.Windows.Forms.Label musteriTcNosuSilmeLbl;
        private System.Windows.Forms.Button musteriSilmeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label musteriSilmeUyarıLbl;
        private System.Windows.Forms.ComboBox musteriOdemeTuruDuzenlemeCmbBox;
        private System.Windows.Forms.ComboBox musteriOdemeTuruCmbBox;
    }
}
