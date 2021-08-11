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
                "\n 7. Find palindrome prime numbers." +
                "\n 8. Guess the number."+
                "\n 0. Exit");

            int choice=99;
            while (choice != 0)
            {

                Console.WriteLine("\n -\t-\t-\t-\t-\t-\t-\t-\t-\t-\t ");
                Console.Write("\n Enter your choice number : ");
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
                    case 3:
                        Console.WriteLine("\n - Bubble sort implementation -");
                        BubbleSort bsort = new BubbleSort();
                        bsort.SortArray();
                        break;
                    case 5:
                        Console.WriteLine("\n - Anagram strings detection -");
                        AnagramCheck check = new AnagramCheck();
                        check.TakeInput();
                        break;
                    case 6:
                        Console.WriteLine("\n - Printing prime numbers beetween 1 to 1000 -");
                        PrimeNumberList prime = new PrimeNumberList();
                        prime.PrimeCheck();
                        break;
                    default:
                        Console.WriteLine(" Invalid choice number..");
                        break;
                }
            }
        }

    }
}
