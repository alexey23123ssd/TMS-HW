namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] nums = new int[n];
            nums[0] = 0;
            nums[1] = 1;
            for(int i=2; i<nums.Length; i++)
            {
                nums[i] = nums[i - 2] + nums[i-1];
            }
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}