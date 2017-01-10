namespace Timer
{
    using System;
    using System.Text;

    class TimerStartUp
    {
        private static readonly Encoding EncodingOEMUnitedStates = Encoding.GetEncoding(437);

        public static void PasswordGenerator(int x)
        {
            string character = EncodingOEMUnitedStates.GetString(new byte[] { (byte)x });
            Console.Write(character);
        }

        public static void AddNewLine(int x)
        {
            Console.WriteLine();
        }

        public static void Main()
        {
            Timer passGenerator = new Timer(PasswordGenerator, 16, 1000);
            passGenerator.ExecuteAction();

            Timer addNewLine = new Timer(AddNewLine, 1, 20000);
            addNewLine.ExecuteAction();
        }
    }
}
