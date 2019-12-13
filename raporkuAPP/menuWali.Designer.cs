namespace raporkuAPP
{
    partial class menuWali
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
            this.btDataSiswa = new System.Windows.Forms.Button();
            this.btInputRapor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDataSiswa
            // 
            this.btDataSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btDataSiswa.Font = new System.Drawing.Font("Quantify", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btDataSiswa.Location = new System.Drawing.Point(90, 288);
            this.btDataSiswa.Name = "btDataSiswa";
            this.btDataSiswa.Size = new System.Drawing.Size(250, 44);
            this.btDataSiswa.TabIndex = 31;
            this.btDataSiswa.Text = "DATA SISWA";
            this.btDataSiswa.UseVisualStyleBackColor = false;
            this.btDataSiswa.Click += new System.EventHandler(this.btDataSiswa_Click);
            // 
            // btInputRapor
            // 
            this.btInputRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btInputRapor.Font = new System.Drawing.Font("Quantify", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputRapor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btInputRapor.Location = new System.Drawing.Point(90, 350);
            this.btInputRapor.Name = "btInputRapor";
            this.btInputRapor.Size = new System.Drawing.Size(338, 44);
            this.btInputRapor.TabIndex = 32;
            this.btInputRapor.Text = "INPUT DATA RAPOR";
            this.btInputRapor.UseVisualStyleBackColor = false;
            this.btInputRapor.Click += new System.EventHandler(this.btInputRapor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Quantify", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(90, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quantify", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(79, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 64);
            this.label1.TabIndex = 34;
            this.label1.Text = "MENU";
            // 
            // menuWali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::raporkuAPP.Properties.Resources.BACK_raporku1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btInputRapor);
            this.Controls.Add(this.btDataSiswa);
            this.DoubleBuffered = true;
            this.Name = "menuWali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDataSiswa;
        private System.Windows.Forms.Button btInputRapor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}