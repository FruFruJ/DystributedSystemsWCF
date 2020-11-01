using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfLab4Aukcija
{
    class Repository
    {
        private static Repository instance;
        private static object locker = true;

        public static Repository Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new Repository();
                }
                return instance;
            }
        }
        public string Eksponat { get; set; }
        public List<Klijent> lista;
        protected Repository()
        {
            lista = new List<Klijent>();
        }

    }
}
