using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    public class TwoPointers
    {


        //Two pointer problem solving
        public bool TwoPointersDSA()
        {
            string word = "ana";

            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end] )
                    return false;
                start++;
                end--;
            }
            return true; 

        }
    }
}
