namespace program
{
    class program_01
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie eine Binärzahö ein:");
            string input = Console.ReadLine();

            for (int count = 0; count < input.Length; count++)
            {
                if (input[count] != '0' && input[count] != '1')
                {
                    Console.WriteLine("Fehler! Bitte geben sie 0 oder 1 ein!");
                    return 1;
                }
            }

            return 0;
        }
    }
}
