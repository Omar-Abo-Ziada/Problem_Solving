namespace Palindrome_Linked_List
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
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode secondHalf = ReverseList(slow);

            ListNode firstHalf = head;
            ListNode secondHalfCopy = secondHalf; 

            while (secondHalf != null)
            {
                if (firstHalf.val != secondHalf.val)
                    return false;

                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return true;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }

        static void Main(string[] args)
        {
        }
    }
}