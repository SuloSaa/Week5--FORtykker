using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog küsib palub kasut sisestada kasutajatunnuse ja salsõna;
            //kui sisestatud on kasutajatun "admin" ja pw "admin1234";
            //siis konsool kuvab "tere tulemast";
            //muudel kordadel "Valekasutaja tunnus või salasõn. Proovi uuesti.";


            // true || true --> true
            // false || true --> true
            //true || false -> true
            // false || false --> false


            //OR (või) ||(pipes)
            Console.WriteLine("Sisestage kasutaja tunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisetage salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }

            // "admin1" != "admin" || "admin1234" != "admin1234"    -->true || false -->true

        }
    }
}
