using System;

namespace LogINValidation
{
    class Program
    {
        static void Main(string[] args)
        {   // vide ÜL 5 osa 3;
            //prog küsib palub kasut sisestada kasutajatunnuse ja salsõna;
            //kui sisestatud on kasutajatun "admin" ja pw "admin1234";
            //siis konsool kuvab "tere tulemast";
            //muudel kordadel "Valekasutaja tunnus või salasõn. Proovi uuesti.";
            // NB! kasutajal on 3 katset; vaata eelmist loengut 

            Console.WriteLine("Sisestage kasutaja tunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisetage salasõna:");
            string userPassword = Console.ReadLine();


            for (int i = 0; i < 3;)
            if (userName == "admin" && userPassword == "admin1234")
            {
                {
                   Console.WriteLine("Tere tulemast");
                   break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Valekasutaja tunnus või salasõn. Proovi uuesti, {3 - i} katset jäänud");

                }

            }
        }
    }
}
