using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmExercises
{
    public class SelectionSort : IExecutor
    {
        // Though not the quickest Sort, Still selection Sort has a time complexity of O(n*n) (Technically its O(n*n/2) but this is exception)
        // its like we have to run n items n times to find out smallest each time by traversing through remaining list.
        // Sorts are basic in any search operations in database as binary search requires Sorted input
        public void Demonstrate()
        {
            var inputArr = new int[] {1, 3, 10, 2, 4, 78, 19, 3};
            var resultList = new List<int>();
            foreach (var unused in inputArr)
            {
                var smallestIndex = FindSmallest(inputArr);
                resultList.Add(inputArr[smallestIndex]);
                var newInputList = inputArr.ToList();
                newInputList.RemoveAt(smallestIndex);
                inputArr = newInputList.ToArray();
            }

            resultList.ForEach(i=> Console.Write(i+" "));

            Console.WriteLine();
        }

        private static int FindSmallest(int[] inputArr)
        {
            var smallest = 0;
            for (var i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[smallest] > inputArr[i])
                {
                    smallest = i;
                }
            }
            return smallest;
        }
    }
}
