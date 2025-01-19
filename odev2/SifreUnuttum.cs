using odev2.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using odev2.DAL;

namespace odev2
{
    public partial class SifreUnuttum : UserControl
    {
        public SifreUnuttum()
        {
            InitializeComponent();
        }

        private void sifreUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void guvenlikKontrolBtn_Click(object sender, EventArgs e)
        {
            string secilenSoru = guvenlikSorusuCmbBox.SelectedItem?.ToString();
            string kullaniciCevabi = guvenlikCevabiTxt.Text;

            if (string.IsNullOrEmpty(secilenSoru) || string.IsNullOrEmpty(kullaniciCevabi))
            {
                MessageBox.Show("Lütfen bir soru seçin ve cevabınızı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            YoneticiBussiness yoneticiBusiness = new YoneticiBussiness();
            string sifre = yoneticiBusiness.SifreGetir(secilenSoru, kullaniciCevabi);

            if (!string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show($"Doğru cevap! Şifreniz: {sifre}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güvenlik sorusu veya cevabınız hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guvenlikSorusuCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            guvenlikSorusuCmbBox.Items.Add("Doğduğunuz şehir?");
            guvenlikSorusuCmbBox.Items.Add("İlk evcil hayvanınızın adı?");
            guvenlikSorusuCmbBox.Items.Add("En sevdiğiniz renk?");
        }
    }
}
