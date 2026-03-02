// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new Solution();
ListNode list1 = new ListNode(2, null);
ListNode list2 = new ListNode(1, null);
var list3 = a.MergeTwoLists(list1, list2);

Console.WriteLine("Done");
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

//public class Solution
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        if (list1 == null)
//        {
//            return list2;
//        }
//        if (list2 == null)
//        {
//            return list1;
//        }

//        ListNode listSort = null;
//        var p1 = list1;
//        var p2 = list2;
//        while (p1 != null || p2 != null)
//        {
//            if (p1 == null)
//            {
//                AddLast(head: ref listSort, p2.val);
//                p2 = p2.next;
//            }
//            else if (p2 == null)
//            {
//                AddLast(head: ref listSort, p1.val);
//                p1 = p1.next;
//            }
//            else if (p1.val < p2.val)
//            {
//                AddLast(head: ref listSort, p1.val);
//                p1 = p1.next;
//            }
//            else
//            {
//                AddLast(head: ref listSort, p2.val);
//                p2 = p2.next;
//            }
//        }
//        return listSort;
//    }
//    public void AddLast(ref ListNode head, int value)
//    {
//        var newNode = new ListNode(value);

//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }

//        var current = head;

//        while (current.next != null)
//        {
//            current = current.next;
//        }

//        current.next = newNode;
//    }
//}
//v2
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        tail.next = list1 ?? list2;
        return dummy.next;
    }
}