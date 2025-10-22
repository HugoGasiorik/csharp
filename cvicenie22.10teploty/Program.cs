namespace cvicenie22._10teploty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> teploty = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };

            List<int> kladneTeploty = new List<int>();
            foreach (int teplota in teploty)
            {
                if (teplota >= 0)
                {
                    kladneTeploty.Add(teplota);
                }
            }
            Console.WriteLine("Kladne: ");
            foreach (var i in kladneTeploty)
            {
                Console.Write(i);
            }

            int max = int.MinValue;
            foreach (int teplota in teploty)
            {
                if (teplota > max)
                {
                    max = teplota;
                }
            }
            Console.WriteLine("maximalna teplota je " + max);

            int min = int.MaxValue;
            foreach (int teplota in teploty)
            {
                if (teplota < min)
                {
                    min = teplota;
                }
            }
            Console.WriteLine("minimalna teplota je " + min);

            int sum = 0;
            foreach (int teplota in teploty)
            {
                sum += teplota;
            }
            int pocet = teploty.Count;
            double priemer = (double)sum / pocet;
            Console.WriteLine("priemer: " + priemer);



            string riadok = "";
            foreach (int teplota in teploty)
            {
                riadok += teplota + ", ";
            }

            int pocetNad = 0;
            foreach (int teplota in teploty)
            {
                if (teplota > priemer)
                {
                    pocetNad++;
                }
            }
            Console.WriteLine("Nad priemerom je " + pocetNad + " cisel");
        }

       
    }
}
