namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 53, -43, 212, 10, -3 };
            int temp;
            for(int i = 0; i < numbers.Length-1; i++)
            {
                for(int j=i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp=numbers[i];
                        numbers[i]=numbers[j];  
                        numbers[j]=temp;
                    }
                }
                
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}