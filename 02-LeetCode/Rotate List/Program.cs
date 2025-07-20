namespace Rotate_List;

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
    public static ListNode? RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0) return head;

        // Find the length of the list
        int length = 1;
        ListNode tail = head;
        while (tail.next != null)
        {
            tail = tail.next;
            length++;
        }

        //  Normalize k in case it’s greater than length
        k = k % length;
        if (k == 0) return head;

        // Make the list circular 
        tail.next = head;

        // Find the new tail (length - k - 1 steps from the beginning)
        int stepsToNewTail = length - k;
        ListNode newTail = head;
        for (int i = 1; i < stepsToNewTail; i++)
        {
            newTail = newTail.next!;
        }

        //  Set the new head and break the cycle
        ListNode newHead = newTail.next!;
        newTail.next = null;

        return newHead;
    }


    static void Main(string[] args)
    {
        //ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        //int k = 2;

        //var result = RotateRight(head, k);

        ListNode head = new ListNode(1, new ListNode(2, null));

        int k = 1;

        var result = RotateRight(head, k);
    }
}