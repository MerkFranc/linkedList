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

    public LinkedList()
    {
        head = null;
        tail = null;
        length = 0;
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

    public void Prepend(int value)
    {
        Node newNode = new Node(value);

        if (length == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = head;
            head = newNode;
        }
        length ++;
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

    public int GetDecimalValue()
    {
        int total = 0;
        Node? current = head;

        while (current != null)
        {
            total = total * 2 + current.value;
            current = current.next;
        }

        return total;
    }

    public void DecimalToBinary(int decimalNumber)
    {
        // Special case for 0
        if (decimalNumber == 0)
        {
            Prepend(0);
            return;
        }

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;

            Prepend(remainder);

            decimalNumber /= 2;
        }
    }
}