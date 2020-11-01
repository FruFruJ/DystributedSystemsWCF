using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLab4Aukcija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceAukcija : IServiceAukcija
    {
        public void odustajeKlijent(string id)
        {
            int i = 0;int pos = -1;
           
            foreach (Klijent k in Repository.Instance.lista)
            {
                if (k.Id.Equals(id))
                {
                    pos = i;
                }
                i++;
            }
            if(pos!=-1)
                Repository.Instance.lista.RemoveAt(pos);

        }

        public void postaviEksponat(string ime)
        {
            Repository.Instance.Eksponat = ime;
            Repository.Instance.lista.Clear();
        }

        public void povecajCenu(string id, float zaKoliko)
        {
            foreach(Klijent k in Repository.Instance.lista)
            {
                if(k.Id.Equals(id))
                {
                    k.Cena += zaKoliko;
                }
            }
        }

        public void prijaviKlijenta(string id, string ime, string prezime, float cena)
        {
            Repository.Instance.lista.Add(new Klijent()
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Cena = cena
            });
        }

        public string vratiEksponatIDPonudjivaca()
        {
            float max = 0;string idMax = "";
            foreach (Klijent k in Repository.Instance.lista)
            {
                if (k.Cena>max)
                {
                    max = k.Cena;
                    idMax=k.Id;
                }
            }
            return "Trenutni eksponat je " + Repository.Instance.Eksponat + " trenutna cena je " + max + " id Ponudjivaca je " +idMax;
              }
    }
}
