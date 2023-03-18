

using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

class MainProgram
{
    
    static void Main()
    {
        Console.WriteLine("Введите количество слов");
        int nemberWords = int.Parse(Console.ReadLine());
        Word[] words = new Word[nemberWords];
        for (int i = 0; i < nemberWords;i++)
        {
            Console.WriteLine("Введите " + (i+1) + " слово");
            words[i] = new Word(Console.ReadLine());
        }

        Console.WriteLine("a)");
        Console.WriteLine("Введите число страниц");
        int nember = int.Parse(Console.ReadLine());

        for(int i = 0; i < nemberWords; i++) if (nember > words[i].bePageNember) Console.WriteLine(words[i].word);

        Console.WriteLine("б)");
        string[] st = new string[nemberWords];
        
        for(int i = 0; i < nemberWords; i++) st[i] = words[i].word;
        Array.Sort(st);
        for (int i = 0; i < nemberWords; i++) Console.WriteLine(st[i]); ;
       
        Console.WriteLine("в)");
        Console.WriteLine("Введите слово");
        string testWord;
        int index = 0;
        for (bool i = true;i;)
        {
            testWord = Console.ReadLine();
            for (int j = 0; j < nemberWords; j++)
            {
                if(testWord == words[j].word)
                {
                    i = false;
                    index = j;
                    break;
                }
            }
            if (i) Console.WriteLine("Такого числа нет, попробуйте ещё.");
        }

        for (int i = 0; i < words[index].bePageNember; i++)
        {
            Console.WriteLine(words[index].pageNember[i]);
        }
    }

}