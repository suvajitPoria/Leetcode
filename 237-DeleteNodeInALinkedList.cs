/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        Delete(node);
    }
    void Delete(ListNode node)
    {
        ListNode temp = node;
        while(temp != null)
        {
            temp.val = temp.next.val;
            if(temp.next.next == null)
            {
                temp.next = null;
                break;
            }
            temp=temp.next;

        }
    }
}
