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
using static odev2.EntityLayer.RezervasyonEntityLayer;

namespace odev2
{
    public partial class RezervasyonIptal : UserControl
    {
        public RezervasyonIptal()
        {
            InitializeComponent();
        }

        private void rezervasyonIptalGrpBox_Enter(object sender, EventArgs e)
        {

        }

        //buraya ıd gözükmesin ve liste kendiliğinden gelsin kodları yazılacak dokümanda var
        private void RezervasyonIptal_Load(object sender, EventArgs e)
        {
            RezervasyonDAL rezervasyonDal = new RezervasyonDAL();
            List<Rezervasyon> rezervasyonlar = rezervasyonDal.RezervasyonListele();
            rezervasyonListesiDgv.DataSource = rezervasyonlar;
        }
    }
}
