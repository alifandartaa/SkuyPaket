using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Barang
    {
        private String jenis_barang;
        private String kategori;
        private int berat;

        public Barang()
        {

        }

        public Barang(string jenis_barang, string kategori, int berat)
        {
            this.jenis_barang = jenis_barang;
            this.kategori = kategori;
            this.berat = berat;
        }

        public string Jenis_barang { get => jenis_barang; set => jenis_barang = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public int Berat { get => berat; set => berat = value; }
    }
}
