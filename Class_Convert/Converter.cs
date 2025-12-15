namespace Converter
{
    public class convert_01
    {
        /// <summary>
        /// Class that converts a binary number to an dezimal number
        /// </summary>
        /// <param name="binarystring">Binary string from input [Values 0's and 1's]</param>
        /// <returns>The convertet number in dezimal</returns>
       public class BinaryConverter
{
    public ulong Convert(string binary)
    {
        ulong value = 0;

        foreach (char c in binary)
        {
            value = value * 2;
            if (c == '1')
                value = value + 1;
        }

        return value;
    }
}
