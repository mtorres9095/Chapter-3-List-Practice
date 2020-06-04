using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace Chapter_3_List_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(23);
            numbers.Add(12);
            numbers.Add(18);
            numbers.Add(28);
            numbers.Add(76);
            numbers.Add(37);

            Console.WriteLine($"The sum of the numbers is: {evenSum(numbers)}");

            List<string> letters = new List<string>();
            letters.Add("disregard");
            letters.Add("mission");
            letters.Add("grandad");
            letters.Add("laundry");
            letters.Add("reward");
            letters.Add("Baltimore");
            letters.Add("Delaware");
            letters.Add("Washington");

            foreach (string letter in letters)
            {
                Console.WriteLine(letter + " ");
            }
            fiveLetters(letters);

            Console.WriteLine(" ");
            Console.WriteLine("Enter the word length: ");
            int length = Int32.Parse(Console.ReadLine());

            customerLength(letters, length);

        }
        static int evenSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        static void fiveLetters(List<string> letters)
        {
            foreach (string letter in letters)
            {
                if (letter.Length == 5)
                {
                    Console.WriteLine(letter);
                }

            }
        }
        static void customerLength(List<string> letters, int userLength)
        {
            foreach (string letter in letters)
            {
                if (letter.Length == userLength)
                {
                    Console.WriteLine(letter);
                }
            }

        }
    }
}
                       

           
