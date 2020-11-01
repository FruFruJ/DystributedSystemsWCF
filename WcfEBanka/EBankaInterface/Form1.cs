using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBankaInterface
{
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceEBankaClient proxy;
        public Form1()
        {
            InitializeComponent();
        }

        private void kreiraj_Click(object sender, EventArgs e)
        {
            proxy.kreirajRacun(tbBrojRacuna.Text, float.Parse(tbStanjeDinarski.Text), float.Parse(tbStanjeDevizni.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new ServiceReference1.ServiceEBankaClient();
        }

        private void vratiStanje_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = proxy.vratiStanje(tbBrojRacuna.Text);
        }

        private void prebaciIznosDINDEV_Click(object sender, EventArgs e)
        {
            proxy.prebaciSaDinarskog(tbBrojRacuna.Text, float.Parse(tbStanjeDinarski.Text), float.Parse(tbDINEUR.Text));

        }

        private void prebaciIznosDEVDIN_Click(object sender, EventArgs e)
        {
            proxy.prebaciSaDeviznog(tbBrojRacuna.Text, float.Parse(tbStanjeDevizni.Text), float.Parse(tbEURDIN.Text));
        }

        private void vratiDin_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = proxy.vratiIznosDinarski(tbBrojRacuna.Text);
        }

        private void vratiDEV_Click(object sender, EventArgs e)
        {
            tbRezultat.Text = proxy.vratiIznosDevizni(tbBrojRacuna.Text);
        }
    }
}
