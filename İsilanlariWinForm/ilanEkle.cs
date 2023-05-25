using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İsilanlariWinForm
{

    public partial class ilanEkle : Form
    {
        public ilanEkle(string kullaniciAdi)
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";
        private void ilanEkle_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // TextBox'lardan ilgili bilgileri alın
            string ilanBasligi = bunifuTextbox1.Text;
            string ilanAciklamasi = richTextBox1.Text;
            string calismaSekli = listBox1.Text;
            string istenilenTecrube = textBox1.Text;
            string departman = textBox2.Text;

            // Veritabanına ekleme işlemi için SQL sorgusu
            string insertQuery = "INSERT INTO IsIlanlari (kullanici_id, ilan_basligi, ilan_aciklamasi, calisma_sekli, istenilen_tecrube, departman) " +
                                 "values (@kullaniciId, @ilanBasligi, @ilanAciklamasi, @calismaSekli, @istenilenTecrube, @departman)";
            string selectQuery = "select kullanici_id from kullanicilar where kullanici_adi= @kullaniciAdi;";
            int kullaniciId;

            int.TryParse(selectQuery, out kullaniciId);


            // Veritabanı bağlantısı ve komut nesnesi oluşturma
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
            {
                try
                {
                    // Parametreleri tanımlama ve değerlerini atama
                    // command.Parameters.AddWithValue("@kullaniciId", kullaniciId); // Kullanıcı kimliği değerini belirleyin
                    command.Parameters.AddWithValue("@ilanBasligi", ilanBasligi);
                    command.Parameters.AddWithValue("@ilanAciklamasi", ilanAciklamasi);
                    command.Parameters.AddWithValue("@calismaSekli", calismaSekli);
                    command.Parameters.AddWithValue("@istenilenTecrube", istenilenTecrube);
                    command.Parameters.AddWithValue("@departman", departman);

                    // Veritabanı bağlantısını açma
                    connection.Open();

                    // Komutu çalıştırma (veriyi veritabanına ekleme)
                    command.ExecuteNonQuery();

                    // İşlem başarılı mesajı veya diğer işlemleri yapabilirsiniz
                    MessageBox.Show("İş ilanı başarıyla eklendi.");

                    // TextBox'ları temizleme veya diğer işlemleri yapabilirsiniz

                }
                catch (Exception ex)
                {
                    // Hata durumunda hata mesajını gösterme veya işlem yapabilirsiniz
                    MessageBox.Show("İş ilanı eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

      

        
    }

}