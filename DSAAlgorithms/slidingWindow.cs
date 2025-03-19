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
    }
}
