namespace odev2
{
    partial class OdaSecme
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
            this.rezervasyonBilgileriGrpBox = new System.Windows.Forms.GroupBox();
            this.rezervasyonOlusturmaBtn = new System.Windows.Forms.Button();
            this.odaTurleriBakSecGrpBox = new System.Windows.Forms.GroupBox();
            this.bosOdaListeleBtn = new System.Windows.Forms.Button();
            this.uygunOdalarDgv = new System.Windows.Forms.DataGridView();
            this.odaTuruSecLbl = new System.Windows.Forms.Label();
            this.odaTuruSecCmbBox = new System.Windows.Forms.ComboBox();
            this.girisCıkısTarihiGrpBox = new System.Windows.Forms.GroupBox();
            this.cıkısTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.girisTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.girisTarihiLbl = new System.Windows.Forms.Label();
            this.cıkısTarihiLbl = new System.Windows.Forms.Label();
            this.musteriListelemeGrpBox = new System.Windows.Forms.GroupBox();
            this.musteriListelemeBtn = new System.Windows.Forms.Button();
            this.musteriListelemeDgv = new System.Windows.Forms.DataGridView();
            this.rezervasyonDuzenleBtn = new System.Windows.Forms.Button();
            this.rezervasyonBilgileriGrpBox.SuspendLayout();
            this.odaTurleriBakSecGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uygunOdalarDgv)).BeginInit();
            this.girisCıkısTarihiGrpBox.SuspendLayout();
            this.musteriListelemeGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriListelemeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervasyonBilgileriGrpBox
            // 
            this.rezervasyonBilgileriGrpBox.Controls.Add(this.rezervasyonDuzenleBtn);
            this.rezervasyonBilgileriGrpBox.Controls.Add(this.rezervasyonOlusturmaBtn);
            this.rezervasyonBilgileriGrpBox.Controls.Add(this.odaTurleriBakSecGrpBox);
            this.rezervasyonBilgileriGrpBox.Controls.Add(this.girisCıkısTarihiGrpBox);
            this.rezervasyonBilgileriGrpBox.Controls.Add(this.musteriListelemeGrpBox);
            this.rezervasyonBilgileriGrpBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonBilgileriGrpBox.Location = new System.Drawing.Point(3, 3);
            this.rezervasyonBilgileriGrpBox.Name = "rezervasyonBilgileriGrpBox";
            this.rezervasyonBilgileriGrpBox.Size = new System.Drawing.Size(1235, 700);
            this.rezervasyonBilgileriGrpBox.TabIndex = 2;
            this.rezervasyonBilgileriGrpBox.TabStop = false;
            this.rezervasyonBilgileriGrpBox.Text = "Rezervasyon";
            // 
            // rezervasyonOlusturmaBtn
            // 
            this.rezervasyonOlusturmaBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonOlusturmaBtn.Location = new System.Drawing.Point(734, 592);
            this.rezervasyonOlusturmaBtn.Name = "rezervasyonOlusturmaBtn";
            this.rezervasyonOlusturmaBtn.Size = new System.Drawing.Size(258, 65);
            this.rezervasyonOlusturmaBtn.TabIndex = 18;
            this.rezervasyonOlusturmaBtn.Text = "Rezervasyon Oluştur";
            this.rezervasyonOlusturmaBtn.UseVisualStyleBackColor = true;
            // 
            // odaTurleriBakSecGrpBox
            // 
            this.odaTurleriBakSecGrpBox.Controls.Add(this.bosOdaListeleBtn);
            this.odaTurleriBakSecGrpBox.Controls.Add(this.uygunOdalarDgv);
            this.odaTurleriBakSecGrpBox.Controls.Add(this.odaTuruSecLbl);
            this.odaTurleriBakSecGrpBox.Controls.Add(this.odaTuruSecCmbBox);
            this.odaTurleriBakSecGrpBox.Location = new System.Drawing.Point(489, 166);
            this.odaTurleriBakSecGrpBox.Name = "odaTurleriBakSecGrpBox";
            this.odaTurleriBakSecGrpBox.Size = new System.Drawing.Size(634, 397);
            this.odaTurleriBakSecGrpBox.TabIndex = 17;
            this.odaTurleriBakSecGrpBox.TabStop = false;
            this.odaTurleriBakSecGrpBox.Text = "Oda";
            // 
            // bosOdaListeleBtn
            // 
            this.bosOdaListeleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosOdaListeleBtn.Location = new System.Drawing.Point(396, 34);
            this.bosOdaListeleBtn.Name = "bosOdaListeleBtn";
            this.bosOdaListeleBtn.Size = new System.Drawing.Size(105, 44);
            this.bosOdaListeleBtn.TabIndex = 3;
            this.bosOdaListeleBtn.Text = "Oda Ara";
            this.bosOdaListeleBtn.UseVisualStyleBackColor = true;
            // 
            // uygunOdalarDgv
            // 
            this.uygunOdalarDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uygunOdalarDgv.Location = new System.Drawing.Point(23, 99);
            this.uygunOdalarDgv.Name = "uygunOdalarDgv";
            this.uygunOdalarDgv.RowHeadersWidth = 51;
            this.uygunOdalarDgv.RowTemplate.Height = 24;
            this.uygunOdalarDgv.Size = new System.Drawing.Size(588, 275);
            this.uygunOdalarDgv.TabIndex = 2;
            // 
            // odaTuruSecLbl
            // 
            this.odaTuruSecLbl.AutoSize = true;
            this.odaTuruSecLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaTuruSecLbl.Location = new System.Drawing.Point(18, 47);
            this.odaTuruSecLbl.Name = "odaTuruSecLbl";
            this.odaTuruSecLbl.Size = new System.Drawing.Size(120, 25);
            this.odaTuruSecLbl.TabIndex = 1;
            this.odaTuruSecLbl.Text = "Oda Türü:";
            // 
            // odaTuruSecCmbBox
            // 
            this.odaTuruSecCmbBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaTuruSecCmbBox.FormattingEnabled = true;
            this.odaTuruSecCmbBox.Location = new System.Drawing.Point(150, 39);
            this.odaTuruSecCmbBox.Name = "odaTuruSecCmbBox";
            this.odaTuruSecCmbBox.Size = new System.Drawing.Size(195, 33);
            this.odaTuruSecCmbBox.TabIndex = 0;
            // 
            // girisCıkısTarihiGrpBox
            // 
            this.girisCıkısTarihiGrpBox.Controls.Add(this.cıkısTarihiDtp);
            this.girisCıkısTarihiGrpBox.Controls.Add(this.girisTarihiDtp);
            this.girisCıkısTarihiGrpBox.Controls.Add(this.girisTarihiLbl);
            this.girisCıkısTarihiGrpBox.Controls.Add(this.cıkısTarihiLbl);
            this.girisCıkısTarihiGrpBox.Location = new System.Drawing.Point(13, 50);
            this.girisCıkısTarihiGrpBox.Name = "girisCıkısTarihiGrpBox";
            this.girisCıkısTarihiGrpBox.Size = new System.Drawing.Size(1110, 102);
            this.girisCıkısTarihiGrpBox.TabIndex = 16;
            this.girisCıkısTarihiGrpBox.TabStop = false;
            this.girisCıkısTarihiGrpBox.Text = "Tarih";
            // 
            // cıkısTarihiDtp
            // 
            this.cıkısTarihiDtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısTarihiDtp.Location = new System.Drawing.Point(772, 41);
            this.cıkısTarihiDtp.Name = "cıkısTarihiDtp";
            this.cıkısTarihiDtp.Size = new System.Drawing.Size(300, 30);
            this.cıkısTarihiDtp.TabIndex = 19;
            // 
            // girisTarihiDtp
            // 
            this.girisTarihiDtp.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihiDtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihiDtp.Location = new System.Drawing.Point(143, 41);
            this.girisTarihiDtp.Name = "girisTarihiDtp";
            this.girisTarihiDtp.Size = new System.Drawing.Size(300, 30);
            this.girisTarihiDtp.TabIndex = 18;
            // 
            // girisTarihiLbl
            // 
            this.girisTarihiLbl.AutoSize = true;
            this.girisTarihiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihiLbl.Location = new System.Drawing.Point(6, 46);
            this.girisTarihiLbl.Name = "girisTarihiLbl";
            this.girisTarihiLbl.Size = new System.Drawing.Size(131, 25);
            this.girisTarihiLbl.TabIndex = 14;
            this.girisTarihiLbl.Text = "Giriş Tarihi:";
            // 
            // cıkısTarihiLbl
            // 
            this.cıkısTarihiLbl.AutoSize = true;
            this.cıkısTarihiLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısTarihiLbl.Location = new System.Drawing.Point(632, 46);
            this.cıkısTarihiLbl.Name = "cıkısTarihiLbl";
            this.cıkısTarihiLbl.Size = new System.Drawing.Size(134, 25);
            this.cıkısTarihiLbl.TabIndex = 15;
            this.cıkısTarihiLbl.Text = "Çıkış Tarihi:";
            // 
            // musteriListelemeGrpBox
            // 
            this.musteriListelemeGrpBox.Controls.Add(this.musteriListelemeBtn);
            this.musteriListelemeGrpBox.Controls.Add(this.musteriListelemeDgv);
            this.musteriListelemeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriListelemeGrpBox.Location = new System.Drawing.Point(13, 166);
            this.musteriListelemeGrpBox.Name = "musteriListelemeGrpBox";
            this.musteriListelemeGrpBox.Size = new System.Drawing.Size(449, 397);
            this.musteriListelemeGrpBox.TabIndex = 13;
            this.musteriListelemeGrpBox.TabStop = false;
            this.musteriListelemeGrpBox.Text = "Müşteriler";
            // 
            // musteriListelemeBtn
            // 
            this.musteriListelemeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriListelemeBtn.Location = new System.Drawing.Point(170, 333);
            this.musteriListelemeBtn.Name = "musteriListelemeBtn";
            this.musteriListelemeBtn.Size = new System.Drawing.Size(113, 52);
            this.musteriListelemeBtn.TabIndex = 9;
            this.musteriListelemeBtn.Text = "Listele";
            this.musteriListelemeBtn.UseVisualStyleBackColor = true;
            // 
            // musteriListelemeDgv
            // 
            this.musteriListelemeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriListelemeDgv.Location = new System.Drawing.Point(7, 39);
            this.musteriListelemeDgv.Name = "musteriListelemeDgv";
            this.musteriListelemeDgv.RowHeadersWidth = 51;
            this.musteriListelemeDgv.RowTemplate.Height = 24;
            this.musteriListelemeDgv.Size = new System.Drawing.Size(436, 288);
            this.musteriListelemeDgv.TabIndex = 0;
            // 
            // rezervasyonDuzenleBtn
            // 
            this.rezervasyonDuzenleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonDuzenleBtn.Location = new System.Drawing.Point(130, 592);
            this.rezervasyonDuzenleBtn.Name = "rezervasyonDuzenleBtn";
            this.rezervasyonDuzenleBtn.Size = new System.Drawing.Size(258, 65);
            this.rezervasyonDuzenleBtn.TabIndex = 19;
            this.rezervasyonDuzenleBtn.Text = "Rezervasyon Düzenle";
            this.rezervasyonDuzenleBtn.UseVisualStyleBackColor = true;
            // 
            // OdaSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rezervasyonBilgileriGrpBox);
            this.Name = "OdaSecme";
            this.Size = new System.Drawing.Size(1250, 700);
            this.rezervasyonBilgileriGrpBox.ResumeLayout(false);
            this.odaTurleriBakSecGrpBox.ResumeLayout(false);
            this.odaTurleriBakSecGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uygunOdalarDgv)).EndInit();
            this.girisCıkısTarihiGrpBox.ResumeLayout(false);
            this.girisCıkısTarihiGrpBox.PerformLayout();
            this.musteriListelemeGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musteriListelemeDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox rezervasyonBilgileriGrpBox;
        private System.Windows.Forms.GroupBox musteriListelemeGrpBox;
        private System.Windows.Forms.Button musteriListelemeBtn;
        private System.Windows.Forms.DataGridView musteriListelemeDgv;
        private System.Windows.Forms.Label girisTarihiLbl;
        private System.Windows.Forms.Label cıkısTarihiLbl;
        private System.Windows.Forms.GroupBox girisCıkısTarihiGrpBox;
        private System.Windows.Forms.DateTimePicker girisTarihiDtp;
        private System.Windows.Forms.GroupBox odaTurleriBakSecGrpBox;
        private System.Windows.Forms.Label odaTuruSecLbl;
        private System.Windows.Forms.ComboBox odaTuruSecCmbBox;
        private System.Windows.Forms.DateTimePicker cıkısTarihiDtp;
        private System.Windows.Forms.Button rezervasyonOlusturmaBtn;
        private System.Windows.Forms.Button bosOdaListeleBtn;
        private System.Windows.Forms.DataGridView uygunOdalarDgv;
        private System.Windows.Forms.Button rezervasyonDuzenleBtn;
    }
}
