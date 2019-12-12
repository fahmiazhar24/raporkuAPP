namespace raporkuAPP
{
    partial class inputDataSiswa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tglLahir_DTP = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.kelas_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.walikelas_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statuskawin_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.agama_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nomorortu_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ayah_tb = new System.Windows.Forms.TextBox();
            this.ibu_tb = new System.Windows.Forms.TextBox();
            this.alamat_tb = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jeniskelamin_CB = new System.Windows.Forms.ComboBox();
            this.tempatlahir_TB = new System.Windows.Forms.TextBox();
            this.namaSiswa_TB = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(497, 575);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Cancel);
            this.groupBox1.Controls.Add(this.tglLahir_DTP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.kelas_cb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.walikelas_cb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.statuskawin_tb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.agama_cb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nomorortu_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ayah_tb);
            this.groupBox1.Controls.Add(this.ibu_tb);
            this.groupBox1.Controls.Add(this.alamat_tb);
            this.groupBox1.Controls.Add(this.btShow);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.jeniskelamin_CB);
            this.groupBox1.Controls.Add(this.tempatlahir_TB);
            this.groupBox1.Controls.Add(this.namaSiswa_TB);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 1016);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA_SISWA";
            // 
            // tglLahir_DTP
            // 
            this.tglLahir_DTP.Location = new System.Drawing.Point(161, 155);
            this.tglLahir_DTP.Name = "tglLahir_DTP";
            this.tglLahir_DTP.Size = new System.Drawing.Size(301, 22);
            this.tglLahir_DTP.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Kelas";
            // 
            // kelas_cb
            // 
            this.kelas_cb.FormattingEnabled = true;
            this.kelas_cb.Items.AddRange(new object[] {
            "IPA",
            "IPS"});
            this.kelas_cb.Location = new System.Drawing.Point(161, 599);
            this.kelas_cb.Name = "kelas_cb";
            this.kelas_cb.Size = new System.Drawing.Size(301, 24);
            this.kelas_cb.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "Wali Kelas";
            // 
            // walikelas_cb
            // 
            this.walikelas_cb.FormattingEnabled = true;
            this.walikelas_cb.Items.AddRange(new object[] {
            "FAHMI AZHAR ISKANDAR",
            "ARIDITYA NUROKHIM",
            "M. THORIQ FADLULLAH"});
            this.walikelas_cb.Location = new System.Drawing.Point(161, 561);
            this.walikelas_cb.Name = "walikelas_cb";
            this.walikelas_cb.Size = new System.Drawing.Size(301, 24);
            this.walikelas_cb.TabIndex = 46;
            this.walikelas_cb.SelectedIndexChanged += new System.EventHandler(this.walikelas_cb_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Status Kawin";
            // 
            // statuskawin_tb
            // 
            this.statuskawin_tb.Location = new System.Drawing.Point(161, 523);
            this.statuskawin_tb.Name = "statuskawin_tb";
            this.statuskawin_tb.Size = new System.Drawing.Size(301, 22);
            this.statuskawin_tb.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Agama";
            // 
            // agama_cb
            // 
            this.agama_cb.FormattingEnabled = true;
            this.agama_cb.Items.AddRange(new object[] {
            "ISLAM",
            "KATHOLIK",
            "PROTESTAN",
            "HINDU",
            "BUDHA",
            "KONGHUCHU"});
            this.agama_cb.Location = new System.Drawing.Point(161, 356);
            this.agama_cb.Name = "agama_cb";
            this.agama_cb.Size = new System.Drawing.Size(301, 24);
            this.agama_cb.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Nomor Orangtua";
            // 
            // nomorortu_tb
            // 
            this.nomorortu_tb.Location = new System.Drawing.Point(161, 484);
            this.nomorortu_tb.Name = "nomorortu_tb";
            this.nomorortu_tb.Size = new System.Drawing.Size(301, 22);
            this.nomorortu_tb.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nama Ayah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nama Ibu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Alamat";
            // 
            // ayah_tb
            // 
            this.ayah_tb.Location = new System.Drawing.Point(161, 443);
            this.ayah_tb.Name = "ayah_tb";
            this.ayah_tb.Size = new System.Drawing.Size(301, 22);
            this.ayah_tb.TabIndex = 36;
            // 
            // ibu_tb
            // 
            this.ibu_tb.Location = new System.Drawing.Point(161, 400);
            this.ibu_tb.Name = "ibu_tb";
            this.ibu_tb.Size = new System.Drawing.Size(301, 22);
            this.ibu_tb.TabIndex = 35;
            // 
            // alamat_tb
            // 
            this.alamat_tb.Location = new System.Drawing.Point(161, 251);
            this.alamat_tb.Multiline = true;
            this.alamat_tb.Name = "alamat_tb";
            this.alamat_tb.Size = new System.Drawing.Size(301, 84);
            this.alamat_tb.TabIndex = 34;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(38, 857);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(71, 23);
            this.btShow.TabIndex = 33;
            this.btShow.Text = "Show Data";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(140, 668);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(71, 23);
            this.button_update.TabIndex = 32;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 701);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(40, 668);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(71, 23);
            this.btSave.TabIndex = 30;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tempat Lahir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nama Lengkap";
            // 
            // jeniskelamin_CB
            // 
            this.jeniskelamin_CB.FormattingEnabled = true;
            this.jeniskelamin_CB.Items.AddRange(new object[] {
            "LAKI-LAKI",
            "PEREMPUAN"});
            this.jeniskelamin_CB.Location = new System.Drawing.Point(161, 206);
            this.jeniskelamin_CB.Name = "jeniskelamin_CB";
            this.jeniskelamin_CB.Size = new System.Drawing.Size(301, 24);
            this.jeniskelamin_CB.TabIndex = 25;
            // 
            // tempatlahir_TB
            // 
            this.tempatlahir_TB.Location = new System.Drawing.Point(161, 110);
            this.tempatlahir_TB.Name = "tempatlahir_TB";
            this.tempatlahir_TB.Size = new System.Drawing.Size(301, 22);
            this.tempatlahir_TB.TabIndex = 23;
            // 
            // namaSiswa_TB
            // 
            this.namaSiswa_TB.Location = new System.Drawing.Point(161, 69);
            this.namaSiswa_TB.Name = "namaSiswa_TB";
            this.namaSiswa_TB.Size = new System.Drawing.Size(301, 22);
            this.namaSiswa_TB.TabIndex = 22;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(235, 668);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(71, 23);
            this.bt_Cancel.TabIndex = 51;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // inputDataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "inputDataSiswa";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.inputDataSiswa_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jeniskelamin_CB;
        private System.Windows.Forms.TextBox tempatlahir_TB;
        private System.Windows.Forms.TextBox namaSiswa_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox kelas_cb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox walikelas_cb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox statuskawin_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox agama_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomorortu_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ayah_tb;
        private System.Windows.Forms.TextBox ibu_tb;
        private System.Windows.Forms.TextBox alamat_tb;
        private System.Windows.Forms.DateTimePicker tglLahir_DTP;
        private System.Windows.Forms.Button bt_Cancel;
    }
}
