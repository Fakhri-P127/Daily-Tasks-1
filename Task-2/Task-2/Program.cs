using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"Seal","Duck","Cat","Snake","Elephant","Crocodile","Dog" };
            foreach (string animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
