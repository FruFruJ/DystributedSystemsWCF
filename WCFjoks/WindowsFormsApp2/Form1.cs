using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ServiceReference1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ServiceReference1.CisternaClient proxy;
        public Form1()
        {
            InitializeComponent();
        }
      


        private void button3_Click(object sender, EventArgs e)
        {
            Materijal m = proxy.stanje();
            lbRo.Text = m.Ro.ToString("0.00");
            lbV.Text = m.V.ToString("0.00");
        }

        private void dodajMaterijal_Click(object sender, EventArgs e)
        {
            Materijal m = new Materijal()
            {
                Naziv = tbNaziv.Text,
                Ro = float.Parse(tbRoDodaj.Text),
                V = float.Parse(tbVDodaj.Text)
            };
            proxy.dodaj(m);
                        
        }

        private void smanjiMaterijal_Click(object sender, EventArgs e)
        {
            proxy.ispusti(float.Parse(tbVSmanji.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = proxy.svePromene();
            tbPromene.Text= string.Join(Environment.NewLine, p);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            proxy = new ServiceReference1.CisternaClient();
        }
    }
}
