using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFjoks
{
    public class Repository
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

        public float V { get; set; }
        public float Ro { get; set; }
        public List<String> Promene { get; set; }
        protected Repository()
        {
            V = 0;
            Ro = 0;
            Promene = new List<string>();
        }
    }

}
