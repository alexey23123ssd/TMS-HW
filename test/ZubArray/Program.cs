namespace ZubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ----
             * -----
             * ------
             */
            int[][] zubArray = new int[3][];
            zubArray[0] = new int[4];
            zubArray[1] = new int[5];   
            zubArray[2] = new int[6];
            double sum = 0;
            double lengthSubarrays = 0;

            /*
             0 1 2 3
             */
            for (int i = 0; i < zubArray[0].Length; i++)
            {
                zubArray[0][i] = i;
            } 
            /*
             0 1 2 3 4
             */
            for(int i = 0; i < zubArray[1].Length; i++)
            {
                zubArray[1][i] = i;
            }
            /*
             0 1 2 3 4 5
             */
            for(int i = 0; i < zubArray[2].Length; i++)
            {
                zubArray[2][i] = i;
            }

            for(int i = 0; i < zubArray.Length; i++)
            {
                lengthSubarrays = lengthSubarrays + zubArray[i].Length;

                for(int j = 0; j < zubArray[i].Length; j++)
                {
                    sum = sum + zubArray[i][j];
                }
            }
            Console.WriteLine(sum/ lengthSubarrays);
        }
    }
}