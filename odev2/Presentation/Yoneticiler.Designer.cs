namespace odev2
{
    partial class Yoneticiler
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
            this.yoneticiGirisYapmaGrpBox = new System.Windows.Forms.GroupBox();
            this.girisYapmaGrpBox = new System.Windows.Forms.GroupBox();
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.kullaniciAdiAlmaTxt = new System.Windows.Forms.TextBox();
            this.sifreAlmaLbl = new System.Windows.Forms.Label();
            this.sifreAlmaTxt = new System.Windows.Forms.TextBox();
            this.kullanıcıAdıAlmaLbl = new System.Windows.Forms.Label();
            this.sifremiUnuttumBtn = new System.Windows.Forms.Button();
            this.yoneticiGirisYapmaGrpBox.SuspendLayout();
            this.girisYapmaGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yoneticiGirisYapmaGrpBox
            // 
            this.yoneticiGirisYapmaGrpBox.Controls.Add(this.girisYapmaGrpBox);
            this.yoneticiGirisYapmaGrpBox.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGirisYapmaGrpBox.Location = new System.Drawing.Point(0, 0);
            this.yoneticiGirisYapmaGrpBox.Name = "yoneticiGirisYapmaGrpBox";
            this.yoneticiGirisYapmaGrpBox.Size = new System.Drawing.Size(1235, 700);
            this.yoneticiGirisYapmaGrpBox.TabIndex = 0;
            this.yoneticiGirisYapmaGrpBox.TabStop = false;
            this.yoneticiGirisYapmaGrpBox.Text = "Yönetici";
            // 
            // girisYapmaGrpBox
            // 
            this.girisYapmaGrpBox.Controls.Add(this.sifremiUnuttumBtn);
            this.girisYapmaGrpBox.Controls.Add(this.girisYapBtn);
            this.girisYapmaGrpBox.Controls.Add(this.kullaniciAdiAlmaTxt);
            this.girisYapmaGrpBox.Controls.Add(this.sifreAlmaLbl);
            this.girisYapmaGrpBox.Controls.Add(this.sifreAlmaTxt);
            this.girisYapmaGrpBox.Controls.Add(this.kullanıcıAdıAlmaLbl);
            this.girisYapmaGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapmaGrpBox.Location = new System.Drawing.Point(24, 89);
            this.girisYapmaGrpBox.Name = "girisYapmaGrpBox";
            this.girisYapmaGrpBox.Size = new System.Drawing.Size(551, 533);
            this.girisYapmaGrpBox.TabIndex = 0;
            this.girisYapmaGrpBox.TabStop = false;
            this.girisYapmaGrpBox.Text = "Giriş";
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBtn.Location = new System.Drawing.Point(379, 431);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(110, 70);
            this.girisYapBtn.TabIndex = 4;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = true;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // kullaniciAdiAlmaTxt
            // 
            this.kullaniciAdiAlmaTxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiAlmaTxt.Location = new System.Drawing.Point(35, 136);
            this.kullaniciAdiAlmaTxt.Name = "kullaniciAdiAlmaTxt";
            this.kullaniciAdiAlmaTxt.Size = new System.Drawing.Size(479, 42);
            this.kullaniciAdiAlmaTxt.TabIndex = 3;
            this.kullaniciAdiAlmaTxt.TextChanged += new System.EventHandler(this.kullanıcıAdıAlmaTxt_TextChanged);
            // 
            // sifreAlmaLbl
            // 
            this.sifreAlmaLbl.AutoSize = true;
            this.sifreAlmaLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreAlmaLbl.Location = new System.Drawing.Point(29, 255);
            this.sifreAlmaLbl.Name = "sifreAlmaLbl";
            this.sifreAlmaLbl.Size = new System.Drawing.Size(84, 35);
            this.sifreAlmaLbl.TabIndex = 2;
            this.sifreAlmaLbl.Text = "Şifre:";
            // 
            // sifreAlmaTxt
            // 
            this.sifreAlmaTxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreAlmaTxt.Location = new System.Drawing.Point(34, 308);
            this.sifreAlmaTxt.Name = "sifreAlmaTxt";
            this.sifreAlmaTxt.Size = new System.Drawing.Size(480, 42);
            this.sifreAlmaTxt.TabIndex = 1;
            this.sifreAlmaTxt.TextChanged += new System.EventHandler(this.sifreAlmaTxt_TextChanged);
            // 
            // kullanıcıAdıAlmaLbl
            // 
            this.kullanıcıAdıAlmaLbl.AutoSize = true;
            this.kullanıcıAdıAlmaLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdıAlmaLbl.Location = new System.Drawing.Point(29, 83);
            this.kullanıcıAdıAlmaLbl.Name = "kullanıcıAdıAlmaLbl";
            this.kullanıcıAdıAlmaLbl.Size = new System.Drawing.Size(192, 35);
            this.kullanıcıAdıAlmaLbl.TabIndex = 0;
            this.kullanıcıAdıAlmaLbl.Text = "Kullanıcı Adı:";
            // 
            // sifremiUnuttumBtn
            // 
            this.sifremiUnuttumBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifremiUnuttumBtn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiUnuttumBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sifremiUnuttumBtn.Location = new System.Drawing.Point(35, 356);
            this.sifremiUnuttumBtn.Name = "sifremiUnuttumBtn";
            this.sifremiUnuttumBtn.Size = new System.Drawing.Size(479, 30);
            this.sifremiUnuttumBtn.TabIndex = 5;
            this.sifremiUnuttumBtn.Text = "Şifremi Unuttum";
            this.sifremiUnuttumBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifremiUnuttumBtn.UseVisualStyleBackColor = false;
            this.sifremiUnuttumBtn.Click += new System.EventHandler(this.sifremiUnuttumBtn_Click);
            // 
            // Yoneticiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yoneticiGirisYapmaGrpBox);
            this.Name = "Yoneticiler";
            this.Size = new System.Drawing.Size(1250, 700);
            this.Load += new System.EventHandler(this.Yonetici_Load);
            this.yoneticiGirisYapmaGrpBox.ResumeLayout(false);
            this.girisYapmaGrpBox.ResumeLayout(false);
            this.girisYapmaGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox yoneticiGirisYapmaGrpBox;
        private System.Windows.Forms.GroupBox girisYapmaGrpBox;
        private System.Windows.Forms.TextBox kullaniciAdiAlmaTxt;
        private System.Windows.Forms.Label sifreAlmaLbl;
        private System.Windows.Forms.TextBox sifreAlmaTxt;
        private System.Windows.Forms.Label kullanıcıAdıAlmaLbl;
        private System.Windows.Forms.Button girisYapBtn;
        private System.Windows.Forms.Button sifremiUnuttumBtn;
    }
}
