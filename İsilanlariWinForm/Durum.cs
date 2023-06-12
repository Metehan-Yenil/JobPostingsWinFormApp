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
    public partial class Durum : UserControl
    {
       public string kullaniciAdi;
        public Durum()
        {
            InitializeComponent();
        }

        private void Durum_Load(object sender, EventArgs e)
        {
            

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;database=isealimdb;user=root;password=mete"))
            {
                // Veritabanı bağlantısını aç
                connection.Open();

                // Kullanici_id'yi kullanici_adi'na göre al
                string kullaniciIdQuery = "SELECT kullanici_id FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi";
                MySqlCommand kullaniciIdCommand = new MySqlCommand(kullaniciIdQuery, connection);
                kullaniciIdCommand.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                int kullaniciId = 0;

                using (MySqlDataReader kullaniciIdReader = kullaniciIdCommand.ExecuteReader())
                {
                    if (kullaniciIdReader.Read())
                    {
                        kullaniciId = kullaniciIdReader.GetInt32("kullanici_id");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.");
                        return;
                    }
                }

                // Kullanıcının oluşturduğu ilanların ilan_id değerlerini al
                string ilanIdQuery = "SELECT ilan_id FROM isilanlari WHERE kullanici_id = @kullaniciId";
                MySqlCommand ilanIdCommand = new MySqlCommand(ilanIdQuery, connection);
                ilanIdCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                List<int> ilanIdList = new List<int>();

                using (MySqlDataReader ilanIdReader = ilanIdCommand.ExecuteReader())
                {
                    while (ilanIdReader.Read())
                    {
                        int ilanId = ilanIdReader.GetInt32("ilan_id");
                        ilanIdList.Add(ilanId);
                    }
                }

                // İlan_id'ye başvuru yapan kişilerin tüm bilgilerini ve ilan bilgilerini al ve datagridview'a ekle
                DataTable table = new DataTable();
                table.Columns.Add("Ad");
                table.Columns.Add("Soyad");
                table.Columns.Add("E-posta");
                table.Columns.Add("İlan Başlığı");
                table.Columns.Add("Maaş");
                table.Columns.Add("Mezun Olan Okul");
                table.Columns.Add("Bölüm/Fakülte");
                table.Columns.Add("Programlama Dilleri");
                table.Columns.Add("Teknik Beceriler");
                table.Columns.Add("Yabancı Diller");
                table.Columns.Add("İletişim Becerileri");
                table.Columns.Add("Liderlik Yetenekleri");

                foreach (int ilanId in ilanIdList)
                {
                    string basvuruQuery = "SELECT kullanicilar.isim, kullanicilar.soyisim, kullanicilar.email, " +
                                          "isilanlari.ilan_basligi, isilanlari.maas, kullanicilar.mezun_olan_okul, kullanicilar.bolum_fakulte, " +
                                          "kullanicilar.programlama_dilleri, kullanicilar.teknik_beceriler, kullanicilar.yabanci_diller, " +
                                          "kullanicilar.iletisim_becerileri, kullanicilar.liderlik_yetenekleri " +
                                          "FROM basvurular " +
                                          "INNER JOIN kullanicilar ON basvurular.kullanici_id = kullanicilar.kullanici_id " +
                                          "INNER JOIN isilanlari ON basvurular.ilan_id = isilanlari.ilan_id " +
                                          "WHERE basvurular.ilan_id = @ilanId";
                    MySqlCommand basvuruCommand = new MySqlCommand(basvuruQuery, connection);
                    basvuruCommand.Parameters.AddWithValue("@ilanId", ilanId);

                    using (MySqlDataReader basvuruReader = basvuruCommand.ExecuteReader())
                    {
                        while (basvuruReader.Read())
                        {
                            string ad = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("isim")) ? "" : basvuruReader.GetString("isim");
                            string soyad = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("soyisim")) ? "" : basvuruReader.GetString("soyisim");
                            string eposta = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("email")) ? "" : basvuruReader.GetString("email");
                            string ilanBasligi = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("ilan_basligi")) ? "" : basvuruReader.GetString("ilan_basligi");
                            int maas = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("maas")) ? 0 : basvuruReader.GetInt32("maas");
                            string mezunOlanOkul = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("mezun_olan_okul")) ? "" : basvuruReader.GetString("mezun_olan_okul");
                            string bolumFakulte = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("bolum_fakulte")) ? "" : basvuruReader.GetString("bolum_fakulte");
                            string programlamaDilleri = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("programlama_dilleri")) ? "" : basvuruReader.GetString("programlama_dilleri");
                            string teknikBeceriler = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("teknik_beceriler")) ? "" : basvuruReader.GetString("teknik_beceriler");
                            string yabanciDiller = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("yabanci_diller")) ? "" : basvuruReader.GetString("yabanci_diller");
                            string iletisimBecerileri = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("iletisim_becerileri")) ? "" : basvuruReader.GetString("iletisim_becerileri");
                            string liderlikYetenekleri = basvuruReader.IsDBNull(basvuruReader.GetOrdinal("liderlik_yetenekleri")) ? "" : basvuruReader.GetString("liderlik_yetenekleri");

                            table.Rows.Add(ad, soyad, eposta, ilanBasligi, maas, mezunOlanOkul, bolumFakulte, programlamaDilleri,
                                teknikBeceriler, yabanciDiller, iletisimBecerileri, liderlikYetenekleri);
                        }
                    }
                }

                dataGridView1.DataSource = table;

                // Veritabanı bağlantısını kapat
                connection.Close();
            }

        }
    }
}
