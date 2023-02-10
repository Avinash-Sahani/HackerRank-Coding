namespace HackerRank_Coding.HashMap;


internal class Solution
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();

        string b = Console.ReadLine();

        var anagram = new MakingAnagrams();
        int res = anagram.makeAnagram(a, b);
        Console.Write(res);

    }
}