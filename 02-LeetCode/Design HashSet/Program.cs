namespace Design_HashSet;

public class MyHashSet
{
    public bool[] Elements { get; set; }

    public MyHashSet()
    {
        Elements = new bool[1_000_001];
    }

    public void Add(int key)
    {
        Elements[key] = true;
    }

    public void Remove(int key)
    {
        Elements[key] = false;
    }

    public bool Contains(int key)
    {
        return Elements[key];
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}