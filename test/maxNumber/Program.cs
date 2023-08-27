namespace maxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 53, 211, 0, -42 };
            int maxNumber;
            for(int i= 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    maxNumber= numbers[i];
                }
                else
                {
                    maxNumber= numbers[i+1];
                }
            }   
        }
    }
}