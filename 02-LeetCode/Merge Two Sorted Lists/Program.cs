namespace Merge_Two_Sorted_Lists;

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

internal class Program
{
    static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode(-1);  
        var current = dummy;

        var current1 = list1;
        var current2 = list2;

        while (current1 != null && current2 != null)
        {
            if (current1.val <= current2.val)
            {
                current.next = current1;
                current1 = current1.next;
            }
            else
            {
                current.next = current2;
                current2 = current2.next;
            }
            current = current.next;
        }

        if (current1 != null)
            current.next = current1;
        else if (current2 != null)
            current.next = current2;

        return dummy.next; 
    }


    static void Main(string[] args)
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        var result = MergeTwoLists(list1, list2);
    }
}