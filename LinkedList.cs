namespace linkedList;

// Node class defined outside the LinkedList class
public class Node
{
    public int value;
    public Node? next;

    public Node(int value)
    {
        this.value = value;
    }
}

public class LinkedList
{
    private Node? head;
    private Node? tail;
    private int length;

    public LinkedList(int value)
    {
        Node newNode = new Node(value);

        head = newNode;
        tail = newNode;
        length = 1; 
    }

    public void Append(int value)
    {
        Node newNode = new Node(value);

       if (length == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.next = newNode;
            tail = newNode;
        }
        length++;
    }

    public void Append(params int[] values)
    {
        foreach (int value in values)
        {
            Append(value);
        }
    }

    public void PrintList()
    {
        Node? temp = head;

        while (temp != null)
        {
            Console.Write(temp.value + ",");
            temp = temp.next;
        }
        Console.WriteLine();
    }

    public void PrintAll()
    {
        if (length == 0)
        {
            Console.WriteLine("Head: null");
            Console.WriteLine("Tail: null");
        }
        else
        {
            Console.WriteLine("Head: " + head?.value);
            Console.WriteLine("Tail: " + tail?.value);
        }

        Console.WriteLine("Length: " + length);
        Console.WriteLine("\nLinked List:");

        if (length == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            PrintList();
        }
    }

    public void RemoveDuplicates()
    {
        Node? current = head;

        while (current != null && current.next != null)
        {
            if (current.value == current.next.value)
            {
                current.next = current.next.next;
                length --;
            }
            else
            {
                current = current.next;
            }
        }

        tail = current;
    }
}