using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using AlgorithmExercises;

namespace AlgorithmExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var runUntil = true;
            while (runUntil)
            {
                IExecutor executor;
                Console.WriteLine("Select one of the operations");
                Console.WriteLine(" 1. Binary Search \n 2. Selection Sort \n 3. Recursion Exercises");

                var selection = Convert.ToInt16(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        executor = new BinarySearch();
                        executor.Demonstrate();
                        break;
                    case 2:
                        executor = new SelectionSort();
                        executor.Demonstrate();
                        break;
                    case 3:
                        executor = new RecursionExercises();
                        executor.Demonstrate();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        runUntil = false;
                        break;
                }
            }
        }
    }
}
