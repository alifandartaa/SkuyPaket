using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class BuktiTransaksi : Form
    {
        private String noresi;
        public BuktiTransaksi(String noresi)
        {
            InitializeComponent();
            this.noresi = noresi;
            this.show_noresi();
            this.show_kategori();
            this.show_jenis();
            this.show_berat();
            this.show_datapengirim();
            this.show_datapenerima();
        }

        private void show_noresi()
        {
            Resi_textBox.Text = this.noresi;            
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
                String sql = "SELECT kategori_barang FROM barang WHERE no_resi='" + this.Noresi + "'";
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
                String sql = "SELECT jenis_barang FROM barang WHERE no_resi='" + this.Noresi + "'";
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
                String sql = "SELECT berat_barang FROM barang WHERE no_resi='" + this.Noresi + "'";
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
        /*
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
                String sql = "SELECT u.nama FROM user u, invoice i WHERE i.id_pengirim=u.id and no_resi='" + noresi + "'";
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

        
        private void show_penerima()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                //get data barang
                String sql = "SELECT u.nama FROM user u, invoice i WHERE i.id_penerima=u.id and no_resi='" + noresi + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Penerima_TextBox.Text = (rdr["nama"].ToString());
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
        */
        private void show_datapengirim()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                MySqlCommand commandDatabase = conn.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", this.Noresi);
                commandDatabase.CommandText = "SELECT * FROM user WHERE id IN (SELECT id_pengirim FROM invoice WHERE no_resi = @no_resi)";
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    lbNamaPengirim.Text = (read["nama"].ToString());
                    lbAlamatPengirim.Text = (read["alamat"].ToString());
                    lbKodePosPengirim.Text = (read["kode_pos"].ToString());
                    lbKotaPengirim.Text = (read["kota"].ToString());
                    lbNoTelpPengirim.Text = (read["no_telp"].ToString());
                }

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

        private void show_datapenerima()
        {
            MySqlConnection conn = new MySqlConnection(); ;
            String connString;
            connString = "server=127.0.0.1;uid=root;pwd=;database=skuypaket";
            try
            {

                conn.ConnectionString = connString;
                conn.Open(); // Open DB connection
                MySqlCommand commandDatabase = conn.CreateCommand();
                commandDatabase.CommandText = "SELECT * FROM user WHERE id IN (SELECT id_penerima FROM invoice WHERE no_resi ='" + this.Noresi + "')";
                //commandDatabase.Parameters.AddWithValue("@no_resi", this.Noresi);
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    lbNamaPenerima.Text = (read["nama"].ToString());
                    lbAlamatPenerima.Text = (read["alamat"].ToString());
                    lbKodePosPenerima.Text = (read["kode_pos"].ToString());
                    lbKotaPenerima.Text = (read["kota"].ToString());
                    lbNoTelpPenerima.Text = (read["no_telp"].ToString());
                }

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

        Bitmap bmp;

        public String Noresi { get => noresi; set => noresi = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(0, 0, 0, 0, this.Size);
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 25, 25, bmp.Width, bmp.Height);
        }

       
    }
}
