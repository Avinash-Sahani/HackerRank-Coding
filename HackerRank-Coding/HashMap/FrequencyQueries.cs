namespace HackerRank_Coding.HashMap;

public class FrequencyQueries
{
    private List<int> OperationsOutput { get; set; } = new();
    private Dictionary<int, int> Data = new();

    private void Add(int number)
    {
        if (Data.TryGetValue(number,out var value))
            Data[number] += 1;
        else
            Data.Add(number,1);

    }

    private void Delete(int number)
    {
        if (!Data.TryGetValue(number,out var num)) return;
        var value = Data[number] - 1;
        if (value < 0)
            value = 0;
        Data[number] = value;
        var map = new LinkedList<int>();


    }

    private void MatchFrequeny(int matchFreq)
    {
        var matchedFreq = Data.Any(pair => pair.Value == matchFreq);
        OperationsOutput.Add(matchedFreq ? 1 :0);
        
    }

    private void PerformOperation(int operationIndex,int number)
    {
        switch (operationIndex)
        {
            
            case  1:
                Add(number);
                break;
            case 2:
                Delete(number);
                break;
            case 3:
                MatchFrequeny(number);
                break;
        }
    }

        public List<int> freqQuery(List<List<int>> queries)
    {

        foreach (var query in queries)
        {
           PerformOperation(query[0],query[1]);
        }

        return OperationsOutput;
    }
}