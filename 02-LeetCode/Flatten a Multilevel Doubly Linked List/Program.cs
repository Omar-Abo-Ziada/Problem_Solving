namespace Flatten_a_Multilevel_Doubly_Linked_List;

// Definition for a Node.
public class Node
{
    public int val;
    public Node? prev;
    public Node? next;
    public Node? child;
}


internal class Program
{
    static Node? Flatten(Node head)
    {
        if (head == null) return null;

        Node dummy = new Node() { val = -1 };
        Node curr = dummy;

        Stack<Node> stack = new Stack<Node>();
        stack.Push(head);

        while (stack.Count > 0)
        {
            Node c = stack.Pop();

            Node newNode = new Node
            {
                val = c.val,
                prev = curr
            };

            curr.next = newNode;
            curr = newNode;

            if (c.next != null)
            {
                stack.Push(c.next);
            }

            if (c.child != null)
            {
                stack.Push(c.child);
            }
        }

        dummy.next!.prev = null;
        return dummy.next;
    }


    static void Main(string[] args)
    {


        Flatten(new Node { val = 1, child = new Node { val = 2, child = new Node { val = 3 } } });
    }
}
