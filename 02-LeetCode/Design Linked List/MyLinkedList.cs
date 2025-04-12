namespace Design_Linked_List;

public class SinglyLinkedListNode
{
    public int Value { get; set; }
    public SinglyLinkedListNode? Next { get; set; }
    public SinglyLinkedListNode? Prev { get; set; }

    public SinglyLinkedListNode(int value)
    {
        Value = value;
    }
}

public class MyLinkedList
{
    public int Length { get; set; }


    public SinglyLinkedListNode Head { get; set; }
    public SinglyLinkedListNode Tail { get; set; }

    public MyLinkedList()
    {
        Head = null;
        Tail = null;
        Length = 0;
    }

    public int Get(int index)
    {
        if (index < 0 || Head is null) return -1;
        SinglyLinkedListNode current = Head;
        int count = 0;
        while (current is not null)
        {
            if (count == index)
            {
                return current.Value;
            }
            current = current.Next;
            count++;
        }
        return -1;
    }

    public void AddAtHead(int val)
    {
        var newNode = new SinglyLinkedListNode(val);

        if (Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }

        Length++;
    }


    public void AddAtTail(int val)
    {
        var newNode = new SinglyLinkedListNode(val);

        if (Tail == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }

        Length++;
    }


    public void AddAtIndex(int index, int val)
    {
        if (index > Length || index < 0) return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == Length)
        {
            AddAtTail(val);
            return;
        }

        var newNode = new SinglyLinkedListNode(val);
        var current = Head;
        int count = 0;

        while (current != null)
        {
            if (count == index)
            {
                newNode.Next = current;
                newNode.Prev = current.Prev;

                if (current.Prev != null)
                    current.Prev.Next = newNode;

                current.Prev = newNode;

                Length++;
                break;
            }

            current = current.Next;
            count++;
        }
    }


    public void DeleteAtIndex(int index)
    {
        if (index >= Length || index < 0 || Head is null) return;

        if (Length == 1 && index == 0)
        {
            Head = null;
            Tail = null;
            Length--;
            return;
        }

        if (index == 0)
        {
            Head = Head.Next;
            if (Head != null)
                Head.Prev = null;
            Length--;
            return;
        }

        if (index == Length - 1)
        {
            Tail = Tail.Prev;
            if (Tail != null)
                Tail.Next = null;
            Length--;
            return;
        }

        SinglyLinkedListNode current = Head;
        int count = 0;
        while (current != null)
        {
            if (count == index)
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;

                current.Next = null;
                current.Prev = null;

                Length--;
                break;
            }

            current = current.Next;
            count++;
        }
    }

}