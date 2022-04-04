
// Definition for singly-linked list.
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

public class AddTwoSolution {
    public ListNode CreateListNode(int num)
    {
        ListNode firstNode = null;
        ListNode nextNode = null;

        if (num == 0)
        {
            firstNode = new ListNode(0);
            return firstNode;
        }

        while (num > 0)
        {
            var digit = num % 10;
            num = num / 10;
            if(firstNode == null)
            {
                nextNode = new ListNode();
                firstNode = new ListNode(digit,nextNode);
            }
            else
            {
                var currNode = nextNode;
                currNode.val = digit;
                if(num > 0)
                {
                    nextNode = new ListNode();                
                    currNode.next = nextNode;
                }                
            }                       
        }

        

        return firstNode;
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var dummy = new ListNode(0);
        var pre = dummy;
        int carry = 0;

        while(l1 != null || l2 != null || carry == 1)
        {
            var sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            carry = sum > 9 ? 1 : 0;
            pre.next = new ListNode(sum%10);
            pre = pre.next;

            if(l1 != null)
                l1 = l1.next;
            if(l2 != null)
                l2 = l2.next;
        }

        return dummy.next;
    }

    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    // {
    //     var carryover = 0;
    //     ListNode n1 = l1;
    //     ListNode n2 = l2;

    //     bool n1done, n2done;

    //     while (true)
    //     {
    //         int n1val, n2val = 0;
    //         n1val = n1 == null ? 0 : n1.val;
    //         n2val = n2 == null ? 0 : n2.val;

    //         var sum = carryover + n1val + n2val;            

    //         if(sum < 10)
    //         {   
    //             n1.val = sum;
    //             carryover = 0;
    //         }
    //         else
    //         {
    //             n1.val = sum % 10;
    //             carryover = sum /10;
    //         }
    //         System.Console.WriteLine($"sum {sum},carryover {carryover},n1val {n1val},n2val {n2val}");

    //         //System.Console.WriteLine($"{n1?.val},{n2?.val}");

    //         if(n1?.next == null && n2?.next != null)
    //             n1.next = new ListNode();
            
    //         if(n1?.next == null && carryover > 0)
    //         {
    //             n1.next = new ListNode(carryover,null);
    //             carryover= 0;
    //         }

    //         n1 = n1?.next;
    //         n2 = n2?.next;

    //         if (n2 == null && n1 == null) 
    //             break;
    //     }

    //     return l1;
    // }
}