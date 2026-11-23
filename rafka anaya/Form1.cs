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
                   

                   
                }
           
    }   } 
}
