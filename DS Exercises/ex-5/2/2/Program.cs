using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static int mergeSort(int[] inputArray, int arrayLength)
        {
            int[] temp = new int[arrayLength];

            return mergeSort2(inputArray, temp, 0, arrayLength - 1);
        }

        static int mergeSort2(int[] inputArray, int[] temp, int left, int right)
        {
            int mid, invCount = 0;
            if (right > left)
            {
                mid = (right + left) / 2;

                invCount += mergeSort2(inputArray, temp, left, mid);
                invCount += mergeSort2(inputArray, temp, mid + 1, right);

                invCount += merge(inputArray, temp, left, mid + 1, right);
            }
            return invCount;
        }
        static int merge(int[] inputArray, int[] temp, int left, int mid, int right)
        {
            int i, j, k;
            int invCount = 0;

            i = left; 
            j = mid; 
            k = left; 
                     
            while ((i <= mid - 1) && (j <= right))
            {
                if (inputArray[i] <= inputArray[j])
                {
                    temp[k++] = inputArray[i++];
                }
                else
                {
                    temp[k++] = inputArray[j++];

                    
                    invCount = invCount + (mid - i);
                }
            }

            while (i <= mid - 1)
            {
                temp[k++] = inputArray[i++];
            }

            while (j <= right)
            {
                temp[k++] = inputArray[j++];
            }

            for (i = left; i <= right; i++)
            {
                inputArray[i] = temp[i];
            }

            return invCount;
        }

        public static void Main()
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[arrayLength] ;
            for (int i = 0; i < arrayLength; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mergeSort(inputArray, arrayLength));
            Console.ReadLine();
        }
    }
}

