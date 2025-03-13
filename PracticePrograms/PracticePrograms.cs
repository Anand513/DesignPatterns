using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class PracticePrograms
    {
        public int BinarySearch(int[] array, int Target)
        {
            int left = 0;
            int right = array.Length - 1;
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }



            while (left < right)
            {

                int mid = left + (right - left) / 2;

                if (Target == array[mid])
                {
                    return array[mid];
                }

                if (Target <= array[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return 0;
        }

        public int[] BubbleSorting(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] <= array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }


            return array;
        }

        public string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];

            }
            return new string(chars);
        }

        public Dictionary<char, int> WordCount(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str != "")
                {

                    if (!dic.ContainsKey(str[i]))
                    {
                        dic.Add(str[i], 0);
                    }


                }
                dic[str[i]]++;

            }
            return dic;
        }

        //Palindrome
        public bool isPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; j--, i++)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            return flag;

        }

        //prime
        public bool isPrime(int n)
        {


            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if ((n % i) == 0)
                { return false; }
            }
            return true;
        }

        //Remove duplicates in string 

        public string RemoveDuplicates(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }

        //Remove duplicates in string  using string Builder

        public string RemoveDuplicatesusingstringbuilder(string str)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> list = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!list.Contains(str[i]))
                {
                    sb.Append(str[i]);
                    list.Add(str[i]);
                }
            }
            return sb.ToString();
        }


        //find the maximum number in a string 

        public int MaxNumber(int[] arra)
        {
            int max = 0;

            for (int i = 0; i < arra.Length; i++)
            {
                for (int j = 0; j < arra.Length; j++)
                {
                    if (arra[i] > arra[j])
                    {
                        max = arra[i];
                    }
                }
            }
            return max;
        }


        //Find the second larger in an array

        public int SecondMaxNumber(int[] arr)
        {

            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] != max1)
                {
                    max2 = i;
                }
            }
            return max2;

        }


        //Find the target index value

        public int[] FindIndexes(int[] arr, int Target)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int result = Target - arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (result == arr[j])
                    {
                        return new int[] { i, j };
                    }
                }

            }
            return null;
        }

        //Find the target index value using dictionary

        public Dictionary<int, int> FindIndexesDictionary(int[] arr, int Target)
        {

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = Target - arr[i];

                if (result.ContainsKey(value))
                {
                    return new Dictionary<int, int> {
                        {result[value],i } };
                }
                result[arr[i]] = i;

            }
            return null;
        }

        //Find the repeated words in a string

        public string IncrementValue(string invalue)
        {
            string result = invalue.Substring(0, 3);
            int value = int.Parse(invalue.Substring(4));

            value = value + 1;

            string incrementedvalue = value.ToString().PadLeft(3, '0');

            result = result + incrementedvalue;

            return result;
        }

        //Find the combinationof Printing

        //1
        //2 3
        //4 5 6

        public void PrintCombination(int n)
        {
            int value = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(value);
                    value++;
                }
                Console.WriteLine();
            }
        }

        //Palindrome Combinations
        public void PalindromeCombinations(string word = "")
        {
            word = "anand";

            string left = "";
            string right = "";
            int z = 0;

            for (int i = 0; i < word.Length; i++)
            {
                left += word[i];
                int j = left.Length - 1;

                if (left.Length > 2)
                {

                    while (j >= 0)
                    {
                        right += left[j];
                        j--;
                    }
                    if (left == right)
                    {
                        Console.WriteLine("Palindrome combinations are" + left);
                    }
                    z++;
                    i = z - 1;
                    left = "";
                    right = "";
                }

            }




        }
        //Banking ATM Machine

        public Dictionary<int, int> AtmWithdrawl(int[] atm, int Target)
        {
            int j = 0;
            Dictionary<int, int> Notes = new Dictionary<int, int>();

            while (Target > 0)
            {
                
                if (Target >= atm[j])
                {
                    if (Target > 0)
                    {
                        Target = Target - atm[j];
                        if (!Notes.ContainsKey(atm[j]))
                        {
                            Notes.Add(atm[j], 1);
                        }
                        else
                        {
                            Notes[atm[j]]++;
                        }
                    }
                }
                else
                {
                    j++;
                    if(j >= atm.Length)
                    {

                        Console.WriteLine("Target money not able to retrieve due to insufficent money notes please correct and enter : "+Target);
                        return Notes;
                    }
                }
            }
            Console.WriteLine("Amount recived and payement fully done : " + Target);
            return Notes;
        }

        

    }
}










