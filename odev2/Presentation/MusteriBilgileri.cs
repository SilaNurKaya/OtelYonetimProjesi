using MySql.Data.MySqlClient;
using odev2.Bussines;
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
using static odev2.EntityLayer.MusteriEntityLayer;

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
            musteriOdemeTuruCmbBox.Items.Add("Nakit");
            musteriOdemeTuruCmbBox.Items.Add("Kart");
            musteriOdemeTuruCmbBox.Items.Add("Havale");

            musteriOdemeTuruDuzenlemeCmbBox.Items.Add("Nakit");
            musteriOdemeTuruDuzenlemeCmbBox.Items.Add("Kart");
            musteriOdemeTuruDuzenlemeCmbBox.Items.Add("Havale");
        }

        private void musteriSilmeUyarıLbl_Click(object sender, EventArgs e)
        {

        }

        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki verileri alıyoruz
                Musteri musteri = new Musteri
                {
                    AdSoyad = musteriAdiSoyadiTxt.Text,
                    TelNo = musteriTelNosuTxt.Text,
                    TcNo = musteriTcNosuTxt.Text,
                    OdemeTuru = musteriOdemeTuruCmbBox.Text
                };

                // Business katmanına gönderiyoruz
                MusteriBussiness business = new MusteriBussiness();
                business.MusteriEkle(musteri);

                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriyoruz
                MessageBox.Show("Müşteri eklenirken hata oluştu." + ex.Message);
            }
        }

        private void musteriDuzenlemeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki verileri alıyoruz
                Musteri musteri = new Musteri
                {
                    AdSoyad = musteriAdiSoyadiDuzenlemeTxt.Text,
                    TelNo = musteriTelNosuDuzenlemeTxt.Text,
                    TcNo = musteriTcNosuDuzenlemeTxt.Text,
                    OdemeTuru = musteriOdemeTuruDuzenlemeCmbBox.Text
                };

                // Business katmanına gönderiyoruz
                MusteriBussiness business = new MusteriBussiness();
                business.MusteriGuncelle(musteri);

                // Başarı mesajı
                MessageBox.Show("Müşteri başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriyoruz
                MessageBox.Show("Müşteri güncellenirken hata oluştu: " + ex.Message);
            }

        }

        private void musteriSilmeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki TC Kimlik Numarasını alıyoruz
                string tcNo = musteriTcNosuSilmeTxt.Text;

                // Business katmanına gönderiyoruz
                MusteriBussiness business = new MusteriBussiness();
                business.MusteriSil(tcNo);

                // Başarı mesajı
                MessageBox.Show("Müşteri başarıyla silindi.");
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriyoruz
                MessageBox.Show("Müşteri silinirken hata oluştu: " + ex.Message);
            }

        }
    }
}
