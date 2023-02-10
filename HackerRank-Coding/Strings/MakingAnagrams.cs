class MakingAnagrams
{
    
    /*
    * Complete the 'makeAnagram' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. STRING a
    *  2. STRING b
    */
    private Dictionary<char, int> FirstSentence = new();
    private Dictionary<char, int> SecondSentence = new();

    
    private void CreateDictionary(Dictionary<char, int> dictionary, string input)
    {
        var charArray = input.ToCharArray();
        foreach (var c in charArray)
        {
            Add(dictionary, c);
        }
    }

    private int GetNoOfDeletion()
    {
        int deletion = 0;
        foreach (var pair in FirstSentence)
        {
            var FirstSetanceValue = FirstSentence[pair.Key];
            if (SecondSentence.ContainsKey(pair.Key))
            {
                deletion += Math.Abs(SecondSentence[pair.Key] -FirstSetanceValue);
            }
            else
                deletion += FirstSetanceValue;
   
           
        }

        foreach (var pair in SecondSentence)
        {
            if (!FirstSentence.ContainsKey(pair.Key))
                deletion += SecondSentence[pair.Key];
        }

        return deletion;

       
    }

    private void Add(Dictionary<char, int> dictionary, char c)
    {
        if (dictionary.ContainsKey(c))
            dictionary[c] += 1;
        else
            dictionary.Add(c, 1);
    }

  
   

    public int makeAnagram(string a, string b)
    {
        CreateDictionary(FirstSentence,a);
        CreateDictionary(SecondSentence,b);
        int output = GetNoOfDeletion();
        return output;
    }
}

/*class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = Result.makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}*/