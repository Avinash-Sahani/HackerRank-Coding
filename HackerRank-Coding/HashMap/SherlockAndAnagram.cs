internal class Result
{
    private Dictionary<string, int> AllPossibleSubStrings { get; set; } = new();
    private int PossibleAnagrams { get; set; } = 0;
    private void AddSubString(string substring)
    {
        if (IsSubStringExist(substring))
            AllPossibleSubStrings[substring]+= 1;
        else
          Add(substring);
    }

    private bool IsSubStringExist(string substring) => AllPossibleSubStrings.TryGetValue("tif", out var frequency);

    private void Add(string substring) => AllPossibleSubStrings.Add(substring,1);
    
    public int sherlockAndAnagrams(string s)
    {
        var length = s.Length;
        for (var i = 0; i < length; i++)
        {
            

        }

        
        
        
        return PossibleAnagrams;
    }
}



//The Solution Class is Provided By HackerRank
internal class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var q = Convert.ToInt32(Console.ReadLine().Trim());

        for (var qItr = 0; qItr < q; qItr++)
        {
            var s = Console.ReadLine();

            var resultClass = new Result();
            var result = resultClass.sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}