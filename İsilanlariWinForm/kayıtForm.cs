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
    public partial class kayıtForm : Form
    {
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";


        private void KullaniciEkle(string KullaniciAdi, string Sifre, string Email, string TelNo)
        {
            using (MySqlConnection baglanti = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                try
                {
                    baglanti.Open();

                    string komuttext = "INSERT INTO kullanicilar (kullanici_adi,sifre,email,tel_no) VALUES (@KullaniciAdi,@Sifre,@Email,@TelNo)";

                    using (MySqlCommand komut = new MySqlCommand(komuttext, baglanti))
                    {
                        komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@Sifre", Sifre);
                        komut.Parameters.AddWithValue("@Email", Email);
                        komut.Parameters.AddWithValue("@TelNo", TelNo);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Yeni kayıt başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062 && ex.Message.Contains("Duplicate entry")) // Hata numarası: 1062 (Duplicate entry)
                    {
                        string errorMessage = "Bu kullanıcı adı zaten mevcut!";
                        MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string errorMessage = "Bir hata oluştu: " + ex.Message;
                        MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        public kayıtForm()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayıtolButton21_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = kullaniciadiTextbox1.text;
            string Sifre = sifreTextbox2.text;
            string Email = emailTextbox3.text;
            string TelNo = telnoTextbox1.text;
            KullaniciEkle(KullaniciAdi, Sifre, Email, TelNo);
        }
    }






}


