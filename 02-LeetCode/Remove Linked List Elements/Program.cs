namespace Remove_Linked_List_Elements
{
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
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return head;

            ListNode current = head;

            while (current != null)
            {
                if (current.val == val && current == head)
                {
                    head = current.next;
                    current = current.next;
                }
                else if (current.next != null && current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;

        }
        static void Main(string[] args)
        {
            //ListNode head = new ListNode(1);
            //var newHead = RemoveElements(head, 2);

            //ListNode head = new ListNode(1);
            //var newHead = RemoveElements(head, 2);

            ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1, null))));
            var newHead = RemoveElements(head, 2);
        }
    }
}
