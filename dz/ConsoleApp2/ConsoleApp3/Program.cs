namespace Program
{
    class Program
    {
        public const string EnterNumber = "Введите число: ";
        public const string Even = "Четное";
        public const string Odd = "Нечтное";
        static void Main(string[] args)
        {
            Console.Write(EnterNumber);
            string input = Console.ReadLine();
            if(Double.TryParse(input, out double number))
            {
                if(number % 2 == 0)
                    Console.WriteLine(Even);
                else
                    Console.WriteLine(Odd);
            }
        }
    }
}
