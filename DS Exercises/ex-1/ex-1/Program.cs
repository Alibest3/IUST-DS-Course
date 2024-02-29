using System;


namespace question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLength = int.Parse(Console.ReadLine());
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 1; i < inputLength - 1 ; i++)
            {
                if (inputArray[i+1] - inputArray[i] > (inputArray[i] - inputArray[i - 1]) )
                {
                    Console.WriteLine((inputArray[i + 1] + inputArray[i]) / 2);
                    break;
                }
                if (inputArray[i + 1] - inputArray[i] < (inputArray[i] - inputArray[i - 1]) )
                {
                    Console.WriteLine((inputArray[i] + inputArray[i-1]) / 2);
                    break;
                }
                
            }
            Console.ReadLine();
        }

    }
}
