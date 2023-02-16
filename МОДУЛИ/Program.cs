class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[1000];
        int min = 10001;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 10000);
        }
        for (int g = 0; g < array.Length; g++)
        {
            if (array[g] % 21 == 0 && min > array[g])
            {
                for (int i = 0, j = 0; i < array.Length;)
                {
                    if (array[i] * array[j] == array[g]) (i, min) = (1000, array[g]);

                    if (j == array.Length - 1) (i, j) = (i + 1, 0);
                    else j++;
                }
            }
        }
        if (min == 10001) Console.WriteLine(-1);
        else Console.WriteLine(min);
    }
}