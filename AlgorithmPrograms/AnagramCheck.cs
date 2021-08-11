using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class AnagramCheck
    {
        public void isAnagram(string firstString, string secondString)
        {
            if (firstString.Length == secondString.Length)
            {
                //convert the strings into character arrays with lowercase
                char[] string1 = (firstString.ToUpper()).ToCharArray();
                char[] string2 = (secondString.ToUpper()).ToCharArray();

                //sort the arrays
                Array.Sort(string1);
                Array.Sort(string2);

                // convert the character arrays to strings
                String word1 = new String(string1);
                string word2 = new String(string2);

                // if two words are equal then 
                if (word1 == word2)
                {
                    Console.WriteLine(" Input string are Anagrams ");
                }
                else
                {
                    Console.WriteLine(" Input string are not Anagrams. ");
                }
            }
            else //if 2 strings length are not equal
            {
                Console.WriteLine(" String length not same.. So input string are not Anagrams. ");
            }
        }

        public void TakeInput()
        {
            Console.WriteLine(" Checking input string are anagram or not..");
            Console.Write(" Enter 1st string : ");
            string string1 = Console.ReadLine();
            
            Console.Write(" Enter 2nd string : ");
            string string2 = Console.ReadLine();

            isAnagram(string1, string2);
        }
    }
}
