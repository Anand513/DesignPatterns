using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    public class Slow_FastPointers
    {

        public static bool HasCycleInArray()
        {
            int[] ints = { 2, 4, 3, 2, 3 };
            
            int slow = 0, fast = 0;

            do
            {
                slow = ints[slow]; // Move one step
                fast = ints[ints[fast]]; // Move two steps

                if (fast == slow) return true; // Cycle detected
            }
            while (fast < ints.Length && ints[fast] < ints.Length);

            return false;
        }

    }
}
