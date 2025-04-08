using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    class slidingWindow
    {
        public slidingWindow next;
        public int SlidingWindowDSA()
        {
            int[] arr = { 2, 3, 4, 5 };

            

            int Max = 0;
            int currentsum = 0;

            for (int i = 2; i < arr.Length; i++)
            {

                currentsum = arr[i - 2] + arr[i - 1] + arr[i];

                if (currentsum > Max)
                {
                    Max=currentsum;
                }

            }
            return Max;
        }


        public List<int[]> GetThreeIndexes()
        {
            int[] nums = { 1, 4, 6, 8, 10, 15 };
            int target = 22;
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < nums.Length-1; i++)
            {
                int left=i+1,right=nums.Length-1;

                while (left < right)
                {
                    int value=nums[left]+nums[right]+nums[i];   

                    if(value==target)
                    {
                        result.Add(new int[] {left,right,i});
                    }

                    if(value<target)
                    {
                        left++;

                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;

          
        }

        public void getresult()
        {
         

            List<int[]> result = GetThreeIndexes();

            foreach (var arr in result) {

                Console.WriteLine($"[{arr[0]},{arr[1]},{arr[2]}]");
                }
          

          
        }
    }
}
