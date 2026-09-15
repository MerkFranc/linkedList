namespace linkedList;

class Program
{
    static void Main(string[] args)
    {

        LinkedList duplicates = new LinkedList();
        duplicates.Append(1, 1, 2, 3, 3, 3, 4);

        Console.WriteLine("List before duplicates are removed:");
        duplicates.PrintList();

        duplicates.RemoveDuplicates();

        Console.WriteLine("List after duplicates are remvoved:");
        duplicates.PrintList();

        // ------

        Console.WriteLine("");

        LinkedList binary = new LinkedList();
        binary.Append(1, 0, 1, 0,  1);

        Console.WriteLine("Binary list:");
        binary.PrintList();

        int listValue = binary.GetDecimalValue();

        Console.WriteLine("Decimal value:");
        Console.WriteLine(listValue);

        // -----

        Console.WriteLine("");

        LinkedList binary2 = new LinkedList();

        int decimalvalue = 123;
        Console.WriteLine("Deciaml value: " + decimalvalue);
        binary2.DecimalToBinary(decimalvalue);

        Console.WriteLine("Binary list:");
        binary2.PrintList();
    }
}