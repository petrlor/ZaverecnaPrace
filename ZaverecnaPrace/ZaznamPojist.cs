using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaPrace
{

    class ZaznamPojist
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Cislo { get; set; }
        public int Vek { get; set; }

        public ZaznamPojist(string jmeno, string prijmeni, int cislo, int vek)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Cislo = cislo;
            this.Vek = vek;
        }

        //Vypsání Záznamu
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine();
            return Jmeno + "\t" + Prijmeni + "\t" + Cislo;
        }
    }
}
