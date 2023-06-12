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
    public partial class AdminPanel : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";
        string sorgu;
        public AdminPanel()
        {
            InitializeComponent();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    sorgu = richTextBox1.Text;

                    // Veritabanından verileri almak için bir sorgu oluştur.



                    // MySqlCommand nesnesiyle sorguyu ve bağlantıyı ilişkilendir
                    using (MySqlCommand command = new MySqlCommand(sorgu, connection))
                    {
                        // MySqlDataAdapter nesnesiyle verileri al
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                        // Verileri bir DataTable nesnesine doldur
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e verileri ata
                        dataGridView1.DataSource = dataTable;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Kullanicilar";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // DataGridView'e verileri yükleme
                    dataGridView1.DataSource = dataTable;
                }

                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int girilenId;
            if (int.TryParse(textBox1.Text, out girilenId))
            {
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();

                    // UNION sorgusunu çalıştır
                    string query = "SELECT kullanici_adi FROM Kullanicilar WHERE kullanici_id = @girilenid " +
                                   "UNION " +
                                   "SELECT ilan_basligi FROM isilanlari WHERE kullanici_id = @girilenid";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@girilenid", girilenId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("Veri");

                        while (reader.Read())
                        {
                            string veri = reader.GetString(0);
                            table.Rows.Add(veri);
                        }

                        dataGridView1.DataSource = table;
                    }

                    // Veritabanı bağlantısını kapat
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı ID girişi!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Eşsiz isim ve soyisimleri sırala
                string query = "SELECT DISTINCT CONCAT(isim, ' ', soyisim) AS tamIsim FROM Kullanicilar";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("İsim ve Soyisim");

                    while (reader.Read())
                    {
                        string tamIsim = reader.GetString("tamIsim");
                        table.Rows.Add(tamIsim);
                    }

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string girilenDepartman = textBox2.Text;

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Girilen departmandaki maaşların toplamını bul
                string query = "SELECT SUM(maas) AS toplamMaas FROM isilanlari WHERE departman = @departman";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@departman", girilenDepartman);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Departman");
                    table.Columns.Add("Toplam Maaş");

                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("toplamMaas")))
                        {
                            decimal toplamMaas = reader.GetDecimal("toplamMaas");
                            table.Rows.Add(girilenDepartman, toplamMaas);
                        }
                    }

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string girilenDepartman = textBox3.Text;

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Girilen departmandaki ortalama maaşları bul
                string query = "SELECT AVG(maas) AS ortalamaMaas FROM isilanlari WHERE departman = @departman";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@departman", girilenDepartman);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Departman");
                    table.Columns.Add("Ortalama Maaş");

                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("ortalamaMaas")))
                        {
                            decimal ortalamaMaas = reader.GetDecimal("ortalamaMaas");
                            table.Rows.Add(girilenDepartman, ortalamaMaas);
                        }
                    }

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string girilenBolumFakulte = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Girilen bölüm/fakülteye sahip olan kişileri gruplayarak getir
                string query = "SELECT CONCAT(isim, ' ', soyisim) AS AdSoyad FROM kullanicilar WHERE bolum_fakulte = @bolumFakulte GROUP BY AdSoyad";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@bolumFakulte", girilenBolumFakulte);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Ad Soyad");

                    while (reader.Read())
                    {
                        string adSoyad = reader.GetString("AdSoyad");
                        table.Rows.Add(adSoyad);
                    }

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal girilenMaas = decimal.Parse(textBox5.Text);

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Girilen maaş değerine göre filtrelenmiş ilanları getir
                string query = "SELECT ilan_id, ilan_basligi, maas FROM IsIlanlari WHERE maas > @girilenMaas";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@girilenMaas", girilenMaas);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int baslangicYili = int.Parse(textBox6.Text);
            int bitisYili = int.Parse(textBox7.Text);

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Girilen iki yıl arasında doğan kişileri getir
                string query = "SELECT * FROM Kullanicilar WHERE YEAR(dogum_tarihi) BETWEEN @baslangicYili AND @bitisYili";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@baslangicYili", baslangicYili);
                command.Parameters.AddWithValue("@bitisYili", bitisYili);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Sorguyu hazırla
                string query = @"SELECT ilan.*, basvuran_kisi.*, yayinlayan_kisi.*
                        FROM isilanlari AS ilan
                        INNER JOIN basvurular AS basvurular ON basvurular.ilan_id = ilan.ilan_id
                        INNER JOIN kullanicilar AS basvuran_kisi ON basvuran_kisi.kullanici_id = basvurular.kullanici_id
                        INNER JOIN kullanicilar AS yayinlayan_kisi ON yayinlayan_kisi.kullanici_id = ilan.kullanici_id";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }

                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int kullaniciId = Convert.ToInt32(textBox8.Text);

            DialogResult result = MessageBox.Show("Satırı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();

                    // Kullanicilar tablosundan satır sil
                    string kullanicilarQuery = "DELETE FROM kullanicilar WHERE kullanici_id = @kullaniciId";
                    MySqlCommand kullanicilarCommand = new MySqlCommand(kullanicilarQuery, connection);
                    kullanicilarCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    kullanicilarCommand.ExecuteNonQuery();

                    // Veritabanı bağlantısını kapat
                    connection.Close();

                    MessageBox.Show("Satır başarıyla silindi.");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Satır silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int kullaniciId = Convert.ToInt32(textBox8.Text);

            DialogResult result = MessageBox.Show("Satırı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();

                    // Basvurular tablosundan satır sil
                    string basvurularQuery = "DELETE FROM basvurular WHERE kullanici_id = @kullaniciId";
                    MySqlCommand basvurularCommand = new MySqlCommand(basvurularQuery, connection);
                    basvurularCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    basvurularCommand.ExecuteNonQuery();

                    // Veritabanı bağlantısını kapat
                    connection.Close();

                    MessageBox.Show("Satır başarıyla silindi.");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Satır silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int kullaniciId = Convert.ToInt32(textBox8.Text);

            DialogResult result = MessageBox.Show("Satırı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
                {
                    // Veritabanı bağlantısını aç
                    connection.Open();

                    // IsIlanlari tablosundan satır sil
                    string isIlanlariQuery = "DELETE FROM isilanlari WHERE kullanici_id = @kullaniciId";
                    MySqlCommand isIlanlariCommand = new MySqlCommand(isIlanlariQuery, connection);
                    isIlanlariCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    isIlanlariCommand.ExecuteNonQuery();

                    // Veritabanı bağlantısını kapat
                    connection.Close();

                    MessageBox.Show("Satır başarıyla silindi.");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Satır silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Saklı yordamı çağırmak için MySqlCommand nesnesini oluşturun
                MySqlCommand command = new MySqlCommand("kullanicilar_getir", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Sonuçları almak için MySqlDataAdapter nesnesini oluşturun
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Sonuçları tutmak için bir DataTable oluşturun
                DataTable table = new DataTable();

                // DataTable'e verileri doldur
                adapter.Fill(table);

                // DataGridView'e verileri ata
                dataGridView1.DataSource = table;

                // Bağlantıyı kapat
                connection.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                MySqlCommand command = new MySqlCommand("isilanlari_getir", connection);
                command.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                MySqlCommand command = new MySqlCommand("basvurular_getir", connection);
                command.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Veritabanı bağlantısını kapat
                connection.Close();
            }
        }
    }

}
