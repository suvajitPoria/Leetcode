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
    private ListNode s = null;
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        return Traverse(head,n);
    }
    int k = 0;
    private ListNode Traverse(ListNode node, int n)
    {
        if (node == null) 
        {
            return null;
        }

        node.next = Traverse(node.next, n);
        k++;

        if (k == n)
        {
            return node.next; 
        }
        return node;
    }
}
