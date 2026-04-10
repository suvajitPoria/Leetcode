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
        ListNode top = null;
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        int i = 1;
        top = head;
        ListNode temp = head;
        ListNode prev = null;
        ListNode start = null;
        while (temp != null)
        {
            if (i == 1)
            {
                start = temp;
            }
            ListNode end = temp;
            temp = temp.next;
            if (k == i)
            {
                i = 0;
                ListNode res = ReverseList(start, end.next);
                if (start == top)
                {
                    top = res;
                }
                else
                {
                    prev.next = res;
                }
                prev = start;
            }
            i++;
        }
        return top;
    }
    private static ListNode ReverseList(ListNode start, ListNode end)
    {
        ListNode curr = start;
        ListNode prev = end;
        ListNode next;
        while (curr != end)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
    return prev;
}
}
