using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;

namespace cvicenie_subory
{
    internal class Program
    {
        /*static void Main()
        {
            string[] text = File.ReadAllLines("People_100.csv");
        }

        public static void MoneyCountAverage(string[] text)
        {
            int sum = 0;
            foreach (string linee in text.Skip(1))
            {
                string[] splits = linee.Split(";");
                int accountValue=int.Parse(splits[4]);
                sum += accountValue;
            }
            Console.WriteLine(sum/ (text.Count() - 1 ));
        }


         string[] text = File.ReadAllLines("People_100.csv");
              int sum = 0;
              foreach (string line in text.Skip(1))

              {
                  string[] splits = line.Split(";");
                 //prekonvertovanie hodnoty z retazca na cislo
               int accountValue = int.Parse(splits[4]);
                  //scitanie int hodnoty so sum-om
                 sum += accountValue;
              }
              Console.WriteLine(sum/(text.Count()-1));
        

        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("People_100.csv");
            RodneCislo(text);

        }
        public static void RodneCislo(string[] text)
        {
            foreach (string line in text.Skip(1))
            {
                string[] splistT = line.Split(";");
                Console.WriteLine(splistT[2]);
            }


        }      
        

        static void Main(string[] args)
        {

            string[] text = File.ReadAllLines("People_100.csv");
            /*
            MoneyCountAverage(text);
            /
            /
            WriteRodneCislo(text);
            

            MinMoneyCount(text);
        }
        public static void MoneyCountAverage(string[] text)
        {
            int sum = 0;
            foreach (string line in text.Skip(1))
            {
                //Martin,Urban, 690602/2315,Presov,463102,slobodny
                string[] splits = line.Split(";");
                //prekonvertovanie hodnoty z retazca na cislo
                int accountValue = int.Parse(splits[4]);
                //scitanie int hodnoty so sum-om
                sum += accountValue;

            }
            Console.WriteLine(sum / (text.Count() - 1));



        }

        public static void WriteRodneCislo(string[] text)
        {
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");

                string RodneCisla = splits[2];
                Console.WriteLine(RodneCisla);
            }

        }
        public static void MinMoneyCount(string[] text)
        {
            int minValue = 9999999;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");

                int accountValue = int.Parse(splits[4]);

                if (accountValue < minValue)
                {
                    minValue = accountValue;
                    minValuePerson = splits[0] + " " + splits[1];
                }
            }
            Console.WriteLine(minValuePerson);
            */


        public static void MinMoneyCount(string[] text)
        {
            int minValue = 500000;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");

                int accountValue = int.Parse(splits[4]);

                if (accountValue < minValue)
                {
                    minValue = accountValue;
                    minValuePerson = splits[0] + " " + splits[1];
                    Console.WriteLine(minValuePerson);
                }

            }

        }




    }













}
