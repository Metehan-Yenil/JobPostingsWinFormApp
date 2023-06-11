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
    public partial class ProfilDuzenle : UserControl
    {
        MySqlConnection connection;


        private string kullaniciAdi;

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        public ProfilDuzenle()
        {
            InitializeComponent();
        }

        private void ProfilDuzenle_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
                    // İsim güncelleme
                    string isim = richTextBoxAd.Text;
                    if (!string.IsNullOrEmpty(isim))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET isim = @isim WHERE kullanici_adi = @kullaniciAdiIsim;";
                        command.Parameters.AddWithValue("@isim", isim);
                        command.Parameters.AddWithValue("@kullaniciAdiIsim", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }
                    //şifre güncelle
                    string sifre = richTextBoxsifre.Text;
                    if (!string.IsNullOrEmpty(sifre))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET sifre = @sifre WHERE kullanici_adi = @kullaniciAdiSifre;";
                        command.Parameters.AddWithValue("@sifre", sifre);
                        command.Parameters.AddWithValue("@kullaniciAdiSifre", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Soyisim güncelleme
                    string soyisim = richTextBoxSoyad.Text;
                    if (!string.IsNullOrEmpty(soyisim))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET soyisim = @soyisim WHERE kullanici_adi = @kullaniciAdiSoyisim;";
                        command.Parameters.AddWithValue("@soyisim", soyisim);
                        command.Parameters.AddWithValue("@kullaniciAdiSoyisim", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Email güncelleme
                    string email = richTextBoxemail.Text;
                    if (!string.IsNullOrEmpty(email))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET email = @email WHERE kullanici_adi = @kullaniciAdiEmail;";
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@kullaniciAdiEmail", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Adres güncelleme
                    string adres = richTextBoxadres.Text;
                    if (!string.IsNullOrEmpty(adres))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET adresi = @adres WHERE kullanici_adi = @kullaniciAdiAdres;";
                        command.Parameters.AddWithValue("@adres", adres);
                        command.Parameters.AddWithValue("@kullaniciAdiAdres", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }
                    // Telefon numarası güncelleme
                    string telNo = richTextBoxTelno.Text;
                    if (!string.IsNullOrEmpty(telNo))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET tel_no = @telNo WHERE kullanici_adi = @kullaniciAdiTelno;";
                        command.Parameters.AddWithValue("@telNo", telNo);
                        command.Parameters.AddWithValue("@kullaniciAdiTelno", kullaniciAdi);
                        command.ExecuteNonQuery();
                    }

                    // Eğitim Durumu güncelleme
                    string egitimDurumu = richTextBoxegitimdurumu.Text;
                    if (egitimDurumu != null)
                    {
                        command.CommandText = "UPDATE Kullanicilar SET egitim_durumu = @egitimDurumu WHERE kullanici_adi = @kullaniciAdiEgitimDurumu;";
                        command.Parameters.AddWithValue("@egitimDurumu", egitimDurumu);
                        command.Parameters.AddWithValue("@kullaniciAdiEgitimDurumu", kullaniciAdi);
                        command.ExecuteNonQuery();
                    }
                   

                    // Mezun Olunan Okullar güncelleme
                    string mezunOkullar = richTextBoxmezunolunanokul.Text;
                    if (!string.IsNullOrEmpty(mezunOkullar))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET mezun_olan_okul = @mezunOkullar WHERE kullanici_adi = @kullaniciAdiMezunOkullar;";
                        command.Parameters.AddWithValue("@mezunOkullar", mezunOkullar);
                        command.Parameters.AddWithValue("@kullaniciAdiMezunOkullar", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Bölüm/Fakülte güncelleme
                    string bolumFakulte = richTextBoxbolum.Text;
                    if (!string.IsNullOrEmpty(bolumFakulte))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET bolum_fakulte = @bolumFakulte WHERE kullanici_adi = @kullaniciAdiBolumFakulte;";
                        command.Parameters.AddWithValue("@bolumFakulte", bolumFakulte);
                        command.Parameters.AddWithValue("@kullaniciAdiBolumFakulte", kullaniciAdi);
                        command.ExecuteNonQuery();
                    }
                  

                    // Programlama Dilleri güncelleme
                    string programlamaDilleri = richTextBoxprogramlamadilleri.Text;
                    if (!string.IsNullOrEmpty(programlamaDilleri))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET programlama_dilleri = @programlamaDilleri WHERE kullanici_adi = @kullaniciAdiProgramlamaDilleri;";
                        command.Parameters.AddWithValue("@programlamaDilleri", programlamaDilleri);
                        command.Parameters.AddWithValue("@kullaniciAdiProgramlamaDilleri", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Teknik Beceriler güncelleme
                    string teknikBeceriler = richTextBoxteknikbeceriler.Text;
                    if (!string.IsNullOrEmpty(teknikBeceriler))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET teknik_beceriler = @teknikBeceriler WHERE kullanici_adi = @kullaniciAdiTeknikBeceriler;";
                        command.Parameters.AddWithValue("@teknikBeceriler", teknikBeceriler);
                        command.Parameters.AddWithValue("@kullaniciAdiTeknikBeceriler", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // İletişim Becerileri güncelleme
                    string iletisimBecerileri = richTextBoxiletisimbeceri.Text;
                    if (!string.IsNullOrEmpty(iletisimBecerileri))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET iletisim_becerileri = @iletisimBecerileri WHERE kullanici_adi = @kullaniciAdiIletisimBecerileri;";
                        command.Parameters.AddWithValue("@iletisimBecerileri", iletisimBecerileri);
                        command.Parameters.AddWithValue("@kullaniciAdiIletisimBecerileri", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Liderlik Yetenekleri güncelleme
                    string liderlikYetenekleri = richTextBoxliderlikyetenekleri.Text;
                    if (!string.IsNullOrEmpty(liderlikYetenekleri))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET liderlik_yetenekleri = @liderlikYetenekleri WHERE kullanici_adi = @kullaniciAdiLiderlikYetenekleri;";
                        command.Parameters.AddWithValue("@liderlikYetenekleri", liderlikYetenekleri);
                        command.Parameters.AddWithValue("@kullaniciAdiLiderlikYetenekleri", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }

                    // Yabancı Diller güncelleme
                    string yabanciDiller = richTextBoxyabancıdiller.Text;
                    if (!string.IsNullOrEmpty(yabanciDiller))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET yabanci_diller = @yabanciDiller WHERE kullanici_adi = @kullaniciAdiYabanciDiller;";
                        command.Parameters.AddWithValue("@yabanciDiller", yabanciDiller);
                        command.Parameters.AddWithValue("@kullaniciAdiYabanciDiller", kullaniciAdi);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear(); // Parametreleri temizle
                    }



                    // Doğum Tarihi güncelleme
                    DateTime dogumTarihi;
                    if (DateTime.TryParse(dateTimePicker1.Text, out dogumTarihi))
                    {
                        command.CommandText = "UPDATE Kullanicilar SET dogum_tarihi = @dogumTarihi WHERE kullanici_adi = @kullaniciAdiDogumtarihi;";
                        command.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@kullaniciAdiDogumtarihi", kullaniciAdi);
                        command.ExecuteNonQuery();
                    }





                    // Diğer alanların güncellenmesi işlemleri burada devam edebilir

                    MessageBox.Show("Bilgileriniz güncellenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
