using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog küsib palub kasut sisestada kasutajatunnuse ja salsõna;
            //kui sisestatud on kasutajatun "admin" ja pw "admin1234";
            //siis konsool kuvab "tere tulemast";
            //muudel kordadel "Valekasutaja tunnus või salasõn. Proovi uuesti.";õ
            //kasutajal on kolmkatset;

            // AND (&&)

            // kui kas sis "admin" AND "admin1234" --> true
            // kui aga "admine1" AND "admine1234" --> false
            // kui aga "admine" AND "admine12345" --> false
            // kui aga "admine1" AND "admine123" --> false


            Console.WriteLine("Sisestage kasutaja tunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisetage salasõna:");
            string userPassword = Console.ReadLine();

            if (userName == "admin" || userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Valekasutaja tunnus või salasõn. Proovi uuesti.");
            }
        }
    }
}
