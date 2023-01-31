internal class Result
{
    /*
     * Complete the 'sherlockAndAnagrams' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int sherlockAndAnagrams(string s)
    {
        return 0;
    }
}

internal class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var q = Convert.ToInt32(Console.ReadLine().Trim());

        for (var qItr = 0; qItr < q; qItr++)
        {
            var s = Console.ReadLine();

            var result = Result.sherlockAndAnagrams(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}