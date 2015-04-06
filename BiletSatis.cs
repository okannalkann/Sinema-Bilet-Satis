using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinema_bilet_satisi_EN_SON
{
    public partial class BiletSatis : Form
    {
        public BiletSatis()
        {
            InitializeComponent();
            
        }
        private void BiletSatis_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label17.Text = Filmler.Film_Adi;
            txtFilmAdi.Text = Filmler.Film_Adi;
            txtFilmAdi.ReadOnly = true;
            SaatGosterici.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaatGosterici_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
