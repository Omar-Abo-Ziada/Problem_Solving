namespace Design_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList());

            linkedList.AddAtHead(2);
            linkedList.AddAtHead(3);

            linkedList.AddAtTail(4);

            linkedList.AddAtIndex(2 , 10);

            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(1));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(3));
            Console.WriteLine(linkedList.Get(4));

            linkedList.DeleteAtIndex(5);

            Console.WriteLine();

            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(1));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(3));
            Console.WriteLine(linkedList.Get(4));
        }
    }
}