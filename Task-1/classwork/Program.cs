using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] divisible; 
            int m = 0;

            if (number < 50)
                
            {
                divisible = new int[number / 3];
                for (int i = 3; i <= number; i++)
                {
                    if (i % 3 == 0)
                    {          
                        if (m <= number / 3)
                        {
                            divisible[m] = i;
                            Console.WriteLine(divisible[m]);
                            m++;               
                        }             
                    }
                   
                }             
            }

            else if (number > 49 && number < 101)
            {
                divisible = new int[number / 5];
                for (int i = 5; i <= number; i++)
                {
                    if (i % 5 == 0)
                    {            
                        if (m <= number/5)
                        {
                            divisible[m] = i;
                            Console.WriteLine(divisible[m]);
                            m++;
                        }
                    }
                }
            }

            else
            {
                divisible = new int[number / 8];
                for (int i = 8; i <= number; i++)
                {
                    if (i % 8 == 0)
                    {                      
                        if (m <= number/8)
                        {
                            divisible[m] = i;
                            Console.WriteLine(divisible[m]);
                            m++;
                        }
                    }
                }
            }
        }
    }
}
