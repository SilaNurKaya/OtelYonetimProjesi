using MySql.Data.MySqlClient;
using odev2.DAL;
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
    public partial class MusteriBilgileri : UserControl
    {
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        private void musteriBilgileriAlmaGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void musteriSilmeUyarıLbl_Click(object sender, EventArgs e)
        {

        }

        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // DbBaglanti sınıfından mevcut bağlantıyı çağırıyoruz
                MySqlConnection baglanti = DbBaglanti.BaglantiGetir();

                // SQL komutunu tanımlıyoruz: Müşteri bilgilerini eklemek için
                string query = "INSERT INTO musteri (musteri_adi_soyadi, musteri_telNo, musteri_tcNo, musteri_odemeTuru) " +
                               "VALUES (@AdiSoyadi, @TelNo, @TcNo, @OdemeTuru)";

                MySqlCommand komut = new MySqlCommand(query, baglanti);

                // Parametreleri ekliyoruz
                komut.Parameters.AddWithValue("@AdiSoyadi", musteriAdiSoyadiTxt.Text);
                komut.Parameters.AddWithValue("@TelNo", musteriTelNosuTxt.Text);
                komut.Parameters.AddWithValue("@TcNo", musteriTcNosuTxt.Text);
                komut.Parameters.AddWithValue("@OdemeTuru", musteriOdemeTuruTxt.Text);

                // Bağlantıyı açıyoruz
                baglanti.Open();

                // Komutu çalıştırarak müşteri ekliyoruz
                komut.ExecuteNonQuery();

                // Başarı mesajını gösteriyoruz
                MessageBox.Show("Müşteri başarıyla eklendi.");

                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
            catch
            {
                // Hata durumunda uyarı mesajı gösteriyoruz
                MessageBox.Show("Müşteri ekleneirken bir sorun oluştu.");
            }
        }
    }
}
