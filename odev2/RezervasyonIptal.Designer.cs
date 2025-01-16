namespace odev2
{
    partial class RezervasyonIptal
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
            this.rezervasyonIptalGrpBox = new System.Windows.Forms.GroupBox();
            this.rezervasyonSilmeGrpBox = new System.Windows.Forms.GroupBox();
            this.iptalNedeniLbl = new System.Windows.Forms.Label();
            this.iptalNedeniTxt = new System.Windows.Forms.TextBox();
            this.rezervasyonSilmeBtn = new System.Windows.Forms.Button();
            this.musteriTcNosuRezSilmeTxt = new System.Windows.Forms.TextBox();
            this.musteriTcNosuRezSilLbl = new System.Windows.Forms.Label();
            this.rezervasyonGoruntuleGrpBox = new System.Windows.Forms.GroupBox();
            this.rezervasyonListeleBtn = new System.Windows.Forms.Button();
            this.rezervasyonListesiDgv = new System.Windows.Forms.DataGridView();
            this.rezervasyonIptalGrpBox.SuspendLayout();
            this.rezervasyonSilmeGrpBox.SuspendLayout();
            this.rezervasyonGoruntuleGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonListesiDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervasyonIptalGrpBox
            // 
            this.rezervasyonIptalGrpBox.Controls.Add(this.rezervasyonSilmeGrpBox);
            this.rezervasyonIptalGrpBox.Controls.Add(this.rezervasyonGoruntuleGrpBox);
            this.rezervasyonIptalGrpBox.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonIptalGrpBox.Location = new System.Drawing.Point(0, 0);
            this.rezervasyonIptalGrpBox.Name = "rezervasyonIptalGrpBox";
            this.rezervasyonIptalGrpBox.Size = new System.Drawing.Size(1235, 700);
            this.rezervasyonIptalGrpBox.TabIndex = 0;
            this.rezervasyonIptalGrpBox.TabStop = false;
            this.rezervasyonIptalGrpBox.Text = "Rezervasyon İptal";
            this.rezervasyonIptalGrpBox.Enter += new System.EventHandler(this.rezervasyonIptalGrpBox_Enter);
            // 
            // rezervasyonSilmeGrpBox
            // 
            this.rezervasyonSilmeGrpBox.Controls.Add(this.iptalNedeniLbl);
            this.rezervasyonSilmeGrpBox.Controls.Add(this.iptalNedeniTxt);
            this.rezervasyonSilmeGrpBox.Controls.Add(this.rezervasyonSilmeBtn);
            this.rezervasyonSilmeGrpBox.Controls.Add(this.musteriTcNosuRezSilmeTxt);
            this.rezervasyonSilmeGrpBox.Controls.Add(this.musteriTcNosuRezSilLbl);
            this.rezervasyonSilmeGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonSilmeGrpBox.Location = new System.Drawing.Point(751, 49);
            this.rezervasyonSilmeGrpBox.Name = "rezervasyonSilmeGrpBox";
            this.rezervasyonSilmeGrpBox.Size = new System.Drawing.Size(431, 564);
            this.rezervasyonSilmeGrpBox.TabIndex = 1;
            this.rezervasyonSilmeGrpBox.TabStop = false;
            this.rezervasyonSilmeGrpBox.Text = "Rezervasyon Sil";
            // 
            // iptalNedeniLbl
            // 
            this.iptalNedeniLbl.AutoSize = true;
            this.iptalNedeniLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalNedeniLbl.Location = new System.Drawing.Point(22, 147);
            this.iptalNedeniLbl.Name = "iptalNedeniLbl";
            this.iptalNedeniLbl.Size = new System.Drawing.Size(132, 26);
            this.iptalNedeniLbl.TabIndex = 4;
            this.iptalNedeniLbl.Text = "İptal Nedeni:";
            // 
            // iptalNedeniTxt
            // 
            this.iptalNedeniTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalNedeniTxt.Location = new System.Drawing.Point(27, 176);
            this.iptalNedeniTxt.Multiline = true;
            this.iptalNedeniTxt.Name = "iptalNedeniTxt";
            this.iptalNedeniTxt.Size = new System.Drawing.Size(378, 290);
            this.iptalNedeniTxt.TabIndex = 3;
            // 
            // rezervasyonSilmeBtn
            // 
            this.rezervasyonSilmeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonSilmeBtn.Location = new System.Drawing.Point(151, 483);
            this.rezervasyonSilmeBtn.Name = "rezervasyonSilmeBtn";
            this.rezervasyonSilmeBtn.Size = new System.Drawing.Size(139, 60);
            this.rezervasyonSilmeBtn.TabIndex = 2;
            this.rezervasyonSilmeBtn.Text = "Rezervasyon Sil";
            this.rezervasyonSilmeBtn.UseVisualStyleBackColor = true;
            // 
            // musteriTcNosuRezSilmeTxt
            // 
            this.musteriTcNosuRezSilmeTxt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTcNosuRezSilmeTxt.Location = new System.Drawing.Point(27, 84);
            this.musteriTcNosuRezSilmeTxt.Name = "musteriTcNosuRezSilmeTxt";
            this.musteriTcNosuRezSilmeTxt.Size = new System.Drawing.Size(378, 34);
            this.musteriTcNosuRezSilmeTxt.TabIndex = 1;
            // 
            // musteriTcNosuRezSilLbl
            // 
            this.musteriTcNosuRezSilLbl.AutoSize = true;
            this.musteriTcNosuRezSilLbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTcNosuRezSilLbl.Location = new System.Drawing.Point(22, 46);
            this.musteriTcNosuRezSilLbl.Name = "musteriTcNosuRezSilLbl";
            this.musteriTcNosuRezSilLbl.Size = new System.Drawing.Size(81, 26);
            this.musteriTcNosuRezSilLbl.TabIndex = 0;
            this.musteriTcNosuRezSilLbl.Text = "TC No:";
            // 
            // rezervasyonGoruntuleGrpBox
            // 
            this.rezervasyonGoruntuleGrpBox.Controls.Add(this.rezervasyonListeleBtn);
            this.rezervasyonGoruntuleGrpBox.Controls.Add(this.rezervasyonListesiDgv);
            this.rezervasyonGoruntuleGrpBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonGoruntuleGrpBox.Location = new System.Drawing.Point(54, 49);
            this.rezervasyonGoruntuleGrpBox.Name = "rezervasyonGoruntuleGrpBox";
            this.rezervasyonGoruntuleGrpBox.Size = new System.Drawing.Size(672, 564);
            this.rezervasyonGoruntuleGrpBox.TabIndex = 0;
            this.rezervasyonGoruntuleGrpBox.TabStop = false;
            this.rezervasyonGoruntuleGrpBox.Text = "Rezervasyonlar";
            // 
            // rezervasyonListeleBtn
            // 
            this.rezervasyonListeleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonListeleBtn.Location = new System.Drawing.Point(517, 46);
            this.rezervasyonListeleBtn.Name = "rezervasyonListeleBtn";
            this.rezervasyonListeleBtn.Size = new System.Drawing.Size(126, 488);
            this.rezervasyonListeleBtn.TabIndex = 1;
            this.rezervasyonListeleBtn.Text = "Listele";
            this.rezervasyonListeleBtn.UseVisualStyleBackColor = true;
            // 
            // rezervasyonListesiDgv
            // 
            this.rezervasyonListesiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervasyonListesiDgv.Location = new System.Drawing.Point(22, 46);
            this.rezervasyonListesiDgv.Name = "rezervasyonListesiDgv";
            this.rezervasyonListesiDgv.RowHeadersWidth = 51;
            this.rezervasyonListesiDgv.RowTemplate.Height = 24;
            this.rezervasyonListesiDgv.Size = new System.Drawing.Size(478, 488);
            this.rezervasyonListesiDgv.TabIndex = 0;
            // 
            // RezervasyonIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rezervasyonIptalGrpBox);
            this.Name = "RezervasyonIptal";
            this.Size = new System.Drawing.Size(1250, 700);
            this.Load += new System.EventHandler(this.RezervasyonIptal_Load);
            this.rezervasyonIptalGrpBox.ResumeLayout(false);
            this.rezervasyonSilmeGrpBox.ResumeLayout(false);
            this.rezervasyonSilmeGrpBox.PerformLayout();
            this.rezervasyonGoruntuleGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonListesiDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rezervasyonIptalGrpBox;
        private System.Windows.Forms.GroupBox rezervasyonGoruntuleGrpBox;
        private System.Windows.Forms.DataGridView rezervasyonListesiDgv;
        private System.Windows.Forms.Button rezervasyonListeleBtn;
        private System.Windows.Forms.GroupBox rezervasyonSilmeGrpBox;
        private System.Windows.Forms.Button rezervasyonSilmeBtn;
        private System.Windows.Forms.TextBox musteriTcNosuRezSilmeTxt;
        private System.Windows.Forms.Label musteriTcNosuRezSilLbl;
        private System.Windows.Forms.Label iptalNedeniLbl;
        private System.Windows.Forms.TextBox iptalNedeniTxt;
    }
}
