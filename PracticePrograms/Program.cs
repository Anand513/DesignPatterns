using SnakeGame;
using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

class LudoGame
{



    static void Main(string[] args)
    {

        PracticePrograms obj = new PracticePrograms();
        int[] array = { 1, 2, 4, 5, 9 };
        string word = "Hello";

        int target = 6;
        //Binary Search

        int result = obj.BinarySearch(array, target);

        //Sorting

        int[] Sorting = obj.BubbleSorting(array);

        foreach (var i in Sorting)
            Console.WriteLine(i);

        //Reverse a String

        string reverse = obj.ReverseString(word);

        Console.WriteLine(reverse);

        //Count the words in a string

        Dictionary<char, int> dict = obj.WordCount(word);

        foreach (var character in dict)
        {
            Console.WriteLine("{0}- {1}", character.Key, character.Value);
        }

        //Palindrome
        string palindromeword = "madam1";

        bool isPalindrome = obj.isPalindrome(palindromeword);

        if (isPalindrome)
        {
            Console.WriteLine("Given String is palindrome");
        }
        else
        {
            Console.WriteLine("Given string is not a Palindrome");
        }

        //Prime

        int n = 5;

        bool isPrime = obj.isPrime(n);

        if (isPrime)
        {
            Console.WriteLine("Given " + n + " value is  prime");
        }
        else
        {
            Console.WriteLine("Given " + n + " value is not a prime");
        }


        //remove duplicates in a string 

        string duplicate = "Hello";

        string distinct = obj.RemoveDuplicates(duplicate);
        string distinct1 = obj.RemoveDuplicatesusingstringbuilder(duplicate);
        Console.WriteLine(distinct);
        Console.WriteLine(distinct1);

        // Max number

        int[] max = { 9, 2, 5, 1, 10 };

        int biggest = obj.MaxNumber(max);

        Console.WriteLine(biggest);

        int second = obj.SecondMaxNumber(max);
        Console.WriteLine(second);

        //Find The sum of two digits value

        int[] arr = obj.FindIndexes(max, 19);

        foreach (int i in arr)
            Console.WriteLine(i);

        //Find The sum of two digits value using dictionary

        Dictionary<int, int> value = obj.FindIndexesDictionary(max, 19);

        foreach (var i in value)
            Console.WriteLine(i.Key + " " + i.Value);

        //Find the incremented value
        string s = "abcd001";

        string strs = obj.IncrementValue(s);

        Console.WriteLine(strs);


        //Combinations printing 

        obj.PrintCombination(5);


        //Palindrome Combinations 

        obj.PalindromeCombinations();


        //ATM withdrawl

        int[] money = { 100, 20, 5, 10,2 };

        Dictionary<int, int> outmoney = obj.AtmWithdrawl(money, 239);

        foreach (var i in outmoney)
            Console.WriteLine(i.Key + " " + i.Value);

        Console.Read();







    }




}
