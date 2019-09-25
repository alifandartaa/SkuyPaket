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
    public partial class Main : Form
    {

        private static InputPengirimData ipd;
        private static LaporanPengiriman lpd;
        private static DaftarPengiriman dp;

        public Main()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            ipd = new InputPengirimData();
            ipd.MdiParent = this;

            lpd = new LaporanPengiriman();
            lpd.MdiParent = this;

            dp = new DaftarPengiriman();
            dp.MdiParent = this;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ipd.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lpd.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
