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
    public ListNode ModifiedList(int[] nums, ListNode head) {

        HashSet<int> set = new HashSet<int>(nums); 

        ListNode temp = head;
        ListNode prev = null;

        while(temp != null)
        {
            if(set.Contains(temp.val)) 
            {
                if(temp == head)
                {
                    head = temp.next;
                }
                else
                {
                    prev.next = temp.next;
                }
            }
            else
            {
                prev = temp; 
            }

            temp = temp.next;
        }

        return head;
    }
}
