using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İsilanlariWinForm
{
    public partial class İlanGörüntüle : UserControl

    {
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";
        
        public string HedefString { get; set; }


        private string arananString;

        
        public İlanGörüntüle()
        {
            InitializeComponent();
        }

        private void İlanGörüntüle_Load(object sender, EventArgs e)
        {
            arananString = HedefString;
            connection = new MySqlConnection(connectionString);

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

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
