using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sinema_bilet_satisi_EN_SON
{
    public partial class Baslangıc_Formu : Form
    {
        public Baslangıc_Formu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        public void Baslangıc_Formu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            SaatGosterici.Interval = 50;
            con.ConnectionString = "Data Source=OKAN-BILGISAYAR;Initial Catalog=EnSonSinemaBiletSatis;Integrated Security=True";
            SaatGosterici.Start();
        }
        
        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            try
            {
               
                LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
                con.Open();
                SqlParameter prm1 = new SqlParameter("@P1", txtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("@P2", TxtSifre.Text);
                string sql = "select * FROM Personeller WHERE k_adi=@P1 and sifre=@P2";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("Giriş Başarılı.. Hoşgeldin " + txtKullaniciAdi.Text);
                    Form Filmler = new Filmler();
                    Filmler.ShowDialog();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                } con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaatGosterici_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
        }

        private void btnPersonelCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYonetımCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYonetımGırıs_Click(object sender, EventArgs e)
        {
            try
            {
                LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
                con.Open();
                SqlParameter prm1 = new SqlParameter("@P1", txtYonetimKullanıcıAdı.Text);
                SqlParameter prm2 = new SqlParameter("@P2", txtYonetimSifre.Text);
                string sql = "select * FROM Yonetim_Calısanı WHERE yonetim_k_adi=@P1 and yonetim_sifre=@P2";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş Başarılı.. Hoşgeldin " + txtKullaniciAdi.Text);
                    Form YonetimFormu = new YonetimFormu();
                    YonetimFormu.ShowDialog();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
