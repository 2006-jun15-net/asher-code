using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            int N = Int32.Parse(response);
            
            Console.WriteLine(N);
            while(true)
            {
                if(N == 1)
                {
                    break;
                }
                else if(N % 2 == 0)
                {
                    N = N / 2;
                }
                else
                {
                    N = N * 3 + 1;
                }

                Console.WriteLine(N);
            }
        }
    }
}
