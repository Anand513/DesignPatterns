using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    public class MonotonicStack
    {

        public void GreaterElement()
        {
            int[] arra = {2,1,2,4,3 };
            int len=arra.Length;
            int[] result= new int[len];

            Stack<int> stack = new Stack<int>();

            for (int i = len - 1; i >= 0; i--)
            {
                while(stack.Count>0 && stack.Peek() <= arra[i])
                {
                    stack.Pop();
                }

                result[i] = stack.Count > 0 ? stack.Peek() : -1;

                stack.Push(arra[i]);
            }

            Console.WriteLine(("Next Greater Element "+string.Join(", ", result)));
        }
    }
}
