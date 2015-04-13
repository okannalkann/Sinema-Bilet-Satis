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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }
        public static string Film_Adi;
        private void _127_saat_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("127 Saat Filmine Bilet Almak İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "127 Saat";
                BiletSatis bilet_satisi = new BiletSatis();
                bilet_satisi.Show();
            }
            else
            {
               
            }

        }

        private void arı_filmi_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Maya The Bee Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Maya The Bee";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
               
            }
            else
            {

            }
        }

        private void exodus_tanrılar_ve_krallar_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Exodus Tanrılar ve Krallar Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Exodus Tanrılar ve Krallar";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
            }
            else
            {

            }
        }

        private void grinin_elli_tonu_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Grinin Elli Tonu Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Grinin Elli Tonu";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
            }
            else
            {

            }
        }

        private void keskin_nisancı_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Keskin Nişancı Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Amerikan Keskin Sniper";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
            }
            else
            {

            }
        }

        private void superman_geri_donuyor_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Superman Geri Dönüyor Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Superman Geri Dönüyor";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
                
            }
            else
            {

            }
        }

        private void the_godfather_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("The Godfather Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "The GodFather";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
            }
            else
            {

            }
        }

        private void fight_club_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Fight Club Filmine bilet almak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Film_Adi = "Fight Club";
                BiletSatis bilet_satis = new BiletSatis();
                bilet_satis.Show();
                
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filmler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
