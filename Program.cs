using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class Program
    {
        private static int? BinarySearchAlgorithm(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                else if(array[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] sortedArray = new int[5] {20, 40, 80 , 500 , 900 };
            Console.WriteLine(BinarySearchAlgorithm(sortedArray, 900));
            Console.WriteLine(BinarySearchAlgorithm(sortedArray, 500));
            Console.WriteLine(BinarySearchAlgorithm(sortedArray, 666));
            Console.ReadLine();
        }
    }
}
