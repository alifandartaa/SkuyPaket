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
using System.Globalization;

namespace src
{
    public partial class InputPengirimData : Form
    {
        public InputPengirimData()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=skuypaket;SslMode=none";

        private string selectedKategori = "";
        private int berat;
        private int tarif;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            MySqlTransaction myTransac = databaseConnection.BeginTransaction();

            commandDatabase.Connection = databaseConnection;
            commandDatabase.Transaction = myTransac;

            Identitas pengirim = new Identitas(tbPengirim.Text, tbAlamatPengirim.Text, tbKotaPengirim.Text, tbKodePosPengirim.Text, tbNoTelpPengirim.Text);
            Identitas penerima = new Identitas(tbPenerima.Text, tbAlamatPenerima.Text, tbKotaPenerima.Text, tbKodePosPenerima.Text, tbNoTelpPenerima.Text);
            Barang barang = new Barang(cbJenisBarang.SelectedItem.ToString(), selectedKategori, berat);

            if (selectedKategori == "" || berat == null || tarif == null)
            {
                MessageBox.Show("Validasi Barang Error!");
                return;
            }

            try
            {
                // barang
                commandDatabase.CommandText = "INSERT INTO BARANG (`id`,`no_resi`, `jenis_barang`, `kategori_barang`, `berat_barang`) VALUES(NULL, '" + tbNoResi.Text + "', '" + barang.Jenis_barang + "','" + barang.Kategori + "'," + barang.Berat + ")";
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine("Barang Executed");

                // pengirim
                commandDatabase.CommandText = "INSERT INTO USER (`id`, `nama`, `alamat`, `kota`, `kode_pos`, `no_telp`, `tipe`) VALUES(NULL, '" + pengirim.Nama + "','" + pengirim.Alamat + "','" + pengirim.Kota + "'," + pengirim.Kode_pos + ",'" + pengirim.Telp + "', 0); SELECT LAST_INSERT_ID();";
                int id_pengirim = Convert.ToInt32(commandDatabase.ExecuteScalar());
                Console.WriteLine("Pengirim Executed");

                // penerima
                commandDatabase.CommandText = "INSERT INTO USER (`id`, `nama`, `alamat`, `kota`, `kode_pos`, `no_telp`, `tipe`) VALUES(NULL, '" + penerima.Nama + "','" + penerima.Alamat + "','" + penerima.Kota + "'," + penerima.Kode_pos + ",'" + penerima.Telp + "', 1); SELECT LAST_INSERT_ID();";
                int id_penerima = Convert.ToInt32(commandDatabase.ExecuteScalar());
                Console.WriteLine("Penerima Executed");

                Console.WriteLine(id_pengirim + " " + id_penerima);

                // invoice
                commandDatabase.CommandText = "INSERT INTO INVOICE (`id`, `id_pengirim`, `id_penerima`, `cabang`, `no_resi`, `tanggal`, `total`) VALUES(NULL, " + id_pengirim + "," + id_penerima + ",'" + cbCabang.SelectedItem.ToString() + "','" + tbNoResi.Text + "','" + dtTanggal.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "'," +  float.Parse(tbTotal.Text) + "); SELECT LAST_INSERT_ID();";
                int id_invoice = Convert.ToInt32(commandDatabase.ExecuteScalar());
                Console.WriteLine("Invoice Executed");

                // invoice_status
                commandDatabase.CommandText = "INSERT INTO INVOICE_STATUS (`id_invoice`, `id_status`, `tanggal`) VALUES('" + id_invoice + "'," + 1 + ",'" + DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "')";
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine("Invoice_status Executed");

                myTransac.Commit();
            }
            catch (Exception ex)
            {
                myTransac.Rollback();
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                databaseConnection.Close();
            }

            reset();
        }

        private void InputData_Load(object sender, EventArgs e)
        {
            rnd();
            dropdown_cabang();
            dropdown_jenis_barang();

            tbTotal.ReadOnly = true;
        }

        private void rnd()
        {
            String random = "1234567890";
            String no_resi = "";
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                no_resi += random[rnd.Next(random.Length)];
            }

            tbNoResi.Text = no_resi;
            tbNoResi.ReadOnly = true;
        }

        private void dropdown_cabang()
        {
            cbCabang.Text = "Select cabang ...";
            String[] listCabang = new String[4] { "Pusat", "Cabang I", "Cabang II", "Cabang III" };
            cbCabang.Items.AddRange(listCabang);
        }

        private void dropdown_jenis_barang()
        {
            cbJenisBarang.Text = "Select jenis ...";
            String[] listJenisBarang = new String[4] { "Dokumen", "Makanan / Minuman", "Elektronik", "Pakaian" };
            cbJenisBarang.Items.AddRange(listJenisBarang);
        }

        private void total_change()
        {
            if (selectedKategori.Length > 0 && berat != null && tarif != null)
            {
                int kategori = selectedKategori == "Express" ? 2 : 1;
                tbTotal.Text = ((berat * tarif) * kategori).ToString();
            }
            else
            {
                tbTotal.Text = "";
            }
        }

        private void rbReguler_Click(object sender, EventArgs e)
        {
            selectedKategori = rbReguler.Text;
            total_change();
        }

        private void rbExpress_Click(object sender, EventArgs e)
        {
            selectedKategori = rbExpress.Text;
            total_change();
        }

        private void tbTarif_TextChanged(object sender, EventArgs e)
        {
            tarif = Int32.Parse(tbTarif.Text.Length > 0? tbTarif.Text : "0");
            total_change();
        }

        private void tbBerat_TextChanged(object sender, EventArgs e)
        {
            berat = Int16.Parse(tbBerat.Text.Length > 0 ? tbBerat.Text : "0");
            total_change();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            rbExpress.Checked = false;
            rbReguler.Checked = false;
            cbCabang.SelectedIndex = -1;
            cbCabang.Text = "Select cabang ...";
            cbJenisBarang.SelectedIndex = -1;
            cbJenisBarang.Text = "Select jenis ...";
            tbAlamatPenerima.Text = "";
            tbAlamatPengirim.Text = "";
            tbBerat.Text = "";
            tbKodePosPenerima.Text = "";
            tbKodePosPengirim.Text = "";
            tbKotaPenerima.Text = "";
            tbKotaPengirim.Text = "";
            rnd();
            tbNoTelpPenerima.Text = "";
            tbNoTelpPengirim.Text = "";
            tbPenerima.Text = "";
            tbPengirim.Text = "";
            tbTarif.Text = "";
            tbTotal.Text = "";
        }
    }       
}
