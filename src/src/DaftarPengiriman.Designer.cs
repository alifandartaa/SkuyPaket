namespace src
{
    partial class DaftarPengiriman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_KotaTujuan = new System.Windows.Forms.TextBox();
            this.btn_Cari = new System.Windows.Forms.Button();
            this.tb_KotaAsal = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.listPengiriman = new System.Windows.Forms.ListView();
            this.id_NoResi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_NamaPengirim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_NamaTujuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_KotaAsal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_KotaTujuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_OngkosKirim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_noresi = new System.Windows.Forms.TextBox();
            this.btn_tampilkan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_KotaTujuan
            // 
            this.tb_KotaTujuan.Location = new System.Drawing.Point(450, 29);
            this.tb_KotaTujuan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_KotaTujuan.Multiline = true;
            this.tb_KotaTujuan.Name = "tb_KotaTujuan";
            this.tb_KotaTujuan.Size = new System.Drawing.Size(148, 38);
            this.tb_KotaTujuan.TabIndex = 9;
            // 
            // btn_Cari
            // 
            this.btn_Cari.Location = new System.Drawing.Point(606, 29);
            this.btn_Cari.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(128, 39);
            this.btn_Cari.TabIndex = 10;
            this.btn_Cari.Text = "Cari";
            this.btn_Cari.UseVisualStyleBackColor = true;
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // tb_KotaAsal
            // 
            this.tb_KotaAsal.Location = new System.Drawing.Point(148, 29);
            this.tb_KotaAsal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_KotaAsal.Multiline = true;
            this.tb_KotaAsal.Name = "tb_KotaAsal";
            this.tb_KotaAsal.Size = new System.Drawing.Size(148, 38);
            this.tb_KotaAsal.TabIndex = 12;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(38, 38);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(104, 25);
            this.label37.TabIndex = 13;
            this.label37.Text = "Kota Asal";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(316, 38);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(128, 25);
            this.label38.TabIndex = 14;
            this.label38.Text = "Kota Tujuan";
            // 
            // listPengiriman
            // 
            this.listPengiriman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_NoResi,
            this.id_NamaPengirim,
            this.id_NamaTujuan,
            this.id_KotaAsal,
            this.id_KotaTujuan,
            this.id_OngkosKirim});
            this.listPengiriman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPengiriman.FullRowSelect = true;
            this.listPengiriman.HideSelection = false;
            this.listPengiriman.Location = new System.Drawing.Point(0, 0);
            this.listPengiriman.Name = "listPengiriman";
            this.listPengiriman.Size = new System.Drawing.Size(1153, 400);
            this.listPengiriman.TabIndex = 15;
            this.listPengiriman.UseCompatibleStateImageBehavior = false;
            this.listPengiriman.View = System.Windows.Forms.View.Details;
            this.listPengiriman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listPengiriman_MouseClick);
            // 
            // id_NoResi
            // 
            this.id_NoResi.Text = "Nomor Resi";
            this.id_NoResi.Width = 120;
            // 
            // id_NamaPengirim
            // 
            this.id_NamaPengirim.Text = "Nama Pengirim";
            this.id_NamaPengirim.Width = 130;
            // 
            // id_NamaTujuan
            // 
            this.id_NamaTujuan.Text = "Nama Tujuan";
            this.id_NamaTujuan.Width = 130;
            // 
            // id_KotaAsal
            // 
            this.id_KotaAsal.Text = "Kota Asal";
            this.id_KotaAsal.Width = 130;
            // 
            // id_KotaTujuan
            // 
            this.id_KotaTujuan.Text = "Kota Tujuan";
            this.id_KotaTujuan.Width = 130;
            // 
            // id_OngkosKirim
            // 
            this.id_OngkosKirim.Text = "Ongkos Kirim";
            this.id_OngkosKirim.Width = 130;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listPengiriman);
            this.panel1.Location = new System.Drawing.Point(43, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 400);
            this.panel1.TabIndex = 16;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1034, 29);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(128, 39);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_noresi
            // 
            this.tb_noresi.Location = new System.Drawing.Point(43, 519);
            this.tb_noresi.Name = "tb_noresi";
            this.tb_noresi.Size = new System.Drawing.Size(237, 31);
            this.tb_noresi.TabIndex = 18;
            // 
            // btn_tampilkan
            // 
            this.btn_tampilkan.Location = new System.Drawing.Point(304, 519);
            this.btn_tampilkan.Name = "btn_tampilkan";
            this.btn_tampilkan.Size = new System.Drawing.Size(155, 31);
            this.btn_tampilkan.TabIndex = 19;
            this.btn_tampilkan.Text = "Tampilkan";
            this.btn_tampilkan.UseVisualStyleBackColor = true;
            this.btn_tampilkan.Click += new System.EventHandler(this.btn_tampilkan_Click);
            // 
            // DaftarPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1241, 582);
            this.Controls.Add(this.btn_tampilkan);
            this.Controls.Add(this.tb_noresi);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.tb_KotaAsal);
            this.Controls.Add(this.tb_KotaTujuan);
            this.Controls.Add(this.btn_Cari);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DaftarPengiriman";
            this.Text = "Daftar Pengiriman";
            this.Load += new System.EventHandler(this.DaftarPengiriman_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_KotaTujuan;
        private System.Windows.Forms.Button btn_Cari;
        private System.Windows.Forms.TextBox tb_KotaAsal;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ListView listPengiriman;
        private System.Windows.Forms.ColumnHeader id_NoResi;
        private System.Windows.Forms.ColumnHeader id_NamaPengirim;
        private System.Windows.Forms.ColumnHeader id_NamaTujuan;
        private System.Windows.Forms.ColumnHeader id_KotaAsal;
        private System.Windows.Forms.ColumnHeader id_KotaTujuan;
        private System.Windows.Forms.ColumnHeader id_OngkosKirim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_noresi;
        private System.Windows.Forms.Button btn_tampilkan;
    }
}