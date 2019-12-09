namespace raporkuAPP
{
    partial class raporku
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
            this.btBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btReport = new System.Windows.Forms.Button();
            this.btInpuNilai = new System.Windows.Forms.Button();
            this.nilaiRapor1 = new raporkuAPP.NilaiRapor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btBack.Font = new System.Drawing.Font("Quantify", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btBack.Location = new System.Drawing.Point(17, 683);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(160, 44);
            this.btBack.TabIndex = 31;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btReport);
            this.panel1.Controls.Add(this.btInpuNilai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 753);
            this.panel1.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 72);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(17, 65);
            this.sidePanel.TabIndex = 2;
            // 
            // btReport
            // 
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Quantify", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.ForeColor = System.Drawing.Color.White;
            this.btReport.Location = new System.Drawing.Point(17, 140);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(183, 54);
            this.btReport.TabIndex = 3;
            this.btReport.Text = "Report Rapor";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btInpuNilai
            // 
            this.btInpuNilai.FlatAppearance.BorderSize = 0;
            this.btInpuNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInpuNilai.Font = new System.Drawing.Font("Quantify", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInpuNilai.ForeColor = System.Drawing.Color.White;
            this.btInpuNilai.Location = new System.Drawing.Point(17, 80);
            this.btInpuNilai.Name = "btInpuNilai";
            this.btInpuNilai.Size = new System.Drawing.Size(183, 54);
            this.btInpuNilai.TabIndex = 2;
            this.btInpuNilai.Text = "Data Rapor";
            this.btInpuNilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInpuNilai.UseVisualStyleBackColor = true;
            this.btInpuNilai.Click += new System.EventHandler(this.btInputNilai_Click);
            // 
            // nilaiRapor1
            // 
            this.nilaiRapor1.Location = new System.Drawing.Point(239, 61);
            this.nilaiRapor1.Name = "nilaiRapor1";
            this.nilaiRapor1.Size = new System.Drawing.Size(500, 600);
            this.nilaiRapor1.TabIndex = 2;
            // 
            // raporku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.nilaiRapor1);
            this.Controls.Add(this.panel1);
            this.Name = "raporku";
            this.Text = "raporku";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btInpuNilai;
        private NilaiRapor nilaiRapor1;
    }
}