using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentAukcija
{
    public partial class Form1 : Form
    {
        ServiceReference2.ServiceAukcijaClient proxy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proxy.postaviEksponat(Eksponat.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new ServiceReference2.ServiceAukcijaClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy.prijaviKlijenta(tbIdDodaj.Text, tbIme.Text, tbPrezime.Text, float.Parse(tbSuma.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbVratiEksponat.Text = proxy.vratiEksponatIDPonudjivaca();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proxy.odustajeKlijent(tbIdOdustani.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proxy.povecajCenu(tbIdUvecaj.Text, float.Parse(tbUvecanje.Text));
        }
    }
}
