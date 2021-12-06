using System;

namespace ExerciseWhile01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            int pass = int.Parse(Console.ReadLine());

            while (pass != 2021)
            {
                Console.WriteLine("Invalid Password");
                Console.WriteLine("Enter Password");
                pass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Allowed Access");

        }
    }
}
// Solved by lima-luciano on 11/16/2021
