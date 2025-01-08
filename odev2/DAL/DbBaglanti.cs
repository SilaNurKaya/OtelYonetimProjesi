using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2.DAL
{
    class DbBaglanti
    {
        public static MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti =
                new MySqlConnection("Server=172.21.54.253;Database=25_132330013;Uid=25_132330013;Pwd=!nif.ogr13KA;");
            baglanti.Open();
            return baglanti;
        }
    }
}
