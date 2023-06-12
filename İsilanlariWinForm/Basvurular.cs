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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace İsilanlariWinForm
{
    public partial class Basvurular : UserControl
    {
        public string kullaniciAdi;
        public string kullaniciID;

        public Basvurular()
        {
            InitializeComponent();
            
        }
        
        private void Basvurular_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                try
                {
                    
                    connection.Open();

                    // Kullanıcı adına göre kullanici_id değerini al
                    string query = "SELECT kullanici_id FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                    MySqlCommand command1 = new MySqlCommand(query, connection);
                    command1.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    using (MySqlDataReader reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kullaniciID = reader.GetInt32("kullanici_id").ToString();
                        }
                    }

                    // Kullanıcı_id'ye göre isim ve soyisim değerlerini al
                    string sql = "SELECT isim, soyisim FROM Kullanicilar WHERE kullanici_id = @kullaniciID";
                    MySqlCommand command3 = new MySqlCommand(sql, connection);
                    command3.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    using (MySqlDataReader reader = command3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string isim = reader.GetString("isim");
                            string soyisim = reader.GetString("soyisim");
                            string tamIsim = isim + " " + soyisim;
                            listView2.Items.Add(tamIsim);
                        }
                    }

                    // Kullanıcı_id'ye göre basvuru_baslik değerini al
                    string sorgu = "SELECT basvuru_baslik,basvuru_tarihi FROM Basvurular WHERE kullanici_id = @kullaniciID";
                    MySqlCommand command2 = new MySqlCommand(sorgu, connection);
                    command2.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                    using (MySqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string basvuruBaslik = reader.GetString("basvuru_baslik");
                            string basvuruTarihi = reader.GetDateTime("basvuru_tarihi").ToString();
                            listView1.Items.Add(basvuruBaslik);
                            listView3.Items.Add(basvuruTarihi);
                        }
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    
                    connection.Close();
                }

               
            }

        }
    }
}
