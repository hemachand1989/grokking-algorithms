using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmExercises
{
    public class RecursionExercises : IExecutor
    {
        public void Demonstrate()
        {
            // Writing a Recursive Algorithm might not improve the performance but it might improve the programmer efficiency
            // Every time we go inside a Recursive step a new scoped function with its own memory will be pushed to call stack and once
            // it reaches the base condition it will start popping each one out of it till it returns.
            // Recursive algorithm is base for Divide and Conquer as well as Quick sort algorithms

            Console.WriteLine("This program demonstrates recursive algorithm by finding max element in an array");
            var maxElementArr = MaxElement(new int[] { 1, 4, 2, 10 });
            Console.WriteLine(maxElementArr);
            Console.WriteLine("Recursive Demonstration completed !!");
        }

        // A recursive function should always have a base case(where we stop adding to call stack and start return) and
        // recursive case (keep going inside function and get added to call stack)
        private static int MaxElement(int[] remainingArray)
        {
            // Base Case
            if (remainingArray.Length == 1)
            {
                return remainingArray[0];
            }

            var index = remainingArray[0] > remainingArray[1] ? 1 : 0;
            var remainingArrayList = remainingArray.ToList();
            remainingArrayList.RemoveAt(index);

            // Recursive  Case
            return MaxElement(remainingArrayList.ToArray());
        }
    }
}
