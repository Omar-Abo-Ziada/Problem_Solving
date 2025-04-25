namespace Remove_Nth_Node_From_End_of_List
{
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
        // first brute force solution passing 2 times => time complexity: O(n), space complexity: O(1)
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = 0;
            ListNode current = head;
            while(current != null)
            {
                length++;
                current = current.next;
            }

            int index = length - n;
            if (index == 0)
            {
                return head.next;
            }

            current = head;
            int count = 1;
            while(current != null)
            {
                if (count == index)
                {
                    current.next = current.next.next;
                    break;
                }

                count++;
                current = current.next;
            }

            return head;
        }

        static void Main(string[] args)
        {
        }
    }
}