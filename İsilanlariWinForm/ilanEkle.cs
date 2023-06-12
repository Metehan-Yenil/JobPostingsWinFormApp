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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace İsilanlariWinForm
{

    public partial class ilanEkle : Form
    {



        private string userid;

        public string UserID
        {
            get { return userid; }
            set { userid = value; }
        }

        
        MySqlConnection connection;
        string connectionString = "server=127.0.0.1;port=3306;user=root;password=mete;database=isealimdb;";

        public ilanEkle(string kullanicidegisken)
        {
            InitializeComponent();
        }

        private void ilanEkle_Load(object sender, EventArgs e)
        {

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = UserID;
            int kullaniciId=0;

            string ilanBasligi = richTextBox2.Text;
            string ilanAciklamasi = richTextBox1.Text;
            string calismaSekli = listBox1.Text;
            string istenilenTecrube = textBox1.Text;
            string departman = textBox2.Text;
            string maas=textBox3.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT kullanici_id FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi ";
                using (MySqlCommand komut = new MySqlCommand(selectQuery, connection))
                {
                     komut.Parameters.AddWithValue("@kullaniciAdi",kullaniciAdi );
                    object result = komut.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        kullaniciId = Convert.ToInt32(result);
                    }
                } // selectCommand'ı kapatın

                string insertQuery = "INSERT INTO IsIlanlari (kullanici_id, ilan_basligi, ilan_aciklamasi, calisma_sekli, istenilen_tecrube, departman,maas) " +
                                     "VALUES (@kullaniciId, @ilanBasligi, @ilanAciklamasi, @calismaSekli, @istenilenTecrube, @departman, @maas)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    try
                    {
                        insertCommand.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        insertCommand.Parameters.AddWithValue("@ilanBasligi", ilanBasligi);
                        insertCommand.Parameters.AddWithValue("@ilanAciklamasi", ilanAciklamasi);
                        insertCommand.Parameters.AddWithValue("@calismaSekli", calismaSekli);
                        insertCommand.Parameters.AddWithValue("@istenilenTecrube", istenilenTecrube);
                        insertCommand.Parameters.AddWithValue("@departman", departman);
                        insertCommand.Parameters.AddWithValue("@maas", maas);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("İş ilanı başarıyla eklendi.");

                        richTextBox2.Text = "";
                        richTextBox1.Text = "";
                        listBox1.SelectedIndex = -1;
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İş ilanı eklenirken bir hata oluştu: " + ex.Message);
                    }
                } // insertCommand'ı kapatın
            } // connection'ı kapatın
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}