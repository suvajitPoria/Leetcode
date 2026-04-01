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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode temp = head;
        ListNode prev = temp;
        while(temp != null)
        {
            if(temp.val == val)
            {
                if(head == temp)
                {
                    head = temp.next;
                    temp = temp.next;
                }
                else if(temp.next == null)
                {
                    prev.next = null;
                    break;
                }
                else
                {
                    prev.next = temp.next;
                    temp = temp.next;
                }
            }
            else
            {
                prev = temp;
                temp = temp.next;
            }
            
        }
        return head;
    }
}
