//Prefix sum caluculation

using DSAAlgorithms;
using static DSAAlgorithms.ReverseLinkedList;

PrefixSum obj=new PrefixSum();
obj.PrefixSumDS();

TwoPointers pointers=new TwoPointers();

if (pointers.TwoPointersDSA())
    Console.WriteLine("Given string is Palindrome");

slidingWindow  sw=new slidingWindow();
int max = sw.SlidingWindowDSA();
Console.WriteLine($"Maximum element is {max}");

sw.getresult();


LinkedNode head = new LinkedNode(1);
head.Next= new LinkedNode(2);
head.Next.Next= new LinkedNode(3);
head.Next.Next.RS=new ReverseLinkedList();

ReverseLinkedList RL=new ReverseLinkedList();
RL.printlist(head);
head= RL.reverselist(head);
RL.printlist(head);

MonotonicStack ms =new MonotonicStack();
ms.GreaterElement();

TopKelements Kele=new TopKelements();
Kele.Kelements();

MergeIntervals  mI=new MergeIntervals();
mI.getmergeintervalist();


