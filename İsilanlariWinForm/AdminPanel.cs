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
    }
}
