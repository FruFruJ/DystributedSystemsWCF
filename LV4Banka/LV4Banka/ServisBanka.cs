using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV4Banka
{
    public class ServisBanka : IServiceBanka
    {
        public float Isplata(float value)
        {
            
                Repository.Instance.Stanje -= value;
                return Repository.Instance.Stanje;
          
        }

        public List<string> listajPromene()
        {
            return Repository.Instance.Promene;
        }

        public void postaviVrednost(float vrednost)
        {
            Repository.Instance.Koeficijent = vrednost;
            Repository.Instance.Promene.Add($"Vreme:{DateTime.Now} OPERACIJA:postavljanje koeficijenta trenutna vrednost je {Repository.Instance.Stanje}");

        }

        public void Uplata(float value, string naziv, float koeficijent)
        {
            Repository.Instance.Stanje = Repository.Instance.Stanje / Repository.Instance.Koeficijent + value * koeficijent;
            Repository.Instance.Promene.Add($"Vreme:{DateTime.Now} OPERACIJA:uplata nova vrednost je {Repository.Instance.Stanje}");

        }
    }
}