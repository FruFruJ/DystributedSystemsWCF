using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFjoks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Cisterna : ICisterna
    {
        public void dodaj(Materijal m)
        {
            float masa = m.V * m.Ro + Repository.Instance.Ro * Repository.Instance.V;
            Repository.Instance.V = m.V + Repository.Instance.V;
            Repository.Instance.Ro = masa / Repository.Instance.V;
            Repository.Instance.Promene.Add($"Vreme je { DateTime.Now} OPERACIJA:dodavanje  materijal {m.Naziv} sa Ro={m.Ro} i sa V={m.V}");
        }

        public void ispusti(float v)
        {
         if(Repository.Instance.V-v>0)
            {
                Repository.Instance.V -= v;
                Repository.Instance.Promene.Add($"Vreme je {DateTime.Now} OPERACIJA:ispustanje KOLICINA:{v} trenutna kolicina je {Repository.Instance.V} ");
            }
            else
            {
                Repository.Instance.V = 0;
                Repository.Instance.Promene.Add($"Vreme je {DateTime.Now} OPERACIJA:ispustanje KOLICINA:{Repository.Instance.V} trazena kolicina je bila previse trenutno stanje je 0 ");

            }
        }

        public Materijal stanje()
        {
            return new Materijal()
            {
                V = Repository.Instance.V,
                Ro = Repository.Instance.Ro
            };
        }

        public List<string> svePromene()
        {
            return Repository.Instance.Promene;
        }
    }
}
