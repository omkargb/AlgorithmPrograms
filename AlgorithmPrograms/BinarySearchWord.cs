using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{ 
    class BinarySearchWord
    {
        public static void BinarySearch(String[] wordList, String searchTerm)
        {
            int arrayLength = wordList.Length;
            int left = 0,  right = arrayLength - 1;
            while (left <= right)
            {
                int mid = left + ( right - left) / 2;
                int result = searchTerm.CompareTo(wordList[mid]);

                // Check if term is present at mid
                if (result == 0)
                {
                    Console.WriteLine(" Search String present..");
                    break;
                }
                // If term greater, ignore left half
                else if (result > 0)
                {
                    left = mid + 1;
                }
                // If term is smaller, ignore right half
                else if (result < 0)
                {
                    right = mid - 1;
                }
                if (left > right)
                {
                    Console.WriteLine(" Search String not present..");
                    break;
                }
            }

        }

        public void inputArray()
        {
            string wordList = File.ReadAllText(@"G:\BRIDGELABZ\AlgorithmProgramsDotnet\AlgorithmPrograms\InputFile.txt");
            Console.WriteLine(" Input file contains : ");
            //String[] words = { "My", "Name", "is", "Omkar" };
            string[] words = wordList.Split(',');
            foreach (string data in words)
            {
                Console.Write(" "+data);
            }
            Array.Sort(words);
            Console.Write("\n Enter a search term : ");
            String searchTerm = Console.ReadLine();
            BinarySearch(words, searchTerm);
        }
    }
}