using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    public class TopKelements
    {

        int[] arr = { 5, 2, 9, 1, 7, 6, 3 };
        int k = 3;

        PriorityQueue<int,int> minheap=new PriorityQueue<int, int>();


        public void Kelements()
        {

            foreach (var item in arr)
            {

                minheap.Enqueue(item, item);
                if (minheap.Count > k)
                {
                    minheap.Dequeue();
                }
            }

            List<int> list = new List<int>();

            while (minheap.Count > 0)
            {
                list.Add(minheap.Dequeue());
            }

            list.Reverse();
            Console.WriteLine($"Top {k} elements: {string.Join(", ", list)}");
        }




    }
}
