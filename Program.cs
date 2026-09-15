namespace linkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList(1);
        list.Append(1, 2, 3, 3, 3, 4);

        list.PrintList();

        list.RemoveDuplicates();

        
        list.PrintList();

    }
}