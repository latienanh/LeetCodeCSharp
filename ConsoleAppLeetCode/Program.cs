
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var l3 = new ListNode(0);
        var currentNode = l3;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            var valueL1 = l1?.val ?? 0;
            var valueL2 = l2?.val ?? 0;

            var sum = valueL1 + valueL2 + carry;
            carry = sum/10;
            currentNode.next = new ListNode(sum%10);
            currentNode = currentNode.next;
            l2 = l2?.next;
            l1 = l1?.next;
        }

        if (carry > 0)
        {
            currentNode.next = new ListNode(carry);
        }
        return l3.next;
    }
}

public class Program()
{
    public static void Main(string[] args)
    {
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9, new ListNode(9))))));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9)));
        var l3 = Solution.AddTwoNumbers(l1, l2);

        while (l3.next == null)
        {
            Console.WriteLine(l3.val);
            l3 = l3.next;
        }
    }
}
