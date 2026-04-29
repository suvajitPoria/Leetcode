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
    public ListNode SwapPairs(ListNode head) {
        int count = 0;
        ListNode temp = head;
        ListNode prev = null;
        ListNode superPrev = null;
        while(temp != null)
        {
            count++;
            if(count == 2)
            {
                count = 0;
                if(prev == head)
                {
                    head = temp;
                    prev.next = temp.next;
                    temp.next = prev;
                    superPrev = prev;
                }
                else
                {
                    superPrev.next = temp;
                    prev.next = temp.next;
                    temp.next = prev;
                    superPrev = prev;
                }
                temp = prev;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;
    }
}
