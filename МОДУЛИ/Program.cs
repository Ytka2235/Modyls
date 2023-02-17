class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[1000];
        int min = 20000;
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 10000);
        }

        for (int i = 0;i<array.Length - 1;i++)
        {
            if (((array[i] % 37 == 0 && array[i+1] % 73 ==0) || (array[i] % 37 == 0 && array[i + 1] % 73 == 0)) && (array[i] - array[i-1] == 1 || array[i] - array[i - 1] == -1))
            {
                counter++;
                if (min > array[i] + array[i + 1]) min = array[i] + array[i + 1];
            }
        }

        Console.WriteLine(counter);
        if (counter != 0)Console.WriteLine(min);
    }
}