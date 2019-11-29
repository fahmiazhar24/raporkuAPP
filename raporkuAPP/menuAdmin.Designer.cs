namespace raporkuAPP
{
    partial class menuAdmin
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
            this.btInputSiswa = new System.Windows.Forms.Button();
            this.btInputWali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInputSiswa
            // 
            this.btInputSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btInputSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btInputSiswa.Location = new System.Drawing.Point(90, 288);
            this.btInputSiswa.Name = "btInputSiswa";
            this.btInputSiswa.Size = new System.Drawing.Size(382, 44);
            this.btInputSiswa.TabIndex = 31;
            this.btInputSiswa.Text = "INPUT DATA SISWA";
            this.btInputSiswa.UseVisualStyleBackColor = false;
            this.btInputSiswa.Click += new System.EventHandler(this.btInputSiswa_Click);
            // 
            // btInputWali
            // 
            this.btInputWali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btInputWali.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputWali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btInputWali.Location = new System.Drawing.Point(90, 350);
            this.btInputWali.Name = "btInputWali";
            this.btInputWali.Size = new System.Drawing.Size(471, 44);
            this.btInputWali.TabIndex = 32;
            this.btInputWali.Text = "INPUT DATA WALI KELAS";
            this.btInputWali.UseVisualStyleBackColor = false;
            this.btInputWali.Click += new System.EventHandler(this.btInputWali_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btInputWali);
            this.Controls.Add(this.btInputSiswa);
            this.Name = "menuAdmin";
            this.Text = "menuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInputSiswa;
        private System.Windows.Forms.Button btInputWali;
    }
}