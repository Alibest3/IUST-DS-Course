using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
        }
    }*/
    class GFG
    {

        // Function to print the required
        // points which minimizes the sum
        // of Manhattan distances
        static void minDistance(int n, int k,
                                int[][] point)
        {

            // Sorting points in all k dimension
            for (int i = 0; i < k; i++)
                Array.Sort(point[i]);

            // Output the required k points
            for (int i = 0; i < k; i++)
                System.Console.Write(point[i][(int)
                    Math.Ceiling((double)(n / 2) - 1)] + " ");
        }

        // Driver code
        public static void Main()
        {
            int n = 5;
            int k = 2;
            int[][] point = new int[][]{ new int[]{ 0,0},
                    new int[]{ 1,2 },
                    new int[]{ 3,8 },
                    new int[]{ 5,2} ,
                    new int[] { 7,0}};

        // function call to print required points
        minDistance(n, k, point);
            Console.Read();
        }
    }
}
