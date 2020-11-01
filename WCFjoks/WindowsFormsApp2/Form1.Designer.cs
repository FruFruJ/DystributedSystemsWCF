namespace WindowsFormsApp2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dodajMaterijal = new System.Windows.Forms.Button();
            this.smanjiMaterijal = new System.Windows.Forms.Button();
            this.preuzmiTrenutno = new System.Windows.Forms.Button();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbRoDodaj = new System.Windows.Forms.TextBox();
            this.tbVSmanji = new System.Windows.Forms.TextBox();
            this.lbV = new System.Windows.Forms.Label();
            this.tbVDodaj = new System.Windows.Forms.TextBox();
            this.tbPromene = new System.Windows.Forms.TextBox();
            this.lbRo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 171);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ro";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dodajMaterijal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.smanjiMaterijal, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.preuzmiTrenutno, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbRoDodaj, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbVSmanji, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbV, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbVDodaj, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPromene, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbRo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // dodajMaterijal
            // 
            this.dodajMaterijal.Location = new System.Drawing.Point(3, 85);
            this.dodajMaterijal.Name = "dodajMaterijal";
            this.dodajMaterijal.Size = new System.Drawing.Size(137, 42);
            this.dodajMaterijal.TabIndex = 7;
            this.dodajMaterijal.Text = "dodajMaterijal";
            this.dodajMaterijal.UseVisualStyleBackColor = true;
            this.dodajMaterijal.Click += new System.EventHandler(this.dodajMaterijal_Click);
            // 
            // smanjiMaterijal
            // 
            this.smanjiMaterijal.Location = new System.Drawing.Point(3, 170);
            this.smanjiMaterijal.Name = "smanjiMaterijal";
            this.smanjiMaterijal.Size = new System.Drawing.Size(137, 31);
            this.smanjiMaterijal.TabIndex = 8;
            this.smanjiMaterijal.Text = "smanji";
            this.smanjiMaterijal.UseVisualStyleBackColor = true;
            this.smanjiMaterijal.Click += new System.EventHandler(this.smanjiMaterijal_Click);
            // 
            // preuzmiTrenutno
            // 
            this.preuzmiTrenutno.Location = new System.Drawing.Point(3, 207);
            this.preuzmiTrenutno.Name = "preuzmiTrenutno";
            this.preuzmiTrenutno.Size = new System.Drawing.Size(137, 31);
            this.preuzmiTrenutno.TabIndex = 9;
            this.preuzmiTrenutno.Text = "preuzmiTrenutno";
            this.preuzmiTrenutno.UseVisualStyleBackColor = true;
            this.preuzmiTrenutno.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(146, 3);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(203, 22);
            this.tbNaziv.TabIndex = 10;
            // 
            // tbRoDodaj
            // 
            this.tbRoDodaj.Location = new System.Drawing.Point(146, 62);
            this.tbRoDodaj.Name = "tbRoDodaj";
            this.tbRoDodaj.Size = new System.Drawing.Size(203, 22);
            this.tbRoDodaj.TabIndex = 12;
            // 
            // tbVSmanji
            // 
            this.tbVSmanji.Location = new System.Drawing.Point(146, 143);
            this.tbVSmanji.Name = "tbVSmanji";
            this.tbVSmanji.Size = new System.Drawing.Size(203, 22);
            this.tbVSmanji.TabIndex = 13;
            // 
            // lbV
            // 
            this.lbV.AutoSize = true;
            this.lbV.Location = new System.Drawing.Point(146, 243);
            this.lbV.Name = "lbV";
            this.lbV.Size = new System.Drawing.Size(46, 17);
            this.lbV.TabIndex = 14;
            this.lbV.Text = "label7";
            // 
            // tbVDodaj
            // 
            this.tbVDodaj.Location = new System.Drawing.Point(146, 32);
            this.tbVDodaj.Name = "tbVDodaj";
            this.tbVDodaj.Size = new System.Drawing.Size(203, 22);
            this.tbVDodaj.TabIndex = 11;
            // 
            // tbPromene
            // 
            this.tbPromene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPromene.Location = new System.Drawing.Point(355, 62);
            this.tbPromene.Multiline = true;
            this.tbPromene.Name = "tbPromene";
            this.tableLayoutPanel1.SetRowSpan(this.tbPromene, 7);
            this.tbPromene.Size = new System.Drawing.Size(442, 385);
            this.tbPromene.TabIndex = 17;
            // 
            // lbRo
            // 
            this.lbRo.AutoSize = true;
            this.lbRo.Location = new System.Drawing.Point(146, 279);
            this.lbRo.Name = "lbRo";
            this.lbRo.Size = new System.Drawing.Size(46, 17);
            this.lbRo.TabIndex = 15;
            this.lbRo.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Promene";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Prikazi promene";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dodajMaterijal;
        private System.Windows.Forms.Button smanjiMaterijal;
        private System.Windows.Forms.Button preuzmiTrenutno;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbVDodaj;
        private System.Windows.Forms.TextBox tbRoDodaj;
        private System.Windows.Forms.TextBox tbVSmanji;
        private System.Windows.Forms.Label lbV;
        private System.Windows.Forms.Label lbRo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPromene;
        private System.Windows.Forms.Button button1;
    }
}

