namespace Converter {
    public class convert{
        public int convert(string binarystring){
            foreach (char c in binarystring)
            {
                result = result * 2;
                if (c == '1')
                    result += 1;
            }
            return result;
        }
        

    }
}