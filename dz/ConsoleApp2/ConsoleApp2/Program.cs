using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        public const string EnterNumberMonth = "Введите номер месяца от 0 до 11:";
        public const string Winter = "Зима";
        public const string Sping = "Весна";
        public const string Summer = "Лето";
        public const string Autumn = "Осень";
        public const string NotCorrectValue = "Введено некорректное значение";
        static void Main(string[] args)
        {
            Console.Write(EnterNumberMonth);

            string inputLine = Console.ReadLine();
            if (!(Int32.TryParse(inputLine, out int monthNumber)))
                throw new ArgumentNullException(nameof(monthNumber)); // "monthNumber"

            Console.WriteLine(GetSeasonByMonth((Month)monthNumber));
        }

        public static string GetSeasonByMonth(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    return Winter;
                case Month.March:
                case Month.April:
                case Month.May:
                    return Sping;
                case Month.June:
                case Month.July:
                case Month.August:
                    return Summer;
                case Month.September:
                case Month.October:
                case Month.November:
                    return Autumn;
                default:
                    return NotCorrectValue;
            }
        }
    }
}