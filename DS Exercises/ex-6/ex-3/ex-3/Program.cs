using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 1, 3, 4 };
            int len = coins.Length;
            Console.WriteLine(CoinsMin(coins, len, Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
        public static int CoinsMin(int[] coins, int len, int value)
        {
            int[] table = new int[value + 1];

            table[0] = 0;

            for (int i = 1; i <= value; i++)
            {
                table[i] = int.MaxValue;
            }
            for (int i = 1; i <= value; i++)
            {
                for (int j = 0; j < len; j++)
                    if (coins[j] <= i)
                    {
                        int k = table[i - coins[j]];
                        if (k != int.MaxValue && k < table[i] - 1)
                            table[i] = k + 1;
                    }
            }

            return table[value];
        }
    }
}
