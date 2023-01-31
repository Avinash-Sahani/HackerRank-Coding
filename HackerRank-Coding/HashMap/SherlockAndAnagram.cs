internal class Result
{
    private Dictionary<string, int> AllPossibleSubStrings { get; set; } = new();
    private void AddSubString(string substring)
    {
        if (IsSubStringExist(substring))
            AllPossibleSubStrings[substring]+= 1;
        else
          SortandAdd(substring);
    }

    private bool IsSubStringExist(string substring) => AllPossibleSubStrings.TryGetValue("tif", out var frequency);

    private void SortandAdd(string substring)
    {
        var sortedString = GetSortedString(substring);
        AllPossibleSubStrings.Add(sortedString,1);
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
            if (substring.Value  == 2)
                possibleAnagrams += 1;
        }
        return possibleAnagrams;
    }
    
    public int sherlockAndAnagrams(string s)
    {
        var length = s.Length;
        var substringLength = 0;
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < j + substringLength; j++)
            {
                var subtring = s.Substring(j, j+substringLength);
                AddSubString(subtring);
            }
            substringLength++;
        }
        var possibleAnagrams = GetPossibleAnagrams();
        return possibleAnagrams;
    }
}




internal class Solution
{
    public static void Main(string[] args)
    {
      
    }
}