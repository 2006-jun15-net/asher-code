using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] step = new char[8] {' ',' ',' ',' ',' ',' ',' ','#'};

            int stepCount = 6;
            while(stepCount > -1)
            {
                string currentStep = "";
                for(int i = 0; i < step.Length; i++)
                {
                    currentStep += step[i];
                }
                Console.WriteLine(currentStep);
                step[stepCount] = '#';
                stepCount--;
            }

            string lastStep = "";
            for(int i = 0; i < step.Length; i++)
            {
                lastStep += step[i];
            }
            Console.WriteLine(lastStep);
        }
    }
}
