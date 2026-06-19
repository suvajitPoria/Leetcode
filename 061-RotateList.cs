/**

Definition for singly-linked list.

public class ListNode
{ 
    public int val;
    ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
 }
*/
public class Solution {
    ListNode head = null;
    ListNode end = null;

    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0)
            return head;

        this.head = head;
        int length = 0;
        ListNode temp = head;
        while (temp != null) {
            length++;
            temp = temp.next;
        }
        k = k % length;

        for (int i = 0; i < k; i++) {
            FindEnd(this.head);   
            RotateList();         
        }

        return this.head;
    }

    private void FindEnd(ListNode node)
    {
        while (node.next.next != null) 
        {
            node = node.next;
        }
        end = node;
    }

    private void RotateList()
    {
        ListNode last = end.next;
        last.next = head;
        head = last;
        end.next = null;
    }
}