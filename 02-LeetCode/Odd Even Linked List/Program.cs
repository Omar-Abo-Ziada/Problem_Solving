namespace Odd_Even_Linked_List
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
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null) 
                return head;

            ListNode odd = head;
            ListNode even = head.next;

            ListNode evenHead = head.next;

            bool finshed = false;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = even.next;

                even.next = odd.next;
                even = odd.next;
            }

            odd.next = evenHead;

            return head;
        }

        static void Main(string[] args)
        {
            var head = new ListNode(1,
                new ListNode(2,
                     new ListNode(3,
                       new ListNode(4,
                            new ListNode(5,
                                 new ListNode(6))))));

            OddEvenList(head);
        }
    }
}