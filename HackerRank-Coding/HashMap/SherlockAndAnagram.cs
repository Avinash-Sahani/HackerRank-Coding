internal class Anagram
{
    private Dictionary<string, int> AllPossibleSubStrings { get; set; } = new();
    private void AddSubString(string substring)
    {
        if(string.IsNullOrEmpty(substring) || string.IsNullOrWhiteSpace(substring)) return;
        var sortedString = GetSortedString(substring);
        if (IsSubStringExist(sortedString))
            AllPossibleSubStrings[sortedString]+= 1;
        else
          Add(sortedString);
    }

    private bool IsSubStringExist(string substring) => AllPossibleSubStrings.TryGetValue(substring, out var value);

    private void Add(string substring)
    {
        AllPossibleSubStrings.Add(substring,1);
    }

    private string GetSortedString(string s)
    {
        var characters = s.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
    private int GetPossibleAnagrams()
    {
        var possibleAnagrams = 0;
        foreach (var substring in AllPossibleSubStrings)
        {
            if (substring.Value >= 2)
            {
                var freq = substring.Value - 1;
                while (freq!=0)
                {
                    possibleAnagrams += freq;
                    freq--;
                }
            }
        }
        return possibleAnagrams;
    }
    
    public int sherlockAndAnagrams(string s)
    {
        var length = s.Length;
        for (var i = 1; i < length; i++)
        {
            for (var j = 0; (i+j)<=length ; j++)
            {

                var subtring = s.Substring( j, i);
                AddSubString(subtring);
            }
         
        }
        var possibleAnagrams = GetPossibleAnagrams();
        return possibleAnagrams;
    }
    
}




internal class Solution
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine() ?? string.Empty;
        var anagram = new Anagram();
        Console.WriteLine(anagram.sherlockAndAnagrams(input));
        
        
    }
}