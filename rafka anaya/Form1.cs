using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace rafka_anaya
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=db_kopi_gudang";
        public Form1()
        {
            InitializeComponent();
        }
        private void ambilData()
        {
            string kodeBahan= kdBahan.Text;
            string namaBarang = nmBahan.Text;

                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "select* from tb_bahan_baku";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView.Rows.Add(reader["kode_bahan"].ToString(),
                        reader["nama_bahan"].ToString(),
                        reader["kategori"].ToString(),
                        reader["stok"].ToString(),
                        reader["satuan"].ToString(),
                        reader["harga_satuan"].ToString(),
                        reader["batas_minimum"].ToString());

                }
                   

                   
                }
           
    }

        private void tambah_Click(object sender, EventArgs e)
        {

            string kodeBahan = kdBahan.Text;
            string namaBarang = nmBahan.Text;
            string satuan=txtHarga_satuan.Text;
            string hargaSatuan = txtHarga_satuan.Text;

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
                {


                    con.Open();

                //if (string.IsNullOrWhiteSpace(kodeBahan) || string.IsNullOrWhiteSpace(namaBarang) || string.IsNullOrWhiteSpace(satuan) || string.IsNullOrWhiteSpace(hargaSatuan))
                //{
                //    MessageBox.Show("field harus di isi");
                //}
                    String query = "insert into tb_bahan_baku (kode_bahan,nama_bahan,kategori,stok,satuan,harga_satuan,harga_minimum) values(@kode_bahan,@nama_bahan,@kategori,@stok,@satuan,@harga_satuan,@harga_minimum) ";
                

            using(MySqlCommand command=new MySqlCommand(query,con))
            {
                    command.Parameters.AddWithValue("@kode_bahan", kodeBahan);
                    command.Parameters.AddWithValue("@nama_bahan", namaBarang);
                    command.Parameters.AddWithValue("@nama", namaBarang);
                  
            }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ambilData();
        }
    } 
}
