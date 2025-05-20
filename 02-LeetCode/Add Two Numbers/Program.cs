namespace Add_Two_Numbers;


//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

internal class Program
{
    static ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? dummy = new ListNode(-1);
        ListNode? current = dummy;

        ListNode? current1 = l1;
        ListNode? current2 = l2;
        int carry = 0;
            
        int value = 0;

        while (current1 != null || current2 != null || carry != 0)
        {
            current.next = new ListNode(((current1?.val ?? 0) + (current2?.val ?? 0) + carry) % 10);

            carry = ((current1?.val ?? 0) + (current2?.val ?? 0) + carry) / 10;

            current1 = current1?.next;
            current2 = current2?.next;
            current = current.next;
        }

        return dummy.next;
    }

    static void Main(string[] args)
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var result = AddTwoNumbers(l1, l2);

        while (result != null)
        {
            Console.Write(result.val + " ");
            result = result.next;
        }

        Console.WriteLine();
        //-------------------------------------

        var l3 = new ListNode(0);
        var l4 = new ListNode(0);

        var result2 = AddTwoNumbers(l3, l4);

        while (result2 != null)
        {
            Console.Write(result2.val + " ");
            result2 = result2.next;
        }
        Console.WriteLine();


        //-------------------------------------

        var l5 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var l6 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

        var result3 = AddTwoNumbers(l5, l6);

        while (result3 != null)
        {
            Console.Write(result3.val + " ");
            result3 = result3.next;
        }
    }
}