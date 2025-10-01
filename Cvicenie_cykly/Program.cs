using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Cvicenie_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.WriteLine("67");
            Console.WriteLine("67");
            Console.WriteLine("67");
            
            */






            /* Vypisovanie cisel od 0 do 100

                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(50 + i);
                }
            

            //od100 do  0 
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine( i);
            }
            */
            //Vypisanie cisla


            /*
            int i = 0;
            while (i <= 100)

            {
                Console.WriteLine("Michal" + i );
                i++;
            }
            */
            //Zapisovanie do konzole 
            /*
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "pozdrav")

                {
                    Console.WriteLine("ahoj");
                }

                else if (input == "exit")
                {
                    break;
                }
                
                else if (input == "koniec")

                {
                    break;
                }
            }*/

            /*
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Zadajte exit pre uoncenie");
                    string input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("Michal!");
                }
                Console.WriteLine("Zadajte koniec pre uoncenie");
                string inputDva = Console.ReadLine();
                if (inputDva == "koniec")
                {
                    break;
                }
                Console.WriteLine("Igor");
            }

            */


            /*
            for (int i = 1; i <= 40; i++)
            {
                string row = "";

                for (int  j  = 1; j <= i; j++)
                {
                    row += "*";
                    // row = row + "*"
                }

                Console.WriteLine(row);
            }
            */

            Console.WriteLine("Zadajte pocet riadkov");
            string cisloText = Console.ReadLine();
            Console.WriteLine("Zadajte znak");
            string znak = Console.ReadLine();
            int cislo = int.Parse(cisloText);
            for (int i = 1; i <= cislo; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)

                {
                    row += znak;
                }

                Console.WriteLine(row);


            }


        }
    }
}
