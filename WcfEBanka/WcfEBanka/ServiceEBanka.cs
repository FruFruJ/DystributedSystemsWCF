using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfEBanka
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceEBanka : IServiceEBanka
    {
        public void kreirajRacun(string brRacuna, float dinarski, float devizni)
        {
            Repository.Instance.Racuni.Add(new Racun()
            {
                BrRacuna = brRacuna,
                Dinarski = dinarski,
                Devizni = devizni
            });
        }

        public void prebaciSaDeviznog(string racun, float kolicina, float EURDIN)
        {
           foreach(Racun rac in Repository.Instance.Racuni)
            {
                if(rac.BrRacuna.Equals(racun))
                {
                    rac.Devizni -= kolicina;
                    rac.Dinarski += kolicina * EURDIN;
                }
            }
        }

        public void prebaciSaDinarskog(string racun, float kolicina, float EURDIN)
        {
            foreach (Racun rac in Repository.Instance.Racuni)
            {
                if (rac.BrRacuna.Equals(racun))
                {
                    rac.Dinarski -= kolicina;
                    rac.Devizni += kolicina / EURDIN;
                }
            }
        }

        public string vratiIznosDevizni(string brRacuna)
        {
            foreach (Racun rac in Repository.Instance.Racuni)
            {
                if (rac.BrRacuna.Equals(brRacuna))
                {
                    return "Devizni racun je"+rac.Devizni.ToString();
                }
            }
            return "Nema tog racuna";
        }

        public string vratiIznosDinarski(string brRacuna)
        {
            foreach (Racun rac in Repository.Instance.Racuni)
            {
                if (rac.BrRacuna.Equals(brRacuna))
                {
                    return "Dinarski racun je "+rac.Dinarski.ToString();
                }
            }
            return "Nema tog racuna";
        }

        public string vratiStanje(string brRacuna)
        {
            foreach (Racun rac in Repository.Instance.Racuni)
            {
                if (rac.BrRacuna.Equals(brRacuna))
                {
                    return "Dinarski racun je " + rac.Dinarski.ToString() +" a ovo je Devizni "+rac.Devizni.ToString();
                }
            }
            return "Nema tog racuna";
        }
    }
}
