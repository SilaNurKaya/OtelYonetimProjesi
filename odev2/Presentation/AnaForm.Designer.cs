﻿namespace odev2
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
            this.solPanel = new System.Windows.Forms.Panel();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.odaSecmeGetirBtn = new System.Windows.Forms.Button();
            this.kayanPanel = new System.Windows.Forms.Panel();
            this.girisCıkısBilgileriGetirBtn = new System.Windows.Forms.Button();
            this.rezervasyonIptalGetirBtn = new System.Windows.Forms.Button();
            this.odaSecenekleriGetirBtn = new System.Windows.Forms.Button();
            this.musteriBilgileriGetirbtn = new System.Windows.Forms.Button();
            this.adminGirisGetirBtn = new System.Windows.Forms.Button();
            this.içerikPanel = new System.Windows.Forms.Panel();
            this.solPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // solPanel
            // 
            this.solPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.solPanel.Controls.Add(this.anaSayfaBtn);
            this.solPanel.Controls.Add(this.odaSecmeGetirBtn);
            this.solPanel.Controls.Add(this.kayanPanel);
            this.solPanel.Controls.Add(this.girisCıkısBilgileriGetirBtn);
            this.solPanel.Controls.Add(this.rezervasyonIptalGetirBtn);
            this.solPanel.Controls.Add(this.odaSecenekleriGetirBtn);
            this.solPanel.Controls.Add(this.musteriBilgileriGetirbtn);
            this.solPanel.Controls.Add(this.adminGirisGetirBtn);
            this.solPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solPanel.Location = new System.Drawing.Point(0, 0);
            this.solPanel.Name = "solPanel";
            this.solPanel.Size = new System.Drawing.Size(200, 703);
            this.solPanel.TabIndex = 1;
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.FlatAppearance.BorderSize = 0;
            this.anaSayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfaBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSayfaBtn.Location = new System.Drawing.Point(24, 12);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(170, 70);
            this.anaSayfaBtn.TabIndex = 8;
            this.anaSayfaBtn.Text = "Ana Sayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = true;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            // 
            // odaSecmeGetirBtn
            // 
            this.odaSecmeGetirBtn.FlatAppearance.BorderSize = 0;
            this.odaSecmeGetirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaSecmeGetirBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSecmeGetirBtn.Location = new System.Drawing.Point(24, 282);
            this.odaSecmeGetirBtn.Name = "odaSecmeGetirBtn";
            this.odaSecmeGetirBtn.Size = new System.Drawing.Size(170, 70);
            this.odaSecmeGetirBtn.TabIndex = 7;
            this.odaSecmeGetirBtn.Text = "Rezervasyon Oluştur";
            this.odaSecmeGetirBtn.UseVisualStyleBackColor = true;
            this.odaSecmeGetirBtn.Click += new System.EventHandler(this.odaSecmeGetirBtn_Click);
            // 
            // kayanPanel
            // 
            this.kayanPanel.BackColor = System.Drawing.Color.Black;
            this.kayanPanel.Location = new System.Drawing.Point(3, 12);
            this.kayanPanel.Name = "kayanPanel";
            this.kayanPanel.Size = new System.Drawing.Size(15, 70);
            this.kayanPanel.TabIndex = 0;
            // 
            // girisCıkısBilgileriGetirBtn
            // 
            this.girisCıkısBilgileriGetirBtn.FlatAppearance.BorderSize = 0;
            this.girisCıkısBilgileriGetirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisCıkısBilgileriGetirBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisCıkısBilgileriGetirBtn.Location = new System.Drawing.Point(24, 556);
            this.girisCıkısBilgileriGetirBtn.Name = "girisCıkısBilgileriGetirBtn";
            this.girisCıkısBilgileriGetirBtn.Size = new System.Drawing.Size(170, 70);
            this.girisCıkısBilgileriGetirBtn.TabIndex = 6;
            this.girisCıkısBilgileriGetirBtn.Text = "Giriş - Çıkış Bilgileri";
            this.girisCıkısBilgileriGetirBtn.UseVisualStyleBackColor = true;
            this.girisCıkısBilgileriGetirBtn.Click += new System.EventHandler(this.girisCıkısBilgileriGetirBtn_Click);
            // 
            // rezervasyonIptalGetirBtn
            // 
            this.rezervasyonIptalGetirBtn.FlatAppearance.BorderSize = 0;
            this.rezervasyonIptalGetirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezervasyonIptalGetirBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonIptalGetirBtn.Location = new System.Drawing.Point(24, 465);
            this.rezervasyonIptalGetirBtn.Name = "rezervasyonIptalGetirBtn";
            this.rezervasyonIptalGetirBtn.Size = new System.Drawing.Size(170, 70);
            this.rezervasyonIptalGetirBtn.TabIndex = 5;
            this.rezervasyonIptalGetirBtn.Text = "Rezervasyon İptal";
            this.rezervasyonIptalGetirBtn.UseVisualStyleBackColor = true;
            this.rezervasyonIptalGetirBtn.Click += new System.EventHandler(this.rezervasyonIptalGetirBtn_Click);
            // 
            // odaSecenekleriGetirBtn
            // 
            this.odaSecenekleriGetirBtn.FlatAppearance.BorderSize = 0;
            this.odaSecenekleriGetirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaSecenekleriGetirBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSecenekleriGetirBtn.Location = new System.Drawing.Point(24, 375);
            this.odaSecenekleriGetirBtn.Name = "odaSecenekleriGetirBtn";
            this.odaSecenekleriGetirBtn.Size = new System.Drawing.Size(170, 70);
            this.odaSecenekleriGetirBtn.TabIndex = 4;
            this.odaSecenekleriGetirBtn.Text = "Oda Seçenekleri";
            this.odaSecenekleriGetirBtn.UseVisualStyleBackColor = true;
            this.odaSecenekleriGetirBtn.Click += new System.EventHandler(this.odaSecenekleriGetirBtn_Click);
            // 
            // musteriBilgileriGetirbtn
            // 
            this.musteriBilgileriGetirbtn.FlatAppearance.BorderSize = 0;
            this.musteriBilgileriGetirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriBilgileriGetirbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBilgileriGetirbtn.Location = new System.Drawing.Point(24, 193);
            this.musteriBilgileriGetirbtn.Name = "musteriBilgileriGetirbtn";
            this.musteriBilgileriGetirbtn.Size = new System.Drawing.Size(170, 70);
            this.musteriBilgileriGetirbtn.TabIndex = 2;
            this.musteriBilgileriGetirbtn.Text = "Müşteri Bilgileri";
            this.musteriBilgileriGetirbtn.UseVisualStyleBackColor = true;
            this.musteriBilgileriGetirbtn.Click += new System.EventHandler(this.musteriBilgileriGetirbtn_Click);
            // 
            // adminGirisGetirBtn
            // 
            this.adminGirisGetirBtn.FlatAppearance.BorderSize = 0;
            this.adminGirisGetirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminGirisGetirBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisGetirBtn.Location = new System.Drawing.Point(24, 105);
            this.adminGirisGetirBtn.Name = "adminGirisGetirBtn";
            this.adminGirisGetirBtn.Size = new System.Drawing.Size(170, 70);
            this.adminGirisGetirBtn.TabIndex = 1;
            this.adminGirisGetirBtn.Text = "Giriş Sayfası";
            this.adminGirisGetirBtn.UseVisualStyleBackColor = true;
            this.adminGirisGetirBtn.Click += new System.EventHandler(this.adminGirisGetirBtn_Click);
            // 
            // içerikPanel
            // 
            this.içerikPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.içerikPanel.Location = new System.Drawing.Point(200, 0);
            this.içerikPanel.Name = "içerikPanel";
            this.içerikPanel.Size = new System.Drawing.Size(1212, 703);
            this.içerikPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 703);
            this.Controls.Add(this.içerikPanel);
            this.Controls.Add(this.solPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Sistem";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.solPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel solPanel;
        private System.Windows.Forms.Button girisCıkısBilgileriGetirBtn;
        private System.Windows.Forms.Button rezervasyonIptalGetirBtn;
        private System.Windows.Forms.Button odaSecenekleriGetirBtn;
        private System.Windows.Forms.Button musteriBilgileriGetirbtn;
        private System.Windows.Forms.Button adminGirisGetirBtn;
        private System.Windows.Forms.Panel kayanPanel;
        private System.Windows.Forms.Button odaSecmeGetirBtn;
        private System.Windows.Forms.Button anaSayfaBtn;
        private System.Windows.Forms.Panel içerikPanel;
    }
}

