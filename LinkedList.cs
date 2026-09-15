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

    
    /// <summary>
    /// Since list is already sorted in ascending order, I use a pionter and a while loop to run through the list.
    /// I check the current value and the next value, and if they are the same I change the .next value to .next.next value.
    /// If they are different I advance to the next node. 
    /// The loop exists when current.next == null which is the end of the list.
    /// </summary>
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
    // <time complexity>
    // O(n)


    /// <summary>
    /// int total keeps a running total
    /// A pointer 'current' and a while loop is used to run through the list
    /// At every node do: total = total * 2 + node.value. This gets the decimal value.
    /// return total at the end
    /// </summary>
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
    // Time Complexity
    // O(n)

    /// <summary>
    /// Pass in a decimal value as a parameter
    /// Use a while loop to keep going until the decimal number reaches 0
    /// While the number is greater than zero mod by 2 to get the remainder which is the binary digit
    /// Prepend the remainder becuase it is the most significant bit
    /// divide the number by 2 
    /// While loop ends when number is not greater than 0
    /// </summary>
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
    // Time Complexity
    // O(log n)
}