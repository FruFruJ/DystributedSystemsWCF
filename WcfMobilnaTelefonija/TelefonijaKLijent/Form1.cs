using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonijaKLijent
{
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceOperaterClient proxy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy.dodajRacun(tbBrojRac.Text, int.Parse(tbMin.Text), int.Parse(tbPoruke.Text), int.Parse(tbMb.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new ServiceReference1.ServiceOperaterClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proxy.dodajMinute(tbBrojRac.Text, int.Parse(tbMin.Text), float.Parse(tbMinTarifa.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proxy.dodajPoruke(tbBrojRac.Text, int.Parse(tbPoruke.Text), float.Parse(tbPorukeTarifa.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proxy.dodajInternet(tbBrojRac.Text, int.Parse(tbMb.Text), float.Parse(tbMBTarifa.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = proxy.vratiStanje(tbBrojRac.Text);
        }
    }
}
