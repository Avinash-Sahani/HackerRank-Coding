namespace HackerRank_Coding.HashMap;


internal class Solution
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine() ?? string.Empty;
        var anagram = new Anagram();
        Console.WriteLine(anagram.sherlockAndAnagrams(input));
        
        
    }
}