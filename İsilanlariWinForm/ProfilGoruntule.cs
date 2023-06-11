using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İsilanlariWinForm
{
    public partial class ProfilGoruntule : UserControl
    {
        MySqlConnection connection;


        private string kullaniciAdi;

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public ProfilGoruntule()
        {
            InitializeComponent();
            
   
            
        }

       private void ProfilGoruntule_Load(object sender, EventArgs e)
        {

            string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";
            // Veritabanı bağlantısı
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // SqlCommand nesnesini kullanarak veritabanı sorgularını çalıştır
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    //kullanici_adi
                    command.CommandText = "SELECT kullanici_adi FROM kullanicilar WHERE kullanici_adi=@kullaniciAdi;";
                    string kullaniciadi=(string)command.ExecuteScalar();
                    listViewKullaniciadi.Items.Add(new ListViewItem(kullaniciadi));

                    // İsim
                    command.CommandText = "SELECT isim FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi;";
                    string isim = (string)command.ExecuteScalar();
                    listView5.Items.Add(new ListViewItem(isim));
                    

                    // Soyisim
                    command.CommandText = "SELECT soyisim FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string soyisim = (string)command.ExecuteScalar();
                    listViewSoyad.Items.Add(new ListViewItem(soyisim));
                    
                    // Şifre
                    command.CommandText = "SELECT sifre FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string sifre = (string)command.ExecuteScalar();
                    listViewSifre.Items.Add(new ListViewItem(sifre));

                    // E-posta
                    command.CommandText = "SELECT email FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string email = (string)command.ExecuteScalar();
                    listViewEmail.Items.Add(new ListViewItem(email));
                    

                    // Telefon Numarası
                    command.CommandText = "SELECT tel_no FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string telefon = (string)command.ExecuteScalar();
                    listViewTelNo.Items.Add(new ListViewItem(telefon));

                    // Adres
                    command.CommandText = "SELECT adresi FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string adres = (string)command.ExecuteScalar();
                    listViewAdres.Items.Add(new ListViewItem(adres));

                    // Eğitim Durumu
                    command.CommandText = "SELECT egitim_durumu FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    string egitimDurumu = (string)command.ExecuteScalar();
                    listViewEgitimDurumu.Items.Add(new ListViewItem(egitimDurumu));

                    //Doğum tarihi
                    command.CommandText = "SELECT dogum_tarihi FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    DateTime dogumTarihi = (DateTime)command.ExecuteScalar();
                    listViewDogumtarihi.Items.Add(new ListViewItem(dogumTarihi.ToString()));



                    // Mezun Olunan Okul
                    command.CommandText = "SELECT mezun_olan_okul FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                     string mezunOkul = (string)command.ExecuteScalar();
                     listView10.Items.Add(new ListViewItem(mezunOkul));

                     // Bölüm
                     command.CommandText = "SELECT bolum_fakulte FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                     string bolum = (string)command.ExecuteScalar();
                     listView11.Items.Add(new ListViewItem(bolum));

                     // Yetenekler
                     command.CommandText = "SELECT programlama_dilleri, teknik_beceriler, iletisim_becerileri, liderlik_yetenekleri, yabanci_diller FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                     using (MySqlDataReader reader = command.ExecuteReader())
                     {
                         if (reader.Read())
                         {
                             string programlamaDilleri = reader["programlama_dilleri"].ToString();
                             listView12.Items.Add(new ListViewItem(programlamaDilleri));

                             string teknikBeceriler = reader["teknik_beceriler"].ToString();
                             listView1.Items.Add(new ListViewItem(teknikBeceriler));

                             string iletisimBecerileri = reader["iletisim_becerileri"].ToString();
                             listView2.Items.Add(new ListViewItem(iletisimBecerileri));

                             string liderlikYetenekleri = reader["liderlik_yetenekleri"].ToString();
                             listView3.Items.Add(new ListViewItem(liderlikYetenekleri));

                             string yabanciDiller = reader["yabanci_diller"].ToString();
                             listView4.Items.Add(new ListViewItem(yabanciDiller));
                         }
                     }    



                }
            }


        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
