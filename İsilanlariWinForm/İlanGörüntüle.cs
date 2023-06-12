using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using İsilanlariWinForm.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace İsilanlariWinForm
{
    public partial class İlanGörüntüle : UserControl

    {
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";
        Basvurular basvurular = new Basvurular();
        public string HedefString { get; set; }


        private string arananString;


        public string kullaniciAdi; 

        // İlanGörüntüle kullanıcı denetiminde veritabanında arama yapma ve ilan başlığını Basvurular kullanıcı denetimine aktarma
        
        public İlanGörüntüle()
        {
            InitializeComponent();
        }

        private void İlanGörüntüle_Load(object sender, EventArgs e)
        {
            arananString = HedefString;
            connection = new MySqlConnection(connectionString);
            Basvurular basvurular1 = new Basvurular();
            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan başlıklarını al ve ListView'e ekle
                string query = "SELECT ilan_basligi FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ilanBasligi = reader.GetString("ilan_basligi");

                        listView1.Items.Add(ilanBasligi);
                       

                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }
            

    

            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan açıklamalarını al ve ListView'e ekle
                string query = "SELECT ilan_aciklamasi FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ilanAciklamasi = reader.GetString("ilan_aciklamasi");
                        richTextBox1.AppendText(ilanAciklamasi + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }


            //departman ekle
            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan açıklamalarını al ve ListView'e ekle
                string query = "SELECT departman FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Departman = reader.GetString("departman");
                        listView4.Items.Add(Departman);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }


            //çalışma şekli ekle
            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan açıklamalarını al ve ListView'e ekle
                string query = "SELECT calisma_sekli FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string CalismaSekli = reader.GetString("calisma_sekli");
                        listView3.Items.Add(CalismaSekli);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }

            //istenilen_tecrübe ekle
            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan açıklamalarını al ve ListView'e ekle
                string query = "SELECT istenilen_tecrube FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Tecrübe = reader.GetString("istenilen_tecrube");
                        listView5.Items.Add(Tecrübe);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }

            //maas ekle
            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // İlan açıklamalarını al ve ListView'e ekle
                string query = "SELECT maas FROM isilanlari WHERE ilan_basligi LIKE CONCAT('%', @aranan, '%')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@aranan", arananString);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maas = reader.GetInt32("maas");
                        listView2.Items.Add(maas.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            string selectedIlanBasligi = listView1.SelectedItems[0].Text;

            try
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Başvuran kullanıcının kullanıcı ID'sini al
                string kullaniciIDQuery = "SELECT kullanici_id FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                MySqlCommand kullaniciIDCommand = new MySqlCommand(kullaniciIDQuery, connection);
                kullaniciIDCommand.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi); // Başvuru yapan kullanıcının kullanıcı adını burada belirtelim.
                int kullaniciID = Convert.ToInt32(kullaniciIDCommand.ExecuteScalar());

                // İlgili ilanın ilan_basligi ve kullanici_id değerlerini Basvurular tablosuna ekle
                string ilanIDQuery = "SELECT ilan_id FROM IsIlanlari WHERE ilan_basligi = @ilanBasligi";
                MySqlCommand ilanIDCommand = new MySqlCommand(ilanIDQuery, connection);
                ilanIDCommand.Parameters.AddWithValue("@ilanBasligi", selectedIlanBasligi);
                int ilanID = Convert.ToInt32(ilanIDCommand.ExecuteScalar());

                string query = "INSERT INTO Basvurular (basvuru_baslik, kullanici_id, ilan_id) VALUES (@ilanBasligi, @kullaniciID, @ilanID)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ilanBasligi", selectedIlanBasligi);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                command.Parameters.AddWithValue("@ilanID", ilanID);
                command.ExecuteNonQuery();

                MessageBox.Show("Başvurunuz başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına erişim sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                connection.Close();
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
