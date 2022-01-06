namespace _19SA1276_Encapsulation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.tbplat = new System.Windows.Forms.TextBox();
            this.tbspeed = new System.Windows.Forms.TextBox();
            this.tbmanuf = new System.Windows.Forms.TextBox();
            this.tbtahunproduksi = new System.Windows.Forms.TextBox();
            this.cbgasdanrem = new System.Windows.Forms.ComboBox();
            this.btgas = new System.Windows.Forms.Button();
            this.btrem = new System.Windows.Forms.Button();
            this.tbhasil = new System.Windows.Forms.TextBox();
            this.tbbensin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA KENDARAAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLAT NOMOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MANUFAKTUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TAHUN PRODUKSI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SPEED MAX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TINGKAT GAS/REM";
            // 
            // tbmodel
            // 
            this.tbmodel.Location = new System.Drawing.Point(132, 69);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(121, 20);
            this.tbmodel.TabIndex = 1;
            // 
            // tbplat
            // 
            this.tbplat.Location = new System.Drawing.Point(132, 43);
            this.tbplat.Name = "tbplat";
            this.tbplat.Size = new System.Drawing.Size(121, 20);
            this.tbplat.TabIndex = 1;
            // 
            // tbspeed
            // 
            this.tbspeed.Location = new System.Drawing.Point(132, 121);
            this.tbspeed.Name = "tbspeed";
            this.tbspeed.Size = new System.Drawing.Size(121, 20);
            this.tbspeed.TabIndex = 1;
            // 
            // tbmanuf
            // 
            this.tbmanuf.Location = new System.Drawing.Point(132, 95);
            this.tbmanuf.Name = "tbmanuf";
            this.tbmanuf.Size = new System.Drawing.Size(121, 20);
            this.tbmanuf.TabIndex = 1;
            // 
            // tbtahunproduksi
            // 
            this.tbtahunproduksi.Location = new System.Drawing.Point(132, 147);
            this.tbtahunproduksi.Name = "tbtahunproduksi";
            this.tbtahunproduksi.Size = new System.Drawing.Size(121, 20);
            this.tbtahunproduksi.TabIndex = 1;
            // 
            // cbgasdanrem
            // 
            this.cbgasdanrem.FormattingEnabled = true;
            this.cbgasdanrem.Items.AddRange(new object[] {
            "pelan",
            "sedang",
            "kuat"});
            this.cbgasdanrem.Location = new System.Drawing.Point(132, 199);
            this.cbgasdanrem.Name = "cbgasdanrem";
            this.cbgasdanrem.Size = new System.Drawing.Size(121, 21);
            this.cbgasdanrem.TabIndex = 2;
            // 
            // btgas
            // 
            this.btgas.Location = new System.Drawing.Point(49, 277);
            this.btgas.Name = "btgas";
            this.btgas.Size = new System.Drawing.Size(75, 23);
            this.btgas.TabIndex = 3;
            this.btgas.Text = "GAS";
            this.btgas.UseVisualStyleBackColor = true;
            this.btgas.Click += new System.EventHandler(this.btgas_Click);
            // 
            // btrem
            // 
            this.btrem.Location = new System.Drawing.Point(163, 277);
            this.btrem.Name = "btrem";
            this.btrem.Size = new System.Drawing.Size(75, 23);
            this.btrem.TabIndex = 4;
            this.btrem.Text = "REM";
            this.btrem.UseVisualStyleBackColor = true;
            this.btrem.Click += new System.EventHandler(this.btrem_Click);
            // 
            // tbhasil
            // 
            this.tbhasil.Location = new System.Drawing.Point(19, 306);
            this.tbhasil.Name = "tbhasil";
            this.tbhasil.Size = new System.Drawing.Size(234, 20);
            this.tbhasil.TabIndex = 5;
            // 
            // tbbensin
            // 
            this.tbbensin.Location = new System.Drawing.Point(132, 173);
            this.tbbensin.Name = "tbbensin";
            this.tbbensin.Size = new System.Drawing.Size(121, 20);
            this.tbbensin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "BENSIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.tbhasil);
            this.Controls.Add(this.btrem);
            this.Controls.Add(this.btgas);
            this.Controls.Add(this.cbgasdanrem);
            this.Controls.Add(this.tbplat);
            this.Controls.Add(this.tbbensin);
            this.Controls.Add(this.tbtahunproduksi);
            this.Controls.Add(this.tbmanuf);
            this.Controls.Add(this.tbspeed);
            this.Controls.Add(this.tbmodel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "19SA1276-Encapsulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.TextBox tbplat;
        private System.Windows.Forms.TextBox tbspeed;
        private System.Windows.Forms.TextBox tbmanuf;
        private System.Windows.Forms.TextBox tbtahunproduksi;
        private System.Windows.Forms.ComboBox cbgasdanrem;
        private System.Windows.Forms.Button btgas;
        private System.Windows.Forms.Button btrem;
        private System.Windows.Forms.TextBox tbhasil;
        private System.Windows.Forms.TextBox tbbensin;
        private System.Windows.Forms.Label label8;
    }
}

