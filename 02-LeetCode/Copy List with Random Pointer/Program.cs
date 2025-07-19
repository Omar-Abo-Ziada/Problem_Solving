namespace Copy_List_with_Random_Pointer;

// Definition for a Node.
public class Node
{
    public int val;
    public Node? next;
    public Node? random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

internal class Program
{
    public static Node? CopyRandomList(Node head)
    {
        if (head is null) return null;

        var originalCurrent = head;

        var newHead = new Node(head.val);
        var newCurrent = newHead;

        // Dictionary to store mapping from original node to cloned node
        var nodesDictionary = new Dictionary<Node, Node>();

        nodesDictionary.Add(head, newHead);

        while (originalCurrent.next != null)
        {
            if (nodesDictionary.ContainsKey(originalCurrent.next))
            {
                // If already copied, use the existing node
                newCurrent.next = nodesDictionary[originalCurrent.next];
            }
            else
            {
                // If not copied yet, create it and add to the dictionary
                var next = new Node(originalCurrent.next.val);
                newCurrent.next = next;
                nodesDictionary.Add(originalCurrent.next, next);
            }

            if (originalCurrent.random != null)
            {
                if (nodesDictionary.ContainsKey(originalCurrent.random))
                {
                    // If already copied, use the existing node
                    newCurrent.random = nodesDictionary[originalCurrent.random];
                }
                else
                {
                    // If not copied yet, create it and add to the dictionary
                    var random = new Node(originalCurrent.random.val);
                    newCurrent.random = random;
                    nodesDictionary.Add(originalCurrent.random, random);
                }
            }

            // Move to the next node in both lists
            originalCurrent = originalCurrent.next;
            newCurrent = newCurrent.next;
        }

        // Handle the last node's random pointer if needed
        if (originalCurrent.random != null)
        {
            if (nodesDictionary.ContainsKey(originalCurrent.random))
            {
                newCurrent.random = nodesDictionary[originalCurrent.random];
            }
            else
            {
                var random = new Node(originalCurrent.random.val);
                newCurrent.random = random;
                nodesDictionary.Add(originalCurrent.random, random);
            }
        }

        return newHead;
    }


    static void Main(string[] args)
    {
        // Create all nodes
        Node node1 = new Node(7);
        Node node2 = new Node(13);
        Node node3 = new Node(11);
        Node node4 = new Node(10);
        Node node5 = new Node(1);

        // Link next pointers
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = null;

        // Link random pointers (based on the diagram)
        node1.random = null;
        node2.random = node1;
        node3.random = node5;
        node4.random = node3;
        node5.random = node1;


        // Pass the head node to the CopyRandomList method.
        var copiedListHead = CopyRandomList(node1);
    }
}
