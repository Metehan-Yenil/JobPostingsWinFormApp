using İsilanlariWinForm.Models;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace İsilanlariWinForm
{
    public partial class ArayüzForm : Form
    {
        private string userid;
        private string yenikullanici;
        
        private ProfilGoruntule profilGoruntule;
        private ProfilDuzenle profilDuzenle;
        //private AramaMotoru aramaMotoru;
        // BasvurulariGoruntule basvurulariGoruntule;


        public string UserID
        {
            get { return userid; }
            set { userid = value; }
        }

        public ArayüzForm(string kullanicidegisken)
        {
            InitializeComponent();


            // Kullanıcı adınızı ve token değerinizi burada belirtin
            string kullaniciAdi = kullanicidegisken;
            string dogruToken = "B2aJ6fTzYkx7C4W3dR8gS1hV9jM0nL5vEwFyKuHGmNl";
            yenikullanici=kullanicidegisken;
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
            string userid = yenikullanici;
            ilanEkle ilanekle = new ilanEkle(userid);
            ilanekle.Show();
            ilanekle.UserID = userid;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            
            // Button 1'e tıklandığında gösterilecek Panelgoruntule'yi oluştur ve Panel içine yerleştir
            if (profilGoruntule == null)
            {
                profilGoruntule = new ProfilGoruntule()
                {
                    Dock = DockStyle.Fill
                };
            }

           
            ProfilGoruntule profilGoruntuleForm = new ProfilGoruntule();
            profilGoruntuleForm.KullaniciAdi = yenikullanici; // yenikullanici, ArayüzForm'da kullaniciAdi değeridir
            profilGoruntuleForm.Dock = DockStyle.Fill;

            // Panel içindeki mevcut UserControl'ü kaldır
            panel2.Controls.Clear();

            // Yeni UserControl'ü Panel içine yerleştir
            panel2.Controls.Add(profilGoruntuleForm);
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ArayüzForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            // Button a tıklandığında gösterilecek Panelduzenle'yi oluştur ve Panel içine yerleştir
            if (profilDuzenle == null)
            {
                profilDuzenle = new ProfilDuzenle()
                {
                    Dock = DockStyle.Fill
                };
            }


            ProfilDuzenle profilDuzenleForm = new ProfilDuzenle();
            profilDuzenleForm.KullaniciAdi = yenikullanici; // yenikullanici, ArayüzForm'da kullaniciAdi değeridir
            profilDuzenleForm.Dock = DockStyle.Fill;

            // Panel içindeki mevcut UserControl'ü kaldır
            panel2.Controls.Clear();

            // Yeni UserControl'ü Panel içine yerleştir
            panel2.Controls.Add(profilDuzenleForm);

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = bunifuTextbox1.text;
            


            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();

                // İlan başlıklarını ara ve eşleşenleri ekrana getir
                string query = "SELECT ilan_basligi FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@aranan", aramaKelimesi);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        string eşleşenIlanlar = "";
                        while (reader.Read())
                        {
                            string ilanBasligi = reader.GetString("ilan_basligi");
                            eşleşenIlanlar += ilanBasligi + "\n";
                        }

                        if (!string.IsNullOrEmpty(eşleşenIlanlar))
                        {
                            MessageBox.Show("Eşleşen ilanlar:\n" + eşleşenIlanlar);
                        string kaynakString = bunifuTextbox1.text;

                        // Hedef formdaki string değişkenine atama yap
                        İlanGörüntüle ilanGörüntüle = new İlanGörüntüle();
                        /*

                        if (ilanGörüntüle == null)
                        {
                            ilanGörüntüle = new İlanGörüntüle()
                            {
                                Dock = DockStyle.Fill
                            };
                        }
                      */
                        panel2.Controls.Clear();

                         ilanGörüntüle.HedefString = kaynakString;

                         // Yeni UserControl'ü Panel içine yerleştir 
                        panel2.Controls.Add(ilanGörüntüle);
                        ilanGörüntüle.Dock = DockStyle.Fill;
                        ilanGörüntüle.Show();
                        }
                        else
                        {
                            MessageBox.Show("Eşleşen ilan bulunamadı.");
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    connection.Close();
                }

            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            BasvuruGörüntüle basvuruGörüntüle = new BasvuruGörüntüle();
            panel2.Controls.Clear();
            panel2.Show();
        }
    }
}
