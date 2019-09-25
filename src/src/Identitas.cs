using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Identitas
    {
        private String nama;
        private String alamat;
        private String kota;
        private String kode_pos;
        private String telp;

        public Identitas()
        {

        }

        public Identitas(string nama, string alamat, string kota, string kode_pos, string telp)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.kota = kota;
            this.kode_pos = kode_pos;
            this.telp = telp;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Kota { get => kota; set => kota = value; }
        public string Kode_pos { get => kode_pos; set => kode_pos = value; }
        public string Telp { get => telp; set => telp = value; }
    }
}
