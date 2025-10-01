
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*
            // cislo 
            int myAge = 15;
            Console.WriteLine(myAge);
            
            //desatinne cislo
            float pi = 3.14f;
            Console.WriteLine(pi);
            
            //hoci co v pomlckach
            string name = "niggaboy";
            Console.WriteLine(name);
          
            //jeden znak
            char gender = 'M';
            Console.WriteLine(gender);
            
            //true flase
            bool isAdult = false; 
                Console.WriteLine(isAdult); 




           //scitavanie A B 
            int a = 6;
            int b = 5;
            int sum = a + b;
            Console.WriteLine(sum);


           
            Console.WriteLine(a - b);
            //odcitanie 
            int sum2 = a - b;
            Console.WriteLine(sum2);

            //nasobenie delenie 
            Console.WriteLine(a * b );
            Console.WriteLine(a /  b );

            Console.WriteLine("Hugo");*/




            int birthday = 17;
            int birtMonth = 2;
            int birthYear = 2010;

            int Birthsum = birthday + birtMonth + birthYear; 

            Console.WriteLine(Birthsum);


            Console.WriteLine(Birthsum * 10);
            Console.WriteLine((birthday+birtMonth) * birthYear);
            Console.WriteLine(5/3f);

            string Name = "Hugo";
            int Byear = 2010;

            Console.WriteLine(Name + birthYear);

            Console.WriteLine(birthday+birtMonth+Name);

            bool result = 6 > 3;
            Console.WriteLine(result);





            /* //true/false
  bool isAdult = false;
  Console.WriteLine(isAdult);

  // cele cislo
  int myAge = 15;
  Console.WriteLine(myAge);

  //desatinne cislo
  float pi = 3.14f;
  Console.WriteLine(pi);

  //viac znakov hociakych
  string name = "Matus";
  Console.WriteLine(name);

  //jeden znak
  char gender = 'm';
  Console.WriteLine(gender);*/


            /* int a = 10;
           int b = 20 + 30 + 600 + 6000 + 5 ;

           //scitavanie cisel A a B
           int sum = a + b;
           Console.WriteLine(sum);
           Console.WriteLine(a + b);
           Console.WriteLine(10 + 5);

           //cervena gulicka uplne nalavo znamena pokial pojde kod



           //odcitavanie cisla A a B
           Console.WriteLine(a - b);

           int sum2 = a - b;
           Console.WriteLine(sum2);


           //nasobenie A a B
           int sum3 = a * b;
           Console.WriteLine(sum3);
           Console.WriteLine(a * b);
           Console.WriteLine(10 * 5);

           //delenie A a B

           int sum4 = a / b;
           Console.WriteLine(sum4);
           Console.WriteLine(a / b);
           Console.WriteLine(10 / 5);

           Console.WriteLine("Volam sa Jano");  */



            // int birthDay = 29;
            //int birthMonth = 7;
            //int birthYear = 2010;

            /*
                        //scitanie datumu mesiaca a roku narodenia
                        int birthSum = birthDay + birthMonth + birthYear;
                        //vypisanie na konzol
                        Console.WriteLine(birthSum);


                        //vynasobenie birthSum x 10 a vypisat na kozolu
                        Console.WriteLine(birthSum * 10);

                        //scitat datum a mesiac narodenia a prenasobit rokom
                        int birthSum2 = birthDay + birthMonth;
                        Console.WriteLine(birthSum2 * birthYear);
                        // druha moznost
                        Console.WriteLine((birthMonth + birthDay) * birthYear);


                        //vzdy to zaokruhkuje
                        //vzdy float (3f) ked chces desatinne cisla
                        Console.WriteLine(5 / 3);
                        Console.WriteLine(5 / 3f);

                        string Name2 = "Matus";
                        Console.WriteLine(Name2 + birthYear);

                        //vypisat meno a sucet dna a mesiaca narodenia

                        Console.WriteLine("Matus" + (birthDay + birthYear));*/


            /* bool result = 6 != 3;
             Console.WriteLine(result);

             bool result2 = 7 == 3;
             bool result3 = 3 < 10;

             string Igor = "Igor";
             string Michal = "Michal";
             Console.WriteLine(Igor == Michal);

             string igor = "Igor";
             string michal = igor;
             Console.WriteLine(Igor == Michal);


             string krabickaA = "Igor";
             string krabickaB = krabickaA;
             krabickaA = "Michal";
             Console.WriteLine(krabickaB == krabickaA); */


            /*
           Console.WriteLine("Napis meno");
           string meno = Console.ReadLine();
           string vypis = "Ahoj ";
           Console.WriteLine(vypis + meno);

           Console.WriteLine("Zadaj vek: ");


           string vekText = Console.ReadLine();
           int vek = int.Parse(vekText);
           int birthYear = 2025 - vek;
           string vypis2 = "Ahoj " + meno + " narodil si sa v roku " + birthYear;
           Console.WriteLine(vypis2);



           if (birthYear > 2000)
           {
               Console.WriteLine("Si narodeny po roku 2000");
           }

           else if (birthYear == 2000)

           {
               Console.WriteLine("Si narodeny v roku 2000");
           }







           else
           {
               Console.WriteLine("Si narodeny pred rokom 2000");
           }
           */


            /* Console.WriteLine("Zadaj znamku z matematiky");
             string znamkamText = Console.ReadLine();
             int znamkam = int.Parse(znamkamText);

             Console.WriteLine("Teraz zadaj znamku zo slovenciny");
             string znamkasText = Console.ReadLine();
             int znamkas = int.Parse(znamkasText);
             if (znamkam <= 2 && znamkas <= 2)
             {
                 Console.WriteLine("Tvoj priemer je dostacujuci");
             }
             else
             {
                 Console.WriteLine("Tvoj priemer je nedostacujuci");
             }
            */



            Console.WriteLine("Zadaj prve cislo");
            string cislo1text = Console.ReadLine();
            int cislo1 = int.Parse(cislo1text);


            Console.WriteLine("Zadaj poctovu operaciu");
            string operacia = Console.ReadLine();


            Console.WriteLine("Zadaj druhe cislo");
            string cislo2text = Console.ReadLine();
            int cislo2 = int.Parse(cislo2text);

            int vysledok = 0;

            if (operacia == "+")
            {
                vysledok = cislo1 + cislo2;
            }

            else if (operacia == "-")
            {
                vysledok = cislo1 - cislo2;
            }
            else if (operacia == "*")
            {
                vysledok = cislo1 * cislo2;
            }
            else if (operacia == "" + "/")
            {
                vysledok = cislo1 / cislo2;
            }

            Console.WriteLine("vysledok je: " + vysledok);










        }
    }
}


