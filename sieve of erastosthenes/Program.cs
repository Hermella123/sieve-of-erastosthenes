using System;

namespace sieve_of_erastosthenes
{


    class Program
    {
        static void Main(string[] args)
        {
            // this program writes prime numbers starting from one to the number that the user has input.


            Console.WriteLine("Enter the number");
            int N = int.Parse(Console.ReadLine());

            bool[] num = new bool[N + 1];
            for (int i = 2; i <= N; i++)
            {
                num[i] = true;
            }

            for (int j = 2; j <= Math.Sqrt(N); j++)
            {
                if (num[j])
                {
                    for (int i = j + 1; i <= N; i++)
                    {
                        if (i % j == 0)
                        {
                            num[i] = false;
                        }
                    }
                }

            }
            for (int i = 2; i <= N; i++)
            {
                if (num[i])
                    Console.WriteLine(i);
            }

        }
    }
}
