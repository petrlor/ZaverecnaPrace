using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaPrace
{

    class Pojistenec
    {
        private Databaze databaze;


        public Pojistenec()
        {
            databaze = new Databaze();
          
        }
        public void Vytvor()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojistěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojistěného:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo:");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk :");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Data byla uložena. Pokračujte stisknutím libovolnou klávesou....");
            Console.ReadLine();
            //zapsání údajů do listu databáze v záznamu
            databaze.Vytvor(jmeno, prijmeni, cislo, vek);

        }

        public void Hledat() 

        {
            //Podle jména a Příjmení vyhledá klienta ze záznamu. Základ je v Databáze
            Console.WriteLine();
            Console.WriteLine("Vyhledávám:");         
            Console.WriteLine("Zadej jméno klienta");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení klienta");
            string prijmeni = Console.ReadLine();

            List<ZaznamPojist> nalezeno = databaze.NalezeniKlienta(jmeno, prijmeni);
            if (nalezeno.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy:");
                foreach (ZaznamPojist z in nalezeno)
                    Console.WriteLine(z);
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }
        public void Vypis()
        {
            databaze.Vypis();
           
            
        }
    }
}

