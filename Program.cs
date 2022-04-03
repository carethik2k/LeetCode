using System;

// ReverseStringSolution s = new ReverseStringSolution();
// char[] strNow = {'h','e','l','l','o'};
// s.ReverseString(strNow);

// TwoSumSolution s = new TwoSumSolution();
// int[] nums = {2,5,5,11};
// int target = 10;
// s.TwoSum(nums,target).ToList().ForEach(i => Console.WriteLine(i.ToString()));

AddTwoSolution t = new AddTwoSolution();
ListNode node1 = t.CreateListNode(100);
ListNode node2 = t.CreateListNode(2);
var node = t.AddTwoNumbers(node1,node2);
while(true)
{
    System.Console.Write(node.val);
    if(node.next == null)
        break;
    node = node.next;    
}