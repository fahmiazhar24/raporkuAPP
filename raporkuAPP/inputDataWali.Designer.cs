namespace raporkuAPP
{
    partial class inputDataWali
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kelas_CB = new System.Windows.Forms.ComboBox();
            this.passWali_TB = new System.Windows.Forms.TextBox();
            this.userWali_TB = new System.Windows.Forms.TextBox();
            this.namaWali_TB = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(46, 292);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama Lengkap";
            // 
            // Kelas_CB
            // 
            this.Kelas_CB.FormattingEnabled = true;
            this.Kelas_CB.Items.AddRange(new object[] {
            "IPA",
            "IPS"});
            this.Kelas_CB.Location = new System.Drawing.Point(166, 227);
            this.Kelas_CB.Name = "Kelas_CB";
            this.Kelas_CB.Size = new System.Drawing.Size(301, 24);
            this.Kelas_CB.TabIndex = 13;
            // 
            // passWali_TB
            // 
            this.passWali_TB.Location = new System.Drawing.Point(166, 181);
            this.passWali_TB.Name = "passWali_TB";
            this.passWali_TB.Size = new System.Drawing.Size(301, 22);
            this.passWali_TB.TabIndex = 12;
            // 
            // userWali_TB
            // 
            this.userWali_TB.Location = new System.Drawing.Point(166, 131);
            this.userWali_TB.Name = "userWali_TB";
            this.userWali_TB.Size = new System.Drawing.Size(301, 22);
            this.userWali_TB.TabIndex = 11;
            // 
            // namaWali_TB
            // 
            this.namaWali_TB.Location = new System.Drawing.Point(166, 90);
            this.namaWali_TB.Name = "namaWali_TB";
            this.namaWali_TB.Size = new System.Drawing.Size(301, 22);
            this.namaWali_TB.TabIndex = 10;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(166, 292);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 20;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(39, 526);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 21;
            this.btShow.Text = "Show Data";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // inputDataWali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kelas_CB);
            this.Controls.Add(this.passWali_TB);
            this.Controls.Add(this.userWali_TB);
            this.Controls.Add(this.namaWali_TB);
            this.Name = "inputDataWali";
            this.Size = new System.Drawing.Size(500, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Kelas_CB;
        private System.Windows.Forms.TextBox passWali_TB;
        private System.Windows.Forms.TextBox userWali_TB;
        private System.Windows.Forms.TextBox namaWali_TB;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button btShow;
    }
}
