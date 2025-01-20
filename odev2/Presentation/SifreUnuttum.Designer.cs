namespace odev2
{
    partial class SifreUnuttum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guvenlikCevabıLbl = new System.Windows.Forms.Label();
            this.guvenlikCevabiTxt = new System.Windows.Forms.TextBox();
            this.guvenlikKontrolBtn = new System.Windows.Forms.Button();
            this.guvenlikSorusuCmbBox = new System.Windows.Forms.ComboBox();
            this.guvenlikSorusuLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guvenlikCevabıLbl);
            this.groupBox1.Controls.Add(this.guvenlikCevabiTxt);
            this.groupBox1.Controls.Add(this.guvenlikKontrolBtn);
            this.groupBox1.Controls.Add(this.guvenlikSorusuCmbBox);
            this.groupBox1.Controls.Add(this.guvenlikSorusuLbl);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Unuttum";
            // 
            // guvenlikCevabıLbl
            // 
            this.guvenlikCevabıLbl.AutoSize = true;
            this.guvenlikCevabıLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikCevabıLbl.Location = new System.Drawing.Point(17, 214);
            this.guvenlikCevabıLbl.Name = "guvenlikCevabıLbl";
            this.guvenlikCevabıLbl.Size = new System.Drawing.Size(105, 35);
            this.guvenlikCevabıLbl.TabIndex = 4;
            this.guvenlikCevabıLbl.Text = "Cevap:";
            // 
            // guvenlikCevabiTxt
            // 
            this.guvenlikCevabiTxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikCevabiTxt.Location = new System.Drawing.Point(35, 281);
            this.guvenlikCevabiTxt.Name = "guvenlikCevabiTxt";
            this.guvenlikCevabiTxt.Size = new System.Drawing.Size(376, 42);
            this.guvenlikCevabiTxt.TabIndex = 3;
            // 
            // guvenlikKontrolBtn
            // 
            this.guvenlikKontrolBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikKontrolBtn.Location = new System.Drawing.Point(57, 422);
            this.guvenlikKontrolBtn.Name = "guvenlikKontrolBtn";
            this.guvenlikKontrolBtn.Size = new System.Drawing.Size(327, 61);
            this.guvenlikKontrolBtn.TabIndex = 2;
            this.guvenlikKontrolBtn.Text = "Onayla";
            this.guvenlikKontrolBtn.UseVisualStyleBackColor = true;
            this.guvenlikKontrolBtn.Click += new System.EventHandler(this.guvenlikKontrolBtn_Click);
            // 
            // guvenlikSorusuCmbBox
            // 
            this.guvenlikSorusuCmbBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikSorusuCmbBox.FormattingEnabled = true;
            this.guvenlikSorusuCmbBox.Location = new System.Drawing.Point(35, 121);
            this.guvenlikSorusuCmbBox.Name = "guvenlikSorusuCmbBox";
            this.guvenlikSorusuCmbBox.Size = new System.Drawing.Size(376, 42);
            this.guvenlikSorusuCmbBox.TabIndex = 1;
            this.guvenlikSorusuCmbBox.SelectedIndexChanged += new System.EventHandler(this.guvenlikSorusuCmbBox_SelectedIndexChanged);
            // 
            // guvenlikSorusuLbl
            // 
            this.guvenlikSorusuLbl.AutoSize = true;
            this.guvenlikSorusuLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikSorusuLbl.Location = new System.Drawing.Point(17, 57);
            this.guvenlikSorusuLbl.Name = "guvenlikSorusuLbl";
            this.guvenlikSorusuLbl.Size = new System.Drawing.Size(235, 35);
            this.guvenlikSorusuLbl.TabIndex = 0;
            this.guvenlikSorusuLbl.Text = "Güvenlik Sorusu:";
            // 
            // SifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "SifreUnuttum";
            this.Size = new System.Drawing.Size(450, 550);
            this.Load += new System.EventHandler(this.sifreUnuttum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox guvenlikCevabiTxt;
        private System.Windows.Forms.Button guvenlikKontrolBtn;
        private System.Windows.Forms.ComboBox guvenlikSorusuCmbBox;
        private System.Windows.Forms.Label guvenlikSorusuLbl;
        private System.Windows.Forms.Label guvenlikCevabıLbl;
    }
}
