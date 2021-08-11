using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public void SortArray()
        {
            int[] inputArray = { 20,30,10,90,50,80 };
            Console.Write(" Input Array : \t");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("\t{0}", inputArray[i]);
            }

            int temp = 0;
            //We compare adjacent elements and see if their order is wrong
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i] < inputArray[j])
                    {
                        //swapping afterchecking the greater number
                        temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            Console.Write("\n Sorted Array : ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("\t{0}", inputArray[i]);
            }
        }
    }
}
