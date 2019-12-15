namespace raporkuAPP
{
    partial class formAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOut = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btInputSiswa = new System.Windows.Forms.Button();
            this.btInputWali = new System.Windows.Forms.Button();
            this.inputDataWali1 = new raporkuAPP.inputDataWali();
            this.inputDataSiswa1 = new raporkuAPP.inputDataSiswa();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.btOut);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btInputSiswa);
            this.panel1.Controls.Add(this.btInputWali);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 753);
            this.panel1.TabIndex = 0;
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.btOut.Font = new System.Drawing.Font("Quantify", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(148)))), ((int)(((byte)(214)))));
            this.btOut.Location = new System.Drawing.Point(17, 683);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(160, 44);
            this.btOut.TabIndex = 31;
            this.btOut.Text = "LOGOUT";
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(119)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 72);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(17, 65);
            this.sidePanel.TabIndex = 2;
            // 
            // btInputSiswa
            // 
            this.btInputSiswa.FlatAppearance.BorderSize = 0;
            this.btInputSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInputSiswa.Font = new System.Drawing.Font("Quantify", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputSiswa.ForeColor = System.Drawing.Color.White;
            this.btInputSiswa.Location = new System.Drawing.Point(17, 140);
            this.btInputSiswa.Name = "btInputSiswa";
            this.btInputSiswa.Size = new System.Drawing.Size(183, 54);
            this.btInputSiswa.TabIndex = 3;
            this.btInputSiswa.Text = "Data Siswa";
            this.btInputSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInputSiswa.UseVisualStyleBackColor = true;
            this.btInputSiswa.Click += new System.EventHandler(this.btInputSiswa_Click);
            // 
            // btInputWali
            // 
            this.btInputWali.FlatAppearance.BorderSize = 0;
            this.btInputWali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInputWali.Font = new System.Drawing.Font("Quantify", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputWali.ForeColor = System.Drawing.Color.White;
            this.btInputWali.Location = new System.Drawing.Point(17, 80);
            this.btInputWali.Name = "btInputWali";
            this.btInputWali.Size = new System.Drawing.Size(183, 54);
            this.btInputWali.TabIndex = 2;
            this.btInputWali.Text = "Data Wali Kelas";
            this.btInputWali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInputWali.UseVisualStyleBackColor = true;
            this.btInputWali.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputDataWali1
            // 
            this.inputDataWali1.Location = new System.Drawing.Point(267, 80);
            this.inputDataWali1.Name = "inputDataWali1";
            this.inputDataWali1.Size = new System.Drawing.Size(488, 560);
            this.inputDataWali1.TabIndex = 1;
            // 
            // inputDataSiswa1
            // 
            this.inputDataSiswa1.Location = new System.Drawing.Point(267, 80);
            this.inputDataSiswa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDataSiswa1.Name = "inputDataSiswa1";
            this.inputDataSiswa1.Size = new System.Drawing.Size(488, 560);
            this.inputDataSiswa1.TabIndex = 2;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputDataWali1);
            this.Controls.Add(this.inputDataSiswa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN PAGE";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private inputDataWali inputDataWali1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btInputSiswa;
        private System.Windows.Forms.Button btInputWali;
        private inputDataSiswa inputDataSiswa1;
        private System.Windows.Forms.Button btOut;
    }
}