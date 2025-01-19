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
    public partial class AnaForm : Form
    {

        bool kontrol;
        int menu_width;
        public AnaForm()
        {
            InitializeComponent();
            kayanPanel.Height = anaSayfaBtn.Height;
            kayanPanel.Top = anaSayfaBtn.Top;
            anaSayfaCagır.BringToFront();
            //solPanel.Width = 50;
        }

        //bool panelAcilmisMi = false;
        private void hamburgerMenuSimgeBtn_Click(object sender, EventArgs e)
        {
            
            //if (solPanel.Width == 50) // Eğer açık genişlik 200 piksel ise
            //{
            //    solPanel.Width = 200; // Paneli daralt
            //}
            //else
            //{
            //    solPanel.Width = 50; // Paneli genişlet
            //}
            //solPanel.Refresh();
        }

        private void panelIcerik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void musteriBilgileriGetirbtn_Click(object sender, EventArgs e)
        {
            kayanPanel.Height = musteriBilgileriGetirbtn.Height;
            kayanPanel.Top = musteriBilgileriGetirbtn.Top;
            musteriBilgileriCagır.BringToFront();
        }

        private void adminGirisGetirBtn_Click(object sender, EventArgs e)
        {
            kayanPanel.Height = adminGirisGetirBtn.Height;
            kayanPanel.Top = adminGirisGetirBtn.Top;
            yoneticilerCagır.BringToFront();
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            kayanPanel.Height = anaSayfaBtn.Height;
            kayanPanel.Top = anaSayfaBtn.Top;
            anaSayfaCagır.BringToFront();
        }

        private void odaSecmeGetirBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
