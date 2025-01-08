namespace odev2
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
            System.Windows.Forms.Panel panelIcerik;
            this.solPanel = new System.Windows.Forms.Panel();
            this.hamburgerMenuSimgeBtn = new System.Windows.Forms.Button();
            panelIcerik = new System.Windows.Forms.Panel();
            this.solPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // solPanel
            // 
            this.solPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.solPanel.Controls.Add(this.hamburgerMenuSimgeBtn);
            this.solPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solPanel.Location = new System.Drawing.Point(0, 0);
            this.solPanel.Name = "solPanel";
            this.solPanel.Size = new System.Drawing.Size(50, 700);
            this.solPanel.TabIndex = 1;
            // 
            // hamburgerMenuSimgeBtn
            // 
            this.hamburgerMenuSimgeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hamburgerMenuSimgeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamburgerMenuSimgeBtn.Location = new System.Drawing.Point(0, 0);
            this.hamburgerMenuSimgeBtn.Name = "hamburgerMenuSimgeBtn";
            this.hamburgerMenuSimgeBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hamburgerMenuSimgeBtn.Size = new System.Drawing.Size(50, 40);
            this.hamburgerMenuSimgeBtn.TabIndex = 0;
            this.hamburgerMenuSimgeBtn.Text = "☰";
            this.hamburgerMenuSimgeBtn.UseVisualStyleBackColor = true;
            this.hamburgerMenuSimgeBtn.Click += new System.EventHandler(this.hamburgerMenuSimgeBtn_Click);
            // 
            // panelIcerik
            // 
            panelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            panelIcerik.Location = new System.Drawing.Point(50, 0);
            panelIcerik.Name = "panelIcerik";
            panelIcerik.Size = new System.Drawing.Size(1250, 700);
            panelIcerik.TabIndex = 2;
            panelIcerik.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIcerik_Paint);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(panelIcerik);
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
        private System.Windows.Forms.Button hamburgerMenuSimgeBtn;
    }
}

