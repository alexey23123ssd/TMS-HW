using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру:");
            int t;
            t = Convert.ToInt32(Console.ReadLine());
            if ( t > -5 )
            {
                Console.WriteLine("Тепло");
            }
            else if ( t <= -5 & t > -20)
            {
                Console.WriteLine("Прохладно");
            }
            else 
            {
                Console.WriteLine("Холодно");
            }
        }
    }
}
