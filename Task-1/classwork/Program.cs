using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] divisible= new int[1];

            if (number < 50)
            {
                for (int i = 3; i <= number; i++)
                {
                    if (i % 3 == 0)
                    {
                        for (int m = 0; m <= divisible.Length; m++)
                        {                          
                            divisible[m] = i;
                            break;                          
                        }
                        
                        foreach (int nums in divisible)
                        {
                            Console.WriteLine(nums);
                        }
                    }
                }             
            }

            else if (number > 49 && number < 101)
            {
                for (int i = 5; i <= number; i++)
                {
                    if (i % 5 == 0)
                    {
                        for (int m = 0; m <= divisible.Length; m++)
                        {
                            divisible[m] = i;
                            break;
                        }

                        foreach (int nums in divisible)
                        {
                            Console.WriteLine(nums);
                        }
                    }
                }
            }

            else
            {
                for (int i = 8; i <= number; i++)
                {
                    if (i % 8 == 0)
                    {
                        for (int m = 0; m <= divisible.Length; m++)
                        {
                            divisible[m] = i;
                            break;
                        }

                        foreach (int nums in divisible)
                        {
                            Console.WriteLine(nums);
                        }
                    }
                }
            }            
        }
    }
}
