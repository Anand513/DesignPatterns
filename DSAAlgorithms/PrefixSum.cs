using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{

    class PrefixSum
    {
        //prefix sum DS
        public void PrefixSumDS()
        {
            int[] arr = { 2, 4, 6, 8, 10 };

            int n = arr.Length;

            int[] PreArray=new int[n];

            PreArray[0] = arr[0];

            for (int i = 1; i < n; i++)
            {
                PreArray[i] = PreArray[i - 1] + arr[i];
            }

            Console.WriteLine("Prefix Summ Array :" + string.Join(", ", PreArray));


            //Find the sum index for 3 values

            int l= 1;
            int r = 3;

            int sum = (l == 0) ? PreArray[0] : PreArray[r] - PreArray[l - 1];
            Console.WriteLine($"sum from index {l} to {r} : {sum}");

        }



    }
}
