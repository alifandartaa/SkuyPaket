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
    public partial class InputPengirimData : Form
    {
        public InputPengirimData()
        {
            InitializeComponent();
        }

        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=skuypaket;SslMode=none";
        private string query = "";

        private string selectedKategori = "";
        private int berat;
        private int tarif;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            query = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                Identitas pengirim = new Identitas(tbPengirim.Text, tbAlamatPengirim.Text, tbKotaPengirim.Text, tbKodePosPengirim.Text, tbNoTelpPengirim.Text);
                Identitas penerima = new Identitas(tbPenerima.Text, tbAlamatPenerima.Text, tbKotaPenerima.Text, tbKodePosPenerima.Text, tbNoTelpPenerima.Text);
                Barang barang = new Barang(cbJenisBarang.Text, selectedKategori, berat);

                if(selectedKategori == "" || berat == null || tarif == null)
                {
                    MessageBox.Show("Validasi Barang Error!");
                    return;
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
    }       
}
