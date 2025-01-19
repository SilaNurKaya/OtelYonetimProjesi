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
    public partial class SifreUnuttumForm : Form
    {

        public SifreUnuttumForm()
        {
            SifreUnuttum sifreUnuttumUserControl = new SifreUnuttum();
            this.Controls.Add(sifreUnuttumUserControl);
            sifreUnuttumUserControl.Dock = DockStyle.Fill;
        }

        private void SifreUnuttumForm_Load(object sender, EventArgs e)
        {

        }
    }
}
