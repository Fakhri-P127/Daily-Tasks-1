using System;

namespace Task_3_ferqli_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int qaliq = 0;
            int sum = 0;
            
            while (n > 0)
            {
                qaliq = n % 10;
                sum += qaliq;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
