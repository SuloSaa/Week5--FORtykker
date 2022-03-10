using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on 2 mängiat, arvuti e CPU ja kasutaja e user
            //Mõlemad mängijad viskavad täringut;
            // prog kontrollib, kumb viskas rohkem
            // mängija kes viskas rohkem on võitja
            //* täringut visatakse 3 korda 
            // prog kulutab välja võitja

            Random rnd = new Random();
            //CPU
            int cpuRandom = rnd.Next(1, 7);

            //User
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            
            
            for (int i= 0;i<3;i++)
            if(cpuRandom < userRandom)
            {
                    
                    Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju Õnne!");
                userScore = userScore + 1;
            }
            else if (cpuRandom > userRandom)
            {
                    
                    Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                    Console.WriteLine("Arvuti on mänguvõitnud.");
                cpuScore = cpuScore + 1;
            }
            else
            {
                    
                    Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                    Console.WriteLine("Viik!");
            }
        }
    }
}
