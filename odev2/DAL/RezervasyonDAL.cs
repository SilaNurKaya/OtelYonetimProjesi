using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.DAL
{
    public class RezervasyonDAL
    {
        public void RezervasyonOlustur(int musteriId, int odaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            DbBaglanti dbBaglanti = new DbBaglanti();

            using (MySqlConnection connection = DbBaglanti.BaglantiGetir())
            {
                string query = "INSERT INTO musteri (musteri_adi_soyadi, musteri_telNo, musteri_tcNo, musteri_odemeTuru) VALUES (@AdiSoyadi, @TelNo, @TcNo, @OdemeTuru)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MusteriId", musteriId);
                command.Parameters.AddWithValue("@OdaId", odaId);
                command.Parameters.AddWithValue("@GirisTarihi", girisTarihi);
                command.Parameters.AddWithValue("@CıkısTarihi", cikisTarihi);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("rezervasyon oluşturulurken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
