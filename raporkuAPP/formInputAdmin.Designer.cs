namespace raporkuAPP
{
    partial class formInputAdmin
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
            this.namaWali_TB = new System.Windows.Forms.TextBox();
            this.userWali_TB = new System.Windows.Forms.TextBox();
            this.passWali_TB = new System.Windows.Forms.TextBox();
            this.Kelas_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // namaWali_TB
            // 
            this.namaWali_TB.Location = new System.Drawing.Point(253, 160);
            this.namaWali_TB.Name = "namaWali_TB";
            this.namaWali_TB.Size = new System.Drawing.Size(121, 22);
            this.namaWali_TB.TabIndex = 0;
            // 
            // userWali_TB
            // 
            this.userWali_TB.Location = new System.Drawing.Point(253, 201);
            this.userWali_TB.Name = "userWali_TB";
            this.userWali_TB.Size = new System.Drawing.Size(121, 22);
            this.userWali_TB.TabIndex = 1;
            // 
            // passWali_TB
            // 
            this.passWali_TB.Location = new System.Drawing.Point(253, 251);
            this.passWali_TB.Name = "passWali_TB";
            this.passWali_TB.Size = new System.Drawing.Size(121, 22);
            this.passWali_TB.TabIndex = 2;
            // 
            // Kelas_CB
            // 
            this.Kelas_CB.FormattingEnabled = true;
            this.Kelas_CB.Items.AddRange(new object[] {
            "IPA",
            "IPS"});
            this.Kelas_CB.Location = new System.Drawing.Point(253, 297);
            this.Kelas_CB.Name = "Kelas_CB";
            this.Kelas_CB.Size = new System.Drawing.Size(121, 24);
            this.Kelas_CB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kelas";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(133, 362);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // formInputAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
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
            this.Name = "formInputAdmin";
            this.Text = "formInputAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namaWali_TB;
        private System.Windows.Forms.TextBox userWali_TB;
        private System.Windows.Forms.TextBox passWali_TB;
        private System.Windows.Forms.ComboBox Kelas_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}