using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many steps? ");
            string numberOfSteps = Console.ReadLine();
            int steps = Int32.Parse(numberOfSteps);
            int currentStep = 1;
            
            while(currentStep < steps + 1)
            {
                string step = "";
                for(int i = 0; i < (steps - currentStep); i++)
                {
                    step = step + " ";
                }
                for(int i = 0; i < currentStep; i++)
                {
                    step = step + "#";
                }
                Console.WriteLine(step);
                currentStep++;
            }
        }
    }
}
