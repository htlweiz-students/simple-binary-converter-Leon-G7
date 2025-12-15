using System;

class Program
{
    static void Main()
    {
        BinaryConverter converter = new BinaryConverter();

        string binary = "";
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "0" || input == "1")
            {
                binary = binary + input;
            }
            else
            {
                break;
            }
        }

        ulong result = converter.Convert(binary);
        Console.WriteLine(result);
    }
}
