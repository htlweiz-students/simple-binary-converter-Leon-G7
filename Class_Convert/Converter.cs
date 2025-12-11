namespace Converter {
    public class convert_01{
        public int convert_class (string binarystring){

            int result = 0;

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