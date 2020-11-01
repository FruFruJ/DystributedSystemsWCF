using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobilnaTelefonija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceOperater : IServiceOperater
    {
        public void dodajInternet(string racun, int mb, float tarifa)
        {
            foreach(TelRacun rac in Repository.Instance.lista)
            {
                if(rac.BRRacuna.Equals(racun))
                {
                    rac.Internet += mb;
                    rac.StanjeRacuna += tarifa * mb;
                }
            }
        }

        public void dodajMinute(string racun, int minuti, float tarifa)
        {
            foreach (TelRacun rac in Repository.Instance.lista)
            {
                if (rac.BRRacuna.Equals(racun))
                {
                    rac.Minuti += minuti;
                    rac.StanjeRacuna += tarifa * minuti;
                }
            }
        }

        public void dodajPoruke(string racun, int poruke, float tarifa)
        {
            foreach (TelRacun rac in Repository.Instance.lista)
            {
                if (rac.BRRacuna.Equals(racun))
                {
                    rac.Poruke += poruke;
                    rac.StanjeRacuna += tarifa * poruke;
                }
            }
        }

        public void dodajRacun(string brRacuna, int min, int poruke, int mb)
        {
            Repository.Instance.lista.Add  (new TelRacun()
            {
                BRRacuna = brRacuna,
                Minuti=min,
                Poruke=poruke,
                Internet=mb,
                StanjeRacuna=0
            });
        }

        public string vratiStanje(string racun)
        {
            foreach (TelRacun rac in Repository.Instance.lista)
            {
                if (rac.BRRacuna.Equals(racun))
                {
                    return $"Stanje racuna sa brojem Racuna {rac.BRRacuna} i interneta ima {rac.Internet} Minuta ima {rac.Minuti} poruka ima {rac.Poruke} stanje je {rac.StanjeRacuna}";
                }
            }
            return "nema tog racuna";
        }
    }
}
