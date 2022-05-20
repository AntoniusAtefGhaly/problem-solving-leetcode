
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode S = new ListNode(0);
        ListNode p1 = l1;
        ListNode p2 = l2;
        ListNode res = S;
        ListNode prev=S;

        int carry=0,sum=0;

          while ((p1 != null) && (p2 != null))
            {
            S.val = (p1.val+p2.val+carry)%10;
            carry = (p1.val + p2.val + carry) / 10;
            p1= p1.next;
            p2= p2.next;
            S.next = new ListNode(0);
            prev = S;
            S = S.next;
        }

        while (p1 != null)
            {
            S.val = (p1.val + carry) % 10;
            carry = (p1.val + carry) / 10;
            S.next = new ListNode(0);
            p1 = p1.next;
            prev = S;
            S = S.next;
        }
        while (p2 != null)
        {
            S.val = (p2.val + carry) % 10;
            carry = (p2.val + carry) / 10;
            S.next = new ListNode(0);
            p2 = p2.next;
            prev = S;
            S = S.next;
        }
        if (carry != 0)
        {
            S.val = carry;
            S.next = null;
        }
        else
        {
            prev.next = null;
        }

        return res;
    }
}