using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog küsib kasutajalt kolm numbrit; 
            // prog kuvab nende nr summat;

            int sum = 0;
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Siseta number : ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;
            }
            Console.WriteLine($"Sinu numbrite summa on :{sum}");

        }
    }
}
