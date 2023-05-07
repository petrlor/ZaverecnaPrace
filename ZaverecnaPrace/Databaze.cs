using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaPrace
{
    class Databaze
    {
        private List<ZaznamPojist> zaznam;

        public Databaze()
        {
            zaznam = new List<ZaznamPojist>();
        }


        //Přídá nový záznam (vytvoří profil klienta)
        public void Vytvor(string jmeno, string prijmeni, int cislo, int vek) 
        { 
        zaznam.Add(new ZaznamPojist(jmeno, prijmeni, cislo, vek));
        }


        //Vyhledání klienta podle jména a příjméní
        public List<ZaznamPojist> NalezeniKlienta(string jmeno, string prijmeni) 
        { 
            //Najde a klienta a ve Třídě Pojištěnec je pokračování ----->
        List<ZaznamPojist> nalezeno = new List<ZaznamPojist>();
            foreach (ZaznamPojist p in zaznam) 
            { 
            if ((p.Jmeno == jmeno) && (p.Prijmeni == prijmeni))
                    nalezeno.Add(p);
            }
            return nalezeno;
        }

        //Vypis všech v záznamu. 
        public void Vypis()
        {
            //Projede celej záznam a napíše vše obsažené 
            foreach (ZaznamPojist zaznam in zaznam)
            {
                Console.WriteLine(zaznam);
            }
            if (!zaznam.Any())
            {
                Console.WriteLine("\n Nic tu není");
            }
        }

    }
}

