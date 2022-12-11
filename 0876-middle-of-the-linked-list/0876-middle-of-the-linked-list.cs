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


/*************sol 1****************/
// public class Solution {
//     public ListNode MiddleNode(ListNode head) {
        
//         int i=0;
//         ListNode node=head;
//         while(node.next!=null){
//             node=node.next;
//             i++;
//         }
// //     return node; 
//        Console.WriteLine(i);
//         int middle=(i+1)/2;
//         i=0;
//         node=head;
//         while(i<middle)
//         {
//             node=node.next;
//             i++;
//         }
//         return node;
//     }
// }


/**********************sol 2*****************************/
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        ListNode m=head,l=head;

        while((l!=null) &&( l.next!=null)){            
            m=m.next;
            l=l.next.next;
        }
        // if(l.next!=null)
        //     m= m.next;
        return m;
    }
}