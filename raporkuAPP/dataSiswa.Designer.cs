namespace raporkuAPP
{
    partial class dataSiswa
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
            this.components = new System.ComponentModel.Container();
            this.btBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tempatlahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggallahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDsiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDwalikelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaIbuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorortuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuskawinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaayahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaagamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporkuDataSet1 = new raporkuAPP.raporkuDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.siswaTableAdapter = new raporkuAPP.raporkuDataSet1TableAdapters.siswaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporkuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btBack.Location = new System.Drawing.Point(13, 555);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(120, 36);
            this.btBack.TabIndex = 31;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 609);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::raporkuAPP.Properties.Resources.Data_Siswa;
            this.pictureBox1.Location = new System.Drawing.Point(31, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 388);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tempatlahirDataGridViewTextBoxColumn,
            this.tanggallahirDataGridViewTextBoxColumn,
            this.iDkelasDataGridViewTextBoxColumn,
            this.namasiswaDataGridViewTextBoxColumn,
            this.iDsiswaDataGridViewTextBoxColumn,
            this.iDwalikelasDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.namaIbuDataGridViewTextBoxColumn,
            this.nomorortuDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.statuskawinDataGridViewTextBoxColumn,
            this.namaayahDataGridViewTextBoxColumn,
            this.namaagamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tempatlahirDataGridViewTextBoxColumn
            // 
            this.tempatlahirDataGridViewTextBoxColumn.DataPropertyName = "Tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.HeaderText = "Tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.Name = "tempatlahirDataGridViewTextBoxColumn";
            // 
            // tanggallahirDataGridViewTextBoxColumn
            // 
            this.tanggallahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.Name = "tanggallahirDataGridViewTextBoxColumn";
            // 
            // iDkelasDataGridViewTextBoxColumn
            // 
            this.iDkelasDataGridViewTextBoxColumn.DataPropertyName = "ID_kelas";
            this.iDkelasDataGridViewTextBoxColumn.HeaderText = "ID_kelas";
            this.iDkelasDataGridViewTextBoxColumn.Name = "iDkelasDataGridViewTextBoxColumn";
            // 
            // namasiswaDataGridViewTextBoxColumn
            // 
            this.namasiswaDataGridViewTextBoxColumn.DataPropertyName = "Nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.HeaderText = "Nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.Name = "namasiswaDataGridViewTextBoxColumn";
            // 
            // iDsiswaDataGridViewTextBoxColumn
            // 
            this.iDsiswaDataGridViewTextBoxColumn.DataPropertyName = "ID_siswa";
            this.iDsiswaDataGridViewTextBoxColumn.HeaderText = "ID_siswa";
            this.iDsiswaDataGridViewTextBoxColumn.Name = "iDsiswaDataGridViewTextBoxColumn";
            this.iDsiswaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDwalikelasDataGridViewTextBoxColumn
            // 
            this.iDwalikelasDataGridViewTextBoxColumn.DataPropertyName = "ID_wali_kelas";
            this.iDwalikelasDataGridViewTextBoxColumn.HeaderText = "ID_wali_kelas";
            this.iDwalikelasDataGridViewTextBoxColumn.Name = "iDwalikelasDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // namaIbuDataGridViewTextBoxColumn
            // 
            this.namaIbuDataGridViewTextBoxColumn.DataPropertyName = "Nama_Ibu";
            this.namaIbuDataGridViewTextBoxColumn.HeaderText = "Nama_Ibu";
            this.namaIbuDataGridViewTextBoxColumn.Name = "namaIbuDataGridViewTextBoxColumn";
            // 
            // nomorortuDataGridViewTextBoxColumn
            // 
            this.nomorortuDataGridViewTextBoxColumn.DataPropertyName = "Nomor_ortu";
            this.nomorortuDataGridViewTextBoxColumn.HeaderText = "Nomor_ortu";
            this.nomorortuDataGridViewTextBoxColumn.Name = "nomorortuDataGridViewTextBoxColumn";
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            // 
            // statuskawinDataGridViewTextBoxColumn
            // 
            this.statuskawinDataGridViewTextBoxColumn.DataPropertyName = "status_kawin";
            this.statuskawinDataGridViewTextBoxColumn.HeaderText = "status_kawin";
            this.statuskawinDataGridViewTextBoxColumn.Name = "statuskawinDataGridViewTextBoxColumn";
            // 
            // namaayahDataGridViewTextBoxColumn
            // 
            this.namaayahDataGridViewTextBoxColumn.DataPropertyName = "Nama_ayah";
            this.namaayahDataGridViewTextBoxColumn.HeaderText = "Nama_ayah";
            this.namaayahDataGridViewTextBoxColumn.Name = "namaayahDataGridViewTextBoxColumn";
            // 
            // namaagamaDataGridViewTextBoxColumn
            // 
            this.namaagamaDataGridViewTextBoxColumn.DataPropertyName = "Nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.HeaderText = "Nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.Name = "namaagamaDataGridViewTextBoxColumn";
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "siswa";
            this.siswaBindingSource.DataSource = this.raporkuDataSet1;
            // 
            // raporkuDataSet1
            // 
            this.raporkuDataSet1.DataSetName = "raporkuDataSet1";
            this.raporkuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(502, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dataSiswa";
            this.Text = "dataSiswa";
            this.Load += new System.EventHandler(this.dataSiswa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporkuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private raporkuDataSet1 raporkuDataSet1;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private raporkuDataSet1TableAdapters.siswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatlahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggallahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDwalikelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaIbuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorortuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuskawinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaayahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaagamaDataGridViewTextBoxColumn;
    }
}