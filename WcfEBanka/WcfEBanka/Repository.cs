using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfEBanka
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

      
        public List<Racun> Racuni { get; set; }
        protected Repository()
        {
            Racuni = new List<Racun>();
        }
    }
}
