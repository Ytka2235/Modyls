class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int nemberVote = rnd.Next(10,1000);
        int[] pair = new int[16];
        for (int i = 0;i < pair.Length;i++)
        {
            pair[i] = 0;
        }

        for (int i = 1; i <= nemberVote;i++)
        {
            pair[rnd.Next(1, 16) - 1]++;
        }

        for(int i = 0;i < pair.Length;i++)
        {
            if (pair[i] != 0) Console.WriteLine(i+1 + " " + pair[i]);
        }
    }
}