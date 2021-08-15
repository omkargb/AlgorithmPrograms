using System;
using System.IO;

namespace DSPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Implementation of Data Structure Programs ");
            Console.WriteLine("\n Here is the list of programs : ");
            Console.WriteLine(" 1. UnOrdered List - search , add and delete element \t \n");

            Console.Write(" Please provide option number : ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    string filePath = @"G:\BRIDGELABZ\AlgorithmProgramsDotnet\DSPrograms\UOListInput.txt";
                    UnOrderedList<string> unolist = new UnOrderedList<string>();
                    //reading text from file
                    string text = File.ReadAllText(filePath);
                    Console.WriteLine(" Input file contents → " + text);

                    string[] textArray = text.Split(" ");
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        unolist.AddLast(textArray[i]);
                    }

                    Console.Write("\n\n Enter the word to search : ");
                    string word = Console.ReadLine();
                    int found = unolist.SearchNode(word);
                    if (found == 1)
                    {
                        unolist.DeleteNode(word);
                    }
                    else
                    {
                        unolist.AddLast(word);
                    }
                    string newText = unolist.Process();
                    File.WriteAllText(filePath, newText);
                    Console.WriteLine(" After Updating - Input file contents → " +newText);
                    break;

                default:
                    Console.WriteLine(" Invalid choice..");
                    break;
            }
        }
    }
}
