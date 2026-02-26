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
    public ListNode newList = null;
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists != null)
        {
            foreach(ListNode list in lists)
            {
                Marge(list);
            }
            return newList;
        }
        else
        {
            return newList;
        }   
    }
    public void Marge(ListNode list)
    {
        while(list != null)
        {
            if(newList == null)
            {
                newList = new ListNode(list.val, null);
            }
            else
            {
                ListNode temp = newList;
                ListNode prev = null;
                while(temp != null && temp.val < list.val)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if(prev == null)
                {
                    newList = new ListNode(list.val, newList);
                }
                else
                {
                    prev.next = new ListNode(list.val, temp);
                }
            }
            list = list.next;
        }
    }
}
