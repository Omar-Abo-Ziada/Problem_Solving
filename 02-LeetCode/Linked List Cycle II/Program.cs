namespace Linked_List_Cycle_II
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public ListNode DetectCycle(ListNode head)
        {
            (bool hasCycle, ListNode meetingNode) = HasCycle(head);

            if (!hasCycle)
                return null;

            ListNode ptr1 = head;
            ListNode ptr2 = meetingNode;

            while (ptr1 != ptr2)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }

            return ptr1; 
        }

        private (bool hasCycle, ListNode meetingNode) HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return (false, null);

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return (true, slow); 
            }

            return (false, null); 
        }

    }
}