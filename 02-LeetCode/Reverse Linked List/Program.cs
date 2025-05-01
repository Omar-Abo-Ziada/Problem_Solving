namespace Reverse_Linked_List;

//Definition for singly-linked list.
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
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode originalHead = head;

        while (originalHead.next != null)
        {
            ListNode temp = originalHead.next;
            originalHead.next = originalHead.next.next;
            temp.next = head;
            head = temp;
        }

        return head;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}