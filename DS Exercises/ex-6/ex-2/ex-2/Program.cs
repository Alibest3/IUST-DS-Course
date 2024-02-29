using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
        internal class Program
        {
            static void Main(string[] args)
            {
                GreedyCoins(Convert.ToInt32(Console.ReadLine()));
                Console.ReadLine();
            }
            public static void GreedyCoins(int money)
            {
                int[] coins = { 1, 5, 10 };
                int len = coins.Length;

                List<int> final = new List<int>();

                int i = len - 1;
                while(i>=0)
                {
                    while (money >= coins[i])
                    {
                        money -= coins[i];
                        final.Add(coins[i]);
                        
                    }
                    i--;
                }

                Console.WriteLine(final.Count);

            }
        }
}
    

