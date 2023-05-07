global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace ZaverecnaPrace
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pojistenec p = new Pojistenec();
            char volba = '0';
            while (volba != '4')
            {
                //popsání možnosti voleb
                Console.WriteLine("--------------------");
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojistného");
                Console.WriteLine("2 - Vypsat vsechny pojistěné");            
                Console.WriteLine("3 - Vyhledat pojistěného");
                Console.WriteLine("4 - Konec");
                Console.WriteLine("]|__|--|__|--|__|[");
                volba = Console.ReadKey().KeyChar;


                // reakce na volbu
                switch (volba)
                {
                    case '1':
                     p.Vytvor()  ;
                        break;
                    case '2':
                      p.Vypis();
                        break;
                    case '3':
                       p.Hledat();
                        break;
                    case '4':
                        Console.WriteLine("\n Program se vypne...");                       
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }

            }

        }


    }
}

