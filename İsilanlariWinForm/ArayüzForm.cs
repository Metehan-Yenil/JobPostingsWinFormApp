using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İsilanlariWinForm
{
    public partial class ArayüzForm : Form
    {


        public ArayüzForm(string kullanicidegisken)
        {
            InitializeComponent();


            // Kullanıcı adınızı ve token değerinizi burada belirtin
            string kullaniciAdi = kullanicidegisken;
            string dogruToken = "B2aJ6fTzYkx7C4W3dR8gS1hV9jM0nL5vEwFyKuHGmNl";

            // Veritabanından kullanıcının token değerini alın
            string kullaniciToken = GetKullaniciTokenFromDatabase(kullaniciAdi);

            // Kullanıcının token değeri doğruysa button22'yi görünür kıl, aksi halde gizle
            if (kullaniciToken == dogruToken)
            {
                bunifuThinButton22.Visible = true;
            }
            else
            {
                bunifuThinButton22.Visible = false;
            }
        }

        // Veritabanından kullanıcının token değerini almak için bir metot
        private string GetKullaniciTokenFromDatabase(string kullaniciAdi)
        {
            string token=null;
            // Veritabanı bağlantısını gerçekleştir
            using (MySqlConnection baglanti = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                baglanti.Open();

                // Kullanıcının token değeri sorgulanır ve token değişkenine atanır.
                
                string sorgu = "SELECT token FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi ";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                // Sorguyu çalıştır ve token değerini al
                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        token = reader.GetString("token");
                    }
                }

            }

            return token;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }
        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ilanEkle ilanekle = new ilanEkle(null);
            ilanekle.Show();
        }
    }
}
