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
    public partial class YonetimFormu : Form
    {
        public YonetimFormu()
        {
            InitializeComponent();
        }
        private void YonetimFormu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SaatGosterici.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaatGosterici_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
        }

    }
}
