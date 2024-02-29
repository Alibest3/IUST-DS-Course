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
            string input = Console.ReadLine();
            int counter1 = input.Count(t => t == '(');
            int counter2 = input.Count(t => t == ')');
            int counter3 = input.Count(t => t == '[');
            int counter4 = input.Count(t => t == ']');
            int counter5 = input.Count(t => t == '{');
            int counter6 = input.Count(t => t == '}');
            if (counter1 != counter2)
            {
                if (counter1 < counter2)
                {
                    Console.WriteLine(input.LastIndexOf(')') + 1);
                }
                else
                {
                    Console.WriteLine(input.LastIndexOf('(') + 1);
                }
                
            }
            else if (counter3 != counter4)
            {
                if (counter3 < counter4)
                {
                    Console.WriteLine(input.LastIndexOf(']') + 1);
                }
                else
                {
                    Console.WriteLine(input.LastIndexOf('[') + 1);
                }

            }
            else if (counter5 != counter6)
            {
                if (counter5 < counter6)
                {
                    Console.WriteLine(input.LastIndexOf('}') + 1);
                }
                else
                {
                    Console.WriteLine(input.LastIndexOf('{') + 1);
                }
                
            }
            else
            {
                Console.WriteLine(-1);
            }
            Console.ReadLine();
        }
    }
}
