using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using MySql.Data.MySqlClient;
//using System.Data.SqlClient;

namespace İsilanlariWinForm
{
    

    public partial class Form1 : Form
    {
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";


        private void GirisYap(string kullaniciAdi, string sifre)
        {
            // Kullanıcıyı veritabanında ara ve eşleşmeyi kontrol et
            bool dogrulandi = KullaniciDogrula(kullaniciAdi, sifre);

            if (dogrulandi)
            {
                MessageBox.Show("Giriş başarılı!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            bool dogrulandi = false;

            // Veritabanı bağlantısını gerçekleştir
            using (MySqlConnection baglanti = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                baglanti.Open();

                // Kullanıcıyı veritabanında arama sorgusu
                string sorgu = "SELECT COUNT(*) FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    object result = komut.ExecuteScalar();
                    int kullaniciSayisi = 0;

                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out kullaniciSayisi);
                    }


                    if (kullaniciSayisi > 0)
                    {
                        dogrulandi = true;
                    }
                }
            }

            return dogrulandi;
        }


        public Form1()
        {
             InitializeComponent();
            connection = new MySqlConnection(connectionString);
            Label label = new Label();

            





        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = KullanıcıGirisText.Text;
            string sifre = ParolaGirisText.Text;

            GirisYap(kullaniciAdi, sifre);
        }

        private void personelKayıtbtn_Click(object sender, EventArgs e)
        {
            kayıtForm kayıtform = new kayıtForm();
            kayıtform.Show();
        }

        private void KullanıcıGirisText_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
