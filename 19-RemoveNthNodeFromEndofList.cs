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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        return Travers(head,n,head);
    }
    int k = 1;
    private ListNode Travers(ListNode temp, int n,ListNode prev = null)
    {
        if(temp.next != null)
        {
            Travers(temp.next,n,temp);
            if(k == n)
            {
                k++;
                prev.next = temp.next;
            }
            return temp;
        }
        if(k == n)
        {
            prev.next = null;
        }
        k++;
        return null;;
        
    }
}
