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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.raporkuDataSet = new raporkuAPP.raporkuDataSet();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new raporkuAPP.raporkuDataSetTableAdapters.siswaTableAdapter();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporkuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btBack.Location = new System.Drawing.Point(17, 683);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(160, 44);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 750);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::raporkuAPP.Properties.Resources.Data_Siswa;
            this.pictureBox1.Location = new System.Drawing.Point(41, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 478);
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
            this.dataGridView1.Location = new System.Drawing.Point(205, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 260);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(205, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(669, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // raporkuDataSet
            // 
            this.raporkuDataSet.DataSetName = "raporkuDataSet";
            this.raporkuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "siswa";
            this.siswaBindingSource.DataSource = this.raporkuDataSet;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // tempatlahirDataGridViewTextBoxColumn
            // 
            this.tempatlahirDataGridViewTextBoxColumn.DataPropertyName = "Tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.HeaderText = "Tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempatlahirDataGridViewTextBoxColumn.Name = "tempatlahirDataGridViewTextBoxColumn";
            this.tempatlahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggallahirDataGridViewTextBoxColumn
            // 
            this.tanggallahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggallahirDataGridViewTextBoxColumn.Name = "tanggallahirDataGridViewTextBoxColumn";
            this.tanggallahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDkelasDataGridViewTextBoxColumn
            // 
            this.iDkelasDataGridViewTextBoxColumn.DataPropertyName = "ID_kelas";
            this.iDkelasDataGridViewTextBoxColumn.HeaderText = "ID_kelas";
            this.iDkelasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDkelasDataGridViewTextBoxColumn.Name = "iDkelasDataGridViewTextBoxColumn";
            this.iDkelasDataGridViewTextBoxColumn.Width = 125;
            // 
            // namasiswaDataGridViewTextBoxColumn
            // 
            this.namasiswaDataGridViewTextBoxColumn.DataPropertyName = "Nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.HeaderText = "Nama_siswa";
            this.namasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namasiswaDataGridViewTextBoxColumn.Name = "namasiswaDataGridViewTextBoxColumn";
            this.namasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDsiswaDataGridViewTextBoxColumn
            // 
            this.iDsiswaDataGridViewTextBoxColumn.DataPropertyName = "ID_siswa";
            this.iDsiswaDataGridViewTextBoxColumn.HeaderText = "ID_siswa";
            this.iDsiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDsiswaDataGridViewTextBoxColumn.Name = "iDsiswaDataGridViewTextBoxColumn";
            this.iDsiswaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDsiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDwalikelasDataGridViewTextBoxColumn
            // 
            this.iDwalikelasDataGridViewTextBoxColumn.DataPropertyName = "ID_wali_kelas";
            this.iDwalikelasDataGridViewTextBoxColumn.HeaderText = "ID_wali_kelas";
            this.iDwalikelasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDwalikelasDataGridViewTextBoxColumn.Name = "iDwalikelasDataGridViewTextBoxColumn";
            this.iDwalikelasDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaIbuDataGridViewTextBoxColumn
            // 
            this.namaIbuDataGridViewTextBoxColumn.DataPropertyName = "Nama_Ibu";
            this.namaIbuDataGridViewTextBoxColumn.HeaderText = "Nama_Ibu";
            this.namaIbuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaIbuDataGridViewTextBoxColumn.Name = "namaIbuDataGridViewTextBoxColumn";
            this.namaIbuDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorortuDataGridViewTextBoxColumn
            // 
            this.nomorortuDataGridViewTextBoxColumn.DataPropertyName = "Nomor_ortu";
            this.nomorortuDataGridViewTextBoxColumn.HeaderText = "Nomor_ortu";
            this.nomorortuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorortuDataGridViewTextBoxColumn.Name = "nomorortuDataGridViewTextBoxColumn";
            this.nomorortuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // statuskawinDataGridViewTextBoxColumn
            // 
            this.statuskawinDataGridViewTextBoxColumn.DataPropertyName = "status_kawin";
            this.statuskawinDataGridViewTextBoxColumn.HeaderText = "status_kawin";
            this.statuskawinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statuskawinDataGridViewTextBoxColumn.Name = "statuskawinDataGridViewTextBoxColumn";
            this.statuskawinDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaayahDataGridViewTextBoxColumn
            // 
            this.namaayahDataGridViewTextBoxColumn.DataPropertyName = "Nama_ayah";
            this.namaayahDataGridViewTextBoxColumn.HeaderText = "Nama_ayah";
            this.namaayahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaayahDataGridViewTextBoxColumn.Name = "namaayahDataGridViewTextBoxColumn";
            this.namaayahDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaagamaDataGridViewTextBoxColumn
            // 
            this.namaagamaDataGridViewTextBoxColumn.DataPropertyName = "Nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.HeaderText = "Nama_agama";
            this.namaagamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaagamaDataGridViewTextBoxColumn.Name = "namaagamaDataGridViewTextBoxColumn";
            this.namaagamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dataSiswa";
            this.Text = "dataSiswa";
            this.Load += new System.EventHandler(this.dataSiswa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporkuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
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
        private raporkuDataSet raporkuDataSet;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private raporkuDataSetTableAdapters.siswaTableAdapter siswaTableAdapter;
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