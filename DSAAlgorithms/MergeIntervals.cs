using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    public class MergeIntervals
    {


        public  int[][] MergeIntervalst()
        {
            int[][] intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 11,15 }
            };

            if (intervals == null || intervals.Length == 0)
                return new int[0][];

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));


            List<int[]> merged = new List<int[]>();

            foreach(var interval  in intervals)
            {
                if(merged.Count==0 || merged.Last()[1]< interval[0])
                {
                    merged.Add(interval);
                }
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }

            }

            return merged.ToArray();


        }


        public void getmergeintervalist()
        {
            var result = MergeIntervalst();

            Console.WriteLine("Merged intervals:");
            foreach (var interval in result)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");
            }
        }
    }
}
