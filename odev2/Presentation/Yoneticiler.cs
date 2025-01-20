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

namespace odev2
{
    public partial class Yoneticiler : UserControl
    {

        private YoneticiBussiness _yoneticiBussiness;

        public Yoneticiler()
        {
            InitializeComponent();
            _yoneticiBussiness = new YoneticiBussiness();
        }


        private void Yonetici_Load(object sender, EventArgs e)
        {

        }

        private void sifremiUnuttumBtn_Click(object sender, EventArgs e)
        {
            SifreUnuttumForm sifreUnuttumForm = new SifreUnuttumForm();
            sifreUnuttumForm.ShowDialog();
        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiAlmaTxt.Text;
            string sifre = sifreAlmaTxt.Text;

            bool girisBasarili = _yoneticiBussiness.KullaniciGirisYap(kullaniciAdi, sifre);
            if (girisBasarili)
            {
                MessageBox.Show("Giriş başarılı!");
                // Burada başarılı giriş sonrası yapılacak işlemler eklenebilir
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void kullanıcıAdıAlmaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreAlmaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
