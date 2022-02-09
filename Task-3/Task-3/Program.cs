using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int qaliq = 0;
            int sum = 0;
            if (n <= 0)
            {
                Console.WriteLine("Eded 0-dan boyuk olmalidir");
            }
            while(n > 0){
                qaliq = n % 10;
                sum += qaliq;
                n = n/10;
            }
            Console.WriteLine(sum);
        }
        
    }
}
