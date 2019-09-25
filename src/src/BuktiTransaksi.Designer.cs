namespace src
{
    partial class BuktiTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuktiTransaksi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pengirim_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Berat_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Kategori_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Resi_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Jenis_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbNoTelpPengirim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbKotaPengirim = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbKodePosPengirim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAlamatPengirim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNamaPengirim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbNoTelpPenerima = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbNamaPenerima = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbAlamatPenerima = new System.Windows.Forms.Label();
            this.lbKotaPenerima = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbKodePosPenerima = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Penerima_TextBox = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(32, 365);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 170);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(617, 123);
            this.label6.TabIndex = 8;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catatan :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pengirim_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(347, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(334, 58);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pengirim";
            // 
            // Pengirim_TextBox
            // 
            this.Pengirim_TextBox.Enabled = false;
            this.Pengirim_TextBox.Location = new System.Drawing.Point(5, 21);
            this.Pengirim_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pengirim_TextBox.Name = "Pengirim_TextBox";
            this.Pengirim_TextBox.ReadOnly = true;
            this.Pengirim_TextBox.Size = new System.Drawing.Size(323, 22);
            this.Pengirim_TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Berat_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(32, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(279, 58);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berat";
            // 
            // Berat_TextBox
            // 
            this.Berat_TextBox.Enabled = false;
            this.Berat_TextBox.Location = new System.Drawing.Point(5, 21);
            this.Berat_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Berat_TextBox.Name = "Berat_TextBox";
            this.Berat_TextBox.ReadOnly = true;
            this.Berat_TextBox.Size = new System.Drawing.Size(267, 22);
            this.Berat_TextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Kategori_TextBox);
            this.groupBox4.Location = new System.Drawing.Point(32, 217);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(279, 62);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kategori";
            // 
            // Kategori_TextBox
            // 
            this.Kategori_TextBox.Enabled = false;
            this.Kategori_TextBox.Location = new System.Drawing.Point(6, 27);
            this.Kategori_TextBox.Name = "Kategori_TextBox";
            this.Kategori_TextBox.ReadOnly = true;
            this.Kategori_TextBox.Size = new System.Drawing.Size(266, 22);
            this.Kategori_TextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Resi_textBox);
            this.groupBox1.Location = new System.Drawing.Point(32, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(279, 58);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nomor Resi";
            // 
            // Resi_textBox
            // 
            this.Resi_textBox.Enabled = false;
            this.Resi_textBox.Location = new System.Drawing.Point(5, 21);
            this.Resi_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resi_textBox.Name = "Resi_textBox";
            this.Resi_textBox.ReadOnly = true;
            this.Resi_textBox.Size = new System.Drawing.Size(267, 22);
            this.Resi_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 85);
            this.label1.TabIndex = 18;
            this.label1.Text = "BUKTI TRANSAKSI PENGIRIMAN BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Jenis_TextBox);
            this.groupBox6.Location = new System.Drawing.Point(32, 283);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(279, 62);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jenis Barang";
            // 
            // Jenis_TextBox
            // 
            this.Jenis_TextBox.Enabled = false;
            this.Jenis_TextBox.Location = new System.Drawing.Point(6, 27);
            this.Jenis_TextBox.Name = "Jenis_TextBox";
            this.Jenis_TextBox.ReadOnly = true;
            this.Jenis_TextBox.Size = new System.Drawing.Size(266, 22);
            this.Jenis_TextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbNoTelpPengirim);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lbKotaPengirim);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lbKodePosPengirim);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lbAlamatPengirim);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lbNamaPengirim);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(347, 161);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(334, 175);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Pengirim";
            // 
            // lbNoTelpPengirim
            // 
            this.lbNoTelpPengirim.AutoSize = true;
            this.lbNoTelpPengirim.Location = new System.Drawing.Point(107, 143);
            this.lbNoTelpPengirim.Name = "lbNoTelpPengirim";
            this.lbNoTelpPengirim.Size = new System.Drawing.Size(104, 17);
            this.lbNoTelpPengirim.TabIndex = 23;
            this.lbNoTelpPengirim.Text = "081212121212";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "No Telepon";
            // 
            // lbKotaPengirim
            // 
            this.lbKotaPengirim.AutoSize = true;
            this.lbKotaPengirim.Location = new System.Drawing.Point(107, 114);
            this.lbKotaPengirim.Name = "lbKotaPengirim";
            this.lbKotaPengirim.Size = new System.Drawing.Size(54, 17);
            this.lbKotaPengirim.TabIndex = 21;
            this.lbKotaPengirim.Text = "Malang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kota";
            // 
            // lbKodePosPengirim
            // 
            this.lbKodePosPengirim.AutoSize = true;
            this.lbKodePosPengirim.Location = new System.Drawing.Point(107, 84);
            this.lbKodePosPengirim.Name = "lbKodePosPengirim";
            this.lbKodePosPengirim.Size = new System.Drawing.Size(48, 17);
            this.lbKodePosPengirim.TabIndex = 19;
            this.lbKodePosPengirim.Text = "18210";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kode Pos";
            // 
            // lbAlamatPengirim
            // 
            this.lbAlamatPengirim.AutoSize = true;
            this.lbAlamatPengirim.Location = new System.Drawing.Point(107, 57);
            this.lbAlamatPengirim.Name = "lbAlamatPengirim";
            this.lbAlamatPengirim.Size = new System.Drawing.Size(192, 17);
            this.lbAlamatPengirim.TabIndex = 17;
            this.lbAlamatPengirim.Text = "Jalan Kenangan Indah No 62";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Alamat";
            // 
            // lbNamaPengirim
            // 
            this.lbNamaPengirim.AutoSize = true;
            this.lbNamaPengirim.Location = new System.Drawing.Point(107, 28);
            this.lbNamaPengirim.Name = "lbNamaPengirim";
            this.lbNamaPengirim.Size = new System.Drawing.Size(92, 17);
            this.lbNamaPengirim.TabIndex = 15;
            this.lbNamaPengirim.Text = "Budi Santoso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nama";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbNoTelpPenerima);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.lbNamaPenerima);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.lbAlamatPenerima);
            this.groupBox7.Controls.Add(this.lbKotaPenerima);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.lbKodePosPenerima);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(704, 161);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(309, 175);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data Penerima";
            // 
            // lbNoTelpPenerima
            // 
            this.lbNoTelpPenerima.AutoSize = true;
            this.lbNoTelpPenerima.Location = new System.Drawing.Point(107, 146);
            this.lbNoTelpPenerima.Name = "lbNoTelpPenerima";
            this.lbNoTelpPenerima.Size = new System.Drawing.Size(104, 17);
            this.lbNoTelpPenerima.TabIndex = 33;
            this.lbNoTelpPenerima.Text = "081212121212";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Nama";
            // 
            // lbNamaPenerima
            // 
            this.lbNamaPenerima.AutoSize = true;
            this.lbNamaPenerima.Location = new System.Drawing.Point(107, 32);
            this.lbNamaPenerima.Name = "lbNamaPenerima";
            this.lbNamaPenerima.Size = new System.Drawing.Size(36, 17);
            this.lbNamaPenerima.TabIndex = 25;
            this.lbNamaPenerima.Text = "Andi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "No Telepon";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Alamat";
            // 
            // lbAlamatPenerima
            // 
            this.lbAlamatPenerima.AutoSize = true;
            this.lbAlamatPenerima.Location = new System.Drawing.Point(107, 62);
            this.lbAlamatPenerima.Name = "lbAlamatPenerima";
            this.lbAlamatPenerima.Size = new System.Drawing.Size(187, 17);
            this.lbAlamatPenerima.TabIndex = 27;
            this.lbAlamatPenerima.Text = "Vila Dago Tol Blok Z10 No 1";
            // 
            // lbKotaPenerima
            // 
            this.lbKotaPenerima.AutoSize = true;
            this.lbKotaPenerima.Location = new System.Drawing.Point(107, 118);
            this.lbKotaPenerima.Name = "lbKotaPenerima";
            this.lbKotaPenerima.Size = new System.Drawing.Size(130, 17);
            this.lbKotaPenerima.TabIndex = 31;
            this.lbKotaPenerima.Text = "Tangerang Selatan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "Kode Pos";
            // 
            // lbKodePosPenerima
            // 
            this.lbKodePosPenerima.AutoSize = true;
            this.lbKodePosPenerima.Location = new System.Drawing.Point(107, 89);
            this.lbKodePosPenerima.Name = "lbKodePosPenerima";
            this.lbKodePosPenerima.Size = new System.Drawing.Size(48, 17);
            this.lbKodePosPenerima.TabIndex = 29;
            this.lbKodePosPenerima.Text = "15310";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Kota";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Penerima_TextBox);
            this.groupBox8.Location = new System.Drawing.Point(704, 87);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(309, 58);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Penerima";
            // 
            // Penerima_TextBox
            // 
            this.Penerima_TextBox.Enabled = false;
            this.Penerima_TextBox.Location = new System.Drawing.Point(5, 21);
            this.Penerima_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Penerima_TextBox.Name = "Penerima_TextBox";
            this.Penerima_TextBox.ReadOnly = true;
            this.Penerima_TextBox.Size = new System.Drawing.Size(304, 22);
            this.Penerima_TextBox.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BuktiTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuktiTransaksi";
            this.Text = "BuktiTransaksi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Pengirim_TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Berat_TextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Resi_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kategori_TextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox Jenis_TextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbNoTelpPengirim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbKotaPengirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbKodePosPengirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAlamatPengirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNamaPengirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbNoTelpPenerima;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbNamaPenerima;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbAlamatPenerima;
        private System.Windows.Forms.Label lbKotaPenerima;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbKodePosPenerima;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Penerima_TextBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}