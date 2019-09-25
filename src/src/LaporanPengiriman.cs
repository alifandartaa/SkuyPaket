using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace src
{
    public partial class LaporanPengiriman : Form
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=skuypaket;SslMode=none";        

        public LaporanPengiriman()
        {
            InitializeComponent();
        }

        private void LaporanPengiriman_Load(object sender, EventArgs e)
        {
            dropdownTambahStatus();
        }
        private void dropdownTambahStatus()
        {
            cbTambahStatus.Text = "Pilih status...";
            String[] listTambahStatus = {"Kantor menerima barang","Dalam Proses pengiriman","Diterima di pusat","Diterima di cabang I","Diterima di cabang II","Diterima di cabang III"};
            cbTambahStatus.Items.AddRange(listTambahStatus);
        }

        private void btnTambahStatus_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {                
                int idStatus = getIdStatus(cbTambahStatus.Text);                
                int idInvoice = getIdInvoice();

                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.CommandText = "INSERT INTO invoice_status (`id_invoice`,`id_status`, `tanggal`) VALUES('" + idInvoice + "','" + idStatus + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                commandDatabase.ExecuteNonQuery();
                getStatusPengiriman();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private int getIdInvoice()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            int idInvoice = 0;            

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", tbCekResi.Text);
                commandDatabase.CommandText = "SELECT id FROM invoice WHERE no_resi = @no_resi";
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    idInvoice = Int32.Parse(read["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }            
            return idInvoice;
        }

        private int getIdStatus(String status)
        {
            int idStatus = 0;
            if (status.Equals("Kantor menerima barang"))
            {
                idStatus = 1;
            }
            else if (status.Equals("Dalam Proses pengiriman"))
            {
                idStatus = 2;
            }
            else if (status.Equals("Diterima di pusat"))
            {
                idStatus = 3;
            }
            else if (status.Equals("Diterima di cabang I"))
            {
                idStatus = 4;
            }
            else if (status.Equals("Diterima di cabang II"))
            {
                idStatus = 5;
            }
            else if (status.Equals("Diterima di cabang III"))
            {
                idStatus = 6;
            }
            return idStatus;
        }

        private void btnCekResi_Click(object sender, EventArgs e)
        {
            getDataPengirim();
            getDataPenerima();
            getDataBarang();
            getStatusPengiriman();
        }

        private void getDataPengirim()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", tbCekResi.Text);                                
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void getDataPenerima()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", tbCekResi.Text);
                commandDatabase.CommandText = "SELECT * FROM user WHERE id IN (SELECT id_penerima FROM invoice WHERE no_resi = @no_resi)";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void getDataBarang()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", tbCekResi.Text);
                commandDatabase.CommandText = "SELECT * FROM invoice i JOIN barang b on i.no_resi = b.no_resi WHERE i.no_resi = @no_resi";                   
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    lbNomorResi.Text = (read["no_resi"].ToString());
                    lbTglMasuk.Text = (read["tanggal"].ToString());
                    lbCabangPengirim.Text = (read["cabang"].ToString());
                    lbJenisBarang.Text = (read["jenis_barang"].ToString());
                    lbKategoriPaket.Text = (read["kategori_barang"].ToString());
                    lbBeratPaket.Text = (read["berat_barang"].ToString());
                    lbOngkosKirim.Text = (read["total"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void getStatusPengiriman()
        {
            lvStatusPengiriman.Items.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", tbCekResi.Text);
                commandDatabase.CommandText = "SELECT * FROM invoice_status ivs join status s on ivs.id_status = s.id WHERE ivs.id_invoice IN (SELECT id FROM invoice WHERE no_resi = @no_resi)";
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem listViewItem = new ListViewItem(read["id_status"].ToString());
                    listViewItem.SubItems.Add(read["tanggal"].ToString());
                    listViewItem.SubItems.Add(read["nama"].ToString());
                    lvStatusPengiriman.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}
