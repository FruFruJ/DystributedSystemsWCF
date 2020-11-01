using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV4Banka
{
    public class Repository
    {
        private static Repository instance;
        private static object locker;
        public static Repository Instance
        {
            get
            {
                lock(locker)
                {
                    if (instance == null)
                        instance = new Repository();
                }
                return instance;
            }
        }
        public float Stanje { get; set; }
        public float Koeficijent { get; set; }
        public List<string> Promene;
    }
}