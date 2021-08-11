using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {

        void InsertionSorting(string[] inputArray, int size)
        {
            int i;
            //Loop from the second entry to the final one
            for (int a = 1; a < size; a++)
            {
                //takes one input elements at a time,
                string element = inputArray[a];
                int b = a - 1;
                //iterates through the sorted sub-array at back/left side
                while (b >= 0 && (element.CompareTo(inputArray[b])<0))
                {
                    inputArray[b + 1] = inputArray[b];
                    b = b - 1;
                }
                //inserts one element at its correct position
                inputArray[b + 1] = element;
            }

            Console.Write("\n Sorted Array : \t");
            for (i = 0; i < inputArray.Length; i++)
            {
                Console.Write(" {0}", inputArray[i]);
            }
        }

        public void inputArray()
        {
            string[] inputArray = { "save", "array", "calc", "list", "delete", "int", "node", "print"};
            Console.Write(" Input array contains : ");
            int size = inputArray.Length;

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(" {0}", inputArray[i]);
            }
            InsertionSorting(inputArray, size);
        }

    }
}
