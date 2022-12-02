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
public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        
                   ListNode node = head;
            ListNode prev = head;
            int size=0;
            while(node != null)
            {
                size++;
                node = node.next;
            }
        int n=size/2+1;
            if (size <= 1)
                return null;

            node = head;
            for (int j = 2; j <= n; j++)
            {
                prev=node;
                node=node.next;
            }
            if(node.next != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
            else
            {
                prev.next = null;
            }
            return head;
 
    }
}