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
    public partial class Filtrele : UserControl
    {
        public string anahtar;
        public Filtrele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           string connectionString = "server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete";

           using (MySqlConnection connection = new MySqlConnection(connectionString))
           {
               // Veritabanı bağlantısını aç
               connection.Open();

                // En yüksek maaşlı ilanı bul
                string query = "SELECT ilan_basligi FROM isilanlari WHERE maas = (SELECT MAX(maas) FROM isilanlari)";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string ilanBasligi = reader.GetString("ilan_basligi");
                        MessageBox.Show("En yüksek maaşlı ilan:\n" + ilanBasligi);
                    }
                    else
                    {
                        MessageBox.Show("Hiç ilan bulunamadı.");
                    }
                }



                // Veritabanı bağlantısını kapat
                connection.Close();
           }


                


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = "server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // En yüksek maaşlı ilanı bul
                string query = "SELECT ilan_basligi FROM isilanlari WHERE maas = (SELECT MIN(maas) FROM isilanlari)";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string ilanBasligi = reader.GetString("ilan_basligi");
                        MessageBox.Show("En düşük maaşlı ilan:\n" + ilanBasligi);
                    }
                    else
                    {
                        MessageBox.Show("Hiç ilan bulunamadı.");
                    }
                }



                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }

        private void Filtrele_Load(object sender, EventArgs e)
        {

        }
    }
}
