namespace Intersection_of_Two_Linked_Lists
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //{
        //    if (headA == null || headB == null)
        //        return null;

        //    var dictionary = new Dictionary<ListNode, int>();

        //    var current = headA;
        //    bool isAdded = false;
        //    while (current != null)
        //    {
        //        isAdded = dictionary.TryAdd(current, current.val);
        //        if (!isAdded)
        //        {
        //            return current;
        //        }
        //        current = current.next;
        //    }

        //    isAdded = false;
        //    current = headB;
        //    while (current != null)
        //    {
        //        isAdded = dictionary.TryAdd(current, current.val);
        //        if (!isAdded)
        //        {
        //            return current;
        //        }
        //        current = current.next;
        //    }

        //    return null;
        //}

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            var visited = new HashSet<ListNode>();

            var currentA = headA;
            while (currentA != null)
            {
                visited.Add(currentA);
                currentA = currentA.next;
            }

            var currentB = headB;
            while (currentB != null)
            {
                if (visited.Contains(currentB))
                {
                    return currentB;
                }
                currentB = currentB.next;
            }

            return null;
        }
    }
}