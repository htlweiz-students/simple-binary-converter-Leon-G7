namespace program{
    class program{
        public static int Main(string[] args){
            int count = 0;

            Console.Writeline("Bitte geben sie eine Binärzahö ein:");
            string input = Console.Readline();

            for(int count = 0; count < input.Length; count++){
            {
            if(input[count] == '0' || input[count] == '1')
                {
                count++;
                }
            else
                {
                break;
                Console.Writeline("Fehler! Bitte geben sie 0 oder 1 ein!")
                }
            }


            return 0;
        }
    }
}