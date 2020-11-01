namespace EBankaInterface
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
            this.tbBrojRacuna = new System.Windows.Forms.TextBox();
            this.tbStanjeDinarski = new System.Windows.Forms.TextBox();
            this.tbEURDIN = new System.Windows.Forms.TextBox();
            this.tbDINEUR = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.tbStanjeDevizni = new System.Windows.Forms.TextBox();
            this.kreiraj = new System.Windows.Forms.Button();
            this.vratiDEV = new System.Windows.Forms.Button();
            this.vratiStanje = new System.Windows.Forms.Button();
            this.prebaciIznosDINDEV = new System.Windows.Forms.Button();
            this.vratiDin = new System.Windows.Forms.Button();
            this.prebaciIznosDEVDIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "brojRacuna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EURKADIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DINKAEUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "stanjeDinarski";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rezultat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "stanjeDevizni";
            // 
            // tbBrojRacuna
            // 
            this.tbBrojRacuna.Location = new System.Drawing.Point(171, 67);
            this.tbBrojRacuna.Name = "tbBrojRacuna";
            this.tbBrojRacuna.Size = new System.Drawing.Size(100, 22);
            this.tbBrojRacuna.TabIndex = 6;
            // 
            // tbStanjeDinarski
            // 
            this.tbStanjeDinarski.Location = new System.Drawing.Point(171, 116);
            this.tbStanjeDinarski.Name = "tbStanjeDinarski";
            this.tbStanjeDinarski.Size = new System.Drawing.Size(100, 22);
            this.tbStanjeDinarski.TabIndex = 7;
            // 
            // tbEURDIN
            // 
            this.tbEURDIN.Location = new System.Drawing.Point(560, 67);
            this.tbEURDIN.Name = "tbEURDIN";
            this.tbEURDIN.Size = new System.Drawing.Size(100, 22);
            this.tbEURDIN.TabIndex = 8;
            // 
            // tbDINEUR
            // 
            this.tbDINEUR.Location = new System.Drawing.Point(560, 128);
            this.tbDINEUR.Name = "tbDINEUR";
            this.tbDINEUR.Size = new System.Drawing.Size(100, 22);
            this.tbDINEUR.TabIndex = 9;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(155, 228);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(136, 22);
            this.tbRezultat.TabIndex = 10;
            // 
            // tbStanjeDevizni
            // 
            this.tbStanjeDevizni.Location = new System.Drawing.Point(171, 177);
            this.tbStanjeDevizni.Name = "tbStanjeDevizni";
            this.tbStanjeDevizni.Size = new System.Drawing.Size(100, 22);
            this.tbStanjeDevizni.TabIndex = 11;
            // 
            // kreiraj
            // 
            this.kreiraj.Location = new System.Drawing.Point(348, 70);
            this.kreiraj.Name = "kreiraj";
            this.kreiraj.Size = new System.Drawing.Size(75, 23);
            this.kreiraj.TabIndex = 12;
            this.kreiraj.Text = "Kreiraj";
            this.kreiraj.UseVisualStyleBackColor = true;
            this.kreiraj.Click += new System.EventHandler(this.kreiraj_Click);
            // 
            // vratiDEV
            // 
            this.vratiDEV.Location = new System.Drawing.Point(348, 343);
            this.vratiDEV.Name = "vratiDEV";
            this.vratiDEV.Size = new System.Drawing.Size(75, 23);
            this.vratiDEV.TabIndex = 13;
            this.vratiDEV.Text = "vratiDEV";
            this.vratiDEV.UseVisualStyleBackColor = true;
            this.vratiDEV.Click += new System.EventHandler(this.vratiDEV_Click);
            // 
            // vratiStanje
            // 
            this.vratiStanje.Location = new System.Drawing.Point(348, 122);
            this.vratiStanje.Name = "vratiStanje";
            this.vratiStanje.Size = new System.Drawing.Size(90, 23);
            this.vratiStanje.TabIndex = 14;
            this.vratiStanje.Text = "vratiStanje";
            this.vratiStanje.UseVisualStyleBackColor = true;
            this.vratiStanje.Click += new System.EventHandler(this.vratiStanje_Click);
            // 
            // prebaciIznosDINDEV
            // 
            this.prebaciIznosDINDEV.Location = new System.Drawing.Point(317, 177);
            this.prebaciIznosDINDEV.Name = "prebaciIznosDINDEV";
            this.prebaciIznosDINDEV.Size = new System.Drawing.Size(160, 23);
            this.prebaciIznosDINDEV.TabIndex = 15;
            this.prebaciIznosDINDEV.Text = "prebaciIznosDINDEV";
            this.prebaciIznosDINDEV.UseVisualStyleBackColor = true;
            this.prebaciIznosDINDEV.Click += new System.EventHandler(this.prebaciIznosDINDEV_Click);
            // 
            // vratiDin
            // 
            this.vratiDin.Location = new System.Drawing.Point(348, 290);
            this.vratiDin.Name = "vratiDin";
            this.vratiDin.Size = new System.Drawing.Size(75, 23);
            this.vratiDin.TabIndex = 16;
            this.vratiDin.Text = "vratiDin";
            this.vratiDin.UseVisualStyleBackColor = true;
            this.vratiDin.Click += new System.EventHandler(this.vratiDin_Click);
            // 
            // prebaciIznosDEVDIN
            // 
            this.prebaciIznosDEVDIN.Location = new System.Drawing.Point(317, 230);
            this.prebaciIznosDEVDIN.Name = "prebaciIznosDEVDIN";
            this.prebaciIznosDEVDIN.Size = new System.Drawing.Size(160, 23);
            this.prebaciIznosDEVDIN.TabIndex = 18;
            this.prebaciIznosDEVDIN.Text = "prebaciIznosDEVDIN";
            this.prebaciIznosDEVDIN.UseVisualStyleBackColor = true;
            this.prebaciIznosDEVDIN.Click += new System.EventHandler(this.prebaciIznosDEVDIN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prebaciIznosDEVDIN);
            this.Controls.Add(this.vratiDin);
            this.Controls.Add(this.prebaciIznosDINDEV);
            this.Controls.Add(this.vratiStanje);
            this.Controls.Add(this.vratiDEV);
            this.Controls.Add(this.kreiraj);
            this.Controls.Add(this.tbStanjeDevizni);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbDINEUR);
            this.Controls.Add(this.tbEURDIN);
            this.Controls.Add(this.tbStanjeDinarski);
            this.Controls.Add(this.tbBrojRacuna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox tbBrojRacuna;
        private System.Windows.Forms.TextBox tbStanjeDinarski;
        private System.Windows.Forms.TextBox tbEURDIN;
        private System.Windows.Forms.TextBox tbDINEUR;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.TextBox tbStanjeDevizni;
        private System.Windows.Forms.Button kreiraj;
        private System.Windows.Forms.Button vratiDEV;
        private System.Windows.Forms.Button vratiStanje;
        private System.Windows.Forms.Button prebaciIznosDINDEV;
        private System.Windows.Forms.Button vratiDin;
        private System.Windows.Forms.Button prebaciIznosDEVDIN;
    }
}

