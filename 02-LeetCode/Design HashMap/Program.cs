namespace Design_HashMap;

public class MyHashMap
{
    private int[] mapArray;

    public MyHashMap()
    {
        mapArray = new int[1000001];
        Array.Fill(mapArray, -1);
    }

    public void Put(int key, int value)
    {
        mapArray[key] = value;
    }

    public int Get(int key)
    {
        return mapArray[key];

    }

    public void Remove(int key)
    {
        mapArray[key] = -1;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}