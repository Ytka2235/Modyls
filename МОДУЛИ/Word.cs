

class Word
{
    public string word;
    
    public int[] pageNember;
    public int bePageNember;
    

    public Word(string word)
    {
        this.word = word;
        List<int> page = new List<int>();
        Random rnd= new Random();
        int x = rnd.Next(1, 10);
        for (int i = 0;i<10;i++)
        {
            if(rnd.Next(1, 10) >= x) page.Add(i+1);
        }
        int[] pageNember = new int[page.Count];
        for (int i = 0;i<page.Count;i++) pageNember[i] = page[i];
        this.pageNember = pageNember;
        bePageNember = pageNember.Length;

    }

}

