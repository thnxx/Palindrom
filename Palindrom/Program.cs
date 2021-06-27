using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {

        static void Main(string[] args)
        {

            dongu();
            Console.ReadLine();
        }

        static void dongu()
        {


            while (true)
            {
                Console.WriteLine("Kelime giriniz(Cikis:q):");
                string kelime;
                kelime = Console.ReadLine();
                if (kelime!="q")
                {
                    kontrolYapisi(kelime);
                }
                else
                {
                    Console.WriteLine("Cikis yapiliyor...");
                    break;
                }
                
            }
            
        }

        static bool kacKelime(String kelime)
        {
            if (kelime.Length <= 2)
            {

                return false;

            }




            return true;

        }

        static void kontrolYapisi(String kelime)
        {
            string tersten = "";
            if (kacKelime(kelime))
            {
                for (int i = 0; i < kelime.Length; i++)
                {
                    tersten += kelime[kelime.Length - 1 - i];
                }

                if (tersten == kelime)
                {
                    Console.WriteLine("Palindromdur.Kelime: " + kelime + " " +
                                      "Tersen: " + tersten);
                }
                else
                {
                    Console.WriteLine("Palindrom degildir..Kelime: " + kelime + " " +
                                      "Tersen: " + tersten);
                }
            }

        }



    }
}
