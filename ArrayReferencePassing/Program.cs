﻿using System;

namespace ArrayReferencePassing
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and initialize firstArray
            int[] firstArray = {1, 2, 3, 4};

            // copy the reference in variable firstArray
            int[] firstArrayCopy = firstArray;

            Console.WriteLine("Test passing firsyArray reference by value");

            Console.Write("\nContents of firstArray before calling first double:\n\t");
            // display contents of firstArray
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("{0} ",firstArray[i]);
            }

            FirstDouble(firstArray);

            Console.Write("\n\nContents of firstArray after calling FirstDouble:\n\t");
            // display contents of firstArray
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("{0} ", firstArray[i]);
            }

            // test whether reference was changed by FirstDouble
            if (firstArray==firstArrayCopy)
            {
                Console.WriteLine("\n\nThe references refer to the same array");
            }
            else
            {
                Console.WriteLine("\n\nThe references refer to the different array");
            }

            // create and initialize secondArray
            int[] secondArray = { 1, 2, 3, 4 };

            // copy the reference in variable firstArray
            int[] secondArrayCopy = secondArray;

            Console.WriteLine("Test passing secondArray reference by reference");

            Console.Write("\nContents of secondArray before calling SecondDouble:\n\t");
            // display contents of secondArray
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("{0} ", secondArray[i]);
            }

            // pass variable secondArray by reference to SecondDouble
            SecondDouble(ref secondArray);

            Console.Write("\n\nContents of secondArray after calling SecondDouble:\n\t");
            // display contents of secondArray
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("{0} ", secondArray[i]);
            }

            // test whether reference was changed by SecondDouble
            if (secondArray == secondArrayCopy)
            {
                Console.WriteLine("\n\nThe references refer to the same array");
            }
            else
            {
                Console.WriteLine("\n\nThe references refer to the different array");
            }

            Console.ReadKey(true);

        }// end Main method

        // modify elements of array and attempt to modify reference
        public static void FirstDouble(int[] array)
        {
            // double each element's value
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;

                // create new object and assign its reference to array
                array = new int[] {11, 12, 13, 14};
            }
        }

        // modify elements of array and change reference array
        // to refer to a new array
        public static void SecondDouble(ref int[] array)
        {
            // double each element's value
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;

                // create new object and assign its reference to array
                array = new int[] {11, 12, 13, 14};
            }
        }
    }
}
