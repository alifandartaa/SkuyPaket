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

namespace src
{
    public partial class BuktiTransaksi : Form
    {
        int noresi;
        public BuktiTransaksi()
        {
            InitializeComponent();
            this.show_kategori();
            this.show_jenis();
            this.show_berat();
            this.show_pengirim();
        }

        private void show_noresi()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT kategori_barang FROM barang WHERE no_resi=923877243479459";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Kategori_TextBox.Text = (rdr["kategori_barang"].ToString());
                }
                rdr.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Close DB connection
            }
        }

        private void show_kategori()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT kategori_barang FROM barang WHERE no_resi=923877243479459";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Kategori_TextBox.Text = (rdr["kategori_barang"].ToString());
                }
                rdr.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Close DB connection
            }
        }

        private void show_jenis()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT jenis_barang FROM barang WHERE no_resi=923877243479459";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Jenis_TextBox.Text = (rdr["jenis_barang"].ToString());
                }
                rdr.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Close DB connection
            }
        }

        private void show_berat()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT berat_barang FROM barang WHERE no_resi=923877243479459";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Berat_TextBox.Text = (rdr["berat_barang"].ToString());
                }
                rdr.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Close DB connection
            }
        }

        private void show_pengirim()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT u.nama FROM user u, invoice i WHERE i.id_pengirim=u.id and no_resi=923877243479459";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Pengirim_TextBox.Text = (rdr["nama"].ToString());
                }
                rdr.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Close DB connection
            }
        }
    }
}
