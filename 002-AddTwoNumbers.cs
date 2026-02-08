public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while(l1 != null || l2 != null)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x+y;
            if(carry != 0)
            {
                sum+=carry;
                if(sum>9)
                {
                    current.next=new ListNode(sum%10);
                    carry=sum/10;
                    current=current.next;
                }
                else
                {
                    current.next= new ListNode(sum);
                    carry = 0;
                    current=current.next;
                }
            }
            else
            {
                if(sum>9)
                {
                    current.next= new ListNode(sum%10);
                    carry=sum/10;
                    current=current.next;
                }
                else
                {
                    current.next= new ListNode(sum);
                    current=current.next;
                }
            }
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        if(carry != 0)
        {
            current.next= new ListNode(carry);
            current=current.next;
        }
        return dummy.next;
    }
}
