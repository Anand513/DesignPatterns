using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorithms
{
    class ReverseLinkedList
    {
        public LinkedNode reverselist(LinkedNode head)
        {
            LinkedNode prev = null, current = head;

            while (current != null)
            {
                LinkedNode next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;



            }
            return prev;
        }

        public void printlist(LinkedNode head)
        {
            while (head != null)
            {
                
                    Console.Write(head.value + " ->");
                    head = head.Next;
                


            }
            Console.WriteLine("Null");
           



        }

        public class LinkedNode
        {
            public int value;
            public LinkedNode Next;
            public ReverseLinkedList RS;

            public LinkedNode(int value)
            {
                this.value = value;
                Next = null;
            }
        }
    }
}
