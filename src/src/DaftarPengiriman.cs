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

namespace src
{
    public partial class DaftarPengiriman : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=skuypaket;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);


        public DaftarPengiriman()
        {
            InitializeComponent();
        }
       
        private void DaftarPengiriman_Load(object sender, EventArgs e)
        {
            refresh();   
        }

        private void refresh()
        {
            string query = "select i.no_resi, pengirim, kota_asal, penerima, kota_tujuan, i.total from invoice i, (select id as id_pengirim, nama as pengirim, kota as kota_asal from user) as pengirim, (select id as id_penerima, nama as penerima, kota as kota_tujuan from user) penerima where i.id_pengirim = pengirim.id_pengirim and i.id_penerima = penerima.id_penerima";

            listPengiriman.Items.Clear();

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["no_resi"].ToString());
                        listViewItem.SubItems.Add(reader["pengirim"].ToString());
                        listViewItem.SubItems.Add(reader["penerima"].ToString());
                        listViewItem.SubItems.Add(reader["kota_asal"].ToString());
                        listViewItem.SubItems.Add(reader["kota_tujuan"].ToString());
                        listViewItem.SubItems.Add(reader["total"].ToString());

                        listPengiriman.Items.Add(listViewItem);
                    }

                    reader.Close();
                }
                else { MessageBox.Show("No rows found."); }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally { databaseConnection.Close(); }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            string query = "select i.no_resi, pengirim, kota_asal, penerima, kota_tujuan, i.total from invoice i, (select id as id_pengirim, nama as pengirim, kota as kota_asal from user) as pengirim, (select id as id_penerima, nama as penerima, kota as kota_tujuan from user) penerima where i.id_pengirim = pengirim.id_pengirim and i.id_penerima = penerima.id_penerima and kota_asal like @kota_asal and kota_tujuan like @kota_tujuan";

            listPengiriman.Items.Clear();

            try
            {
                // Open the database                 
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@kota_asal", "%" + tb_KotaAsal.Text + "%");
                cmd.Parameters.AddWithValue("@kota_tujuan", "%" + tb_KotaTujuan.Text + "%");
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["no_resi"].ToString());
                        listViewItem.SubItems.Add(reader["pengirim"].ToString());
                        listViewItem.SubItems.Add(reader["penerima"].ToString());
                        listViewItem.SubItems.Add(reader["kota_asal"].ToString());
                        listViewItem.SubItems.Add(reader["kota_tujuan"].ToString());
                        listViewItem.SubItems.Add(reader["total"].ToString());
                        listViewItem.SubItems.Add("Tampilkan >");

                        listPengiriman.Items.Add(listViewItem);

                    }

                    reader.Close();
                }
                else {
                    MessageBox.Show("No rows found.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally { databaseConnection.Close(); }
        }

        private void btn_tampilkan_Click(object sender, EventArgs e)
        {
            string noresi = tb_noresi.Text;
            BuktiTransaksi bkt = new BuktiTransaksi(noresi);
            bkt.Show();

        }

        private void listPengiriman_MouseClick(object sender, MouseEventArgs e)
        {
            tb_noresi.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[0].Text;
        }
    }
}
