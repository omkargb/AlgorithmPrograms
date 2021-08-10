using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to algorithms based programs..");

            Console.WriteLine(" Here is the list of programs : " +
                "\n 1. Binary Search" +
                "\n 2. Insertion sort" +
                "\n 3. Bubble sort" +
                "\n 4. Merge sort" +
                "\n 5. Anagram Detection" +
                "\n 6. Prime numbers in 1 to 1000" +
                "\n 7. Find Anagram and palindrome prime numbers." +
                "\n 8. Guess the number."+
                "\n 0. Exit");

            int choice=99;
            while (choice != 0)
            {

                Console.Write("\n\n Enter your choice number : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n - Binary Searching for a word in array - ");
                        BinarySearchWord bs = new BinarySearchWord();
                        bs.inputArray();
                        break;
                    case 2:
                        Console.WriteLine("\n - Insertion sort implementation -");
                        InsertionSort insort = new InsertionSort();
                        insort.inputArray();
                        break;
                    default:
                        Console.WriteLine(" Invalid choice number..");
                        break;
                }
            }
        }

    }
}
