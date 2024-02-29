using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int listLength = Convert.ToInt32(Console.ReadLine());
            List<string> inputList = new List<string>();

            for (int i = 0;i< listLength;i++)
            {
                inputList.Add((Console.ReadLine()));
            }


            BiggestNumber.FindBiggestNumber(inputList);
            Console.ReadLine();
        }
    }
        class BiggestNumber
        {
            public static void FindBiggestNumber(List<string> inputList)
            {
                string result = "";

                inputList.Sort(Compare);

                for (int i = 0; i < inputList.Count; i++)
                {
                    result = result + inputList[i];
                }
                if (result[0] == '0' && result.Length > 1)
                {
                    Console.WriteLine("0");
                }
            else
            {
                Console.WriteLine(result);
            }

        }

            internal static int Compare(string a, string b)
            {
                
                string ab = a + b;
                string ba = b + a;

                return ab.CompareTo(ba) > 0 ? -1 : 1;
            }

            
        }
    
}

