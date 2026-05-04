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
    public ListNode ReverseList(ListNode head) {
        if(head == null)
        {
            return head;
        }
        else
        {
            ReverseLinkedList(head);
            return newHead;
        }
    }
    private ListNode newHead = null; 
    public ListNode ReverseLinkedList(ListNode temp)
    {

        if(temp.next != null)
        {
            ListNode newNode = ReverseLinkedList(temp.next);
            newNode.next = temp;
            temp.next = null;
            return temp;
        }
        newHead = temp;
        return temp;
    }
}
