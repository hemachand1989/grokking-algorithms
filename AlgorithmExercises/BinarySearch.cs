using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmExercises
{
    public class BinarySearch : IExecutor
    {
        public void Demonstrate()
        {
            // Binary Search is the most powerful algorithm if we give sorted inputs
            // If we pass a sorted array the time complexity (Big O notation) is usually O(log n) , where n is number of records to search
            // If there are 4 billion sorted records to search the number of operations it will take is 32. 2^32 = 4billion or log(4billion) = 32
            // Below program takes 100 numbers as input in sorted order. The max operations it will take is 7. or log(100) = ln(100)/ln(2)
            // 2^x for n records then x = ln(n)/ln(2) which we classically state log value for n records with base 2.

            var binarySearchList = new List<int>();

            for (var i = 1; i <= 100; i++)
            {
                binarySearchList.Add(i);
            }

            Console.WriteLine("Demonstration using Loops");
            var result = LoopBinarySearchOperation(binarySearchList.ToArray(), -1, 0, binarySearchList.Count, 0);
            Console.WriteLine("Demonstration completed with Search result in 1 to 100 records as "+ result);

            Console.WriteLine("Demonstration using Recursion");
            result = RecursiveBinarySearchOperation(binarySearchList.ToArray(), -1, 0, binarySearchList.Count, 0);
            Console.WriteLine("Demonstration completed with Search result in 1 to 100 records as " + result);
        }

        private static bool LoopBinarySearchOperation(int[] inputArr, int searchInput, int low, int high, int operationCount)
        {
            var mid = (low + high) / 2;
            while (mid != high && mid != low)
            {
                Console.WriteLine("Low Index is: " + low);
                Console.WriteLine("High index is: " + high);
                Console.WriteLine("Mid Index is: " + mid);
                if (inputArr[mid] == searchInput)
                {
                    Console.WriteLine("Element found in operations " + operationCount);
                    return true;
                }
                if (inputArr[mid] > searchInput) high = mid;
                if (inputArr[mid] < searchInput) low = mid;

                mid = (low + high) / 2;

                operationCount += 1;
            }
            return false;
        }

        private static bool RecursiveBinarySearchOperation(int[] inputArr, int searchInput, int low, int high, int operationCount)
        {
            var mid = (low + high) / 2;
            Console.WriteLine("Low Index is: " + low);
            Console.WriteLine("High index is: " + high);
            Console.WriteLine("Mid Index is: " + mid);
            //base case .. Element Found
            if (inputArr[mid] == searchInput)
            {
                Console.WriteLine("Element found in operations " + operationCount);
                return true;
            }
            else if (mid == high || mid == low)
            {
                //base case .. Element Not found
                Console.WriteLine("Element Not found in operations " + operationCount);
                return false;
            }

          
            if (inputArr[mid] > searchInput) high = mid;
            if (inputArr[mid] < searchInput) low = mid;

            operationCount += 1;

            // recursive case ..
            return RecursiveBinarySearchOperation(inputArr, searchInput, low, high, operationCount);
        }
    }
}
