namespace AdventOfCode2024.Day01;

public class DistanceCalculator
{
    private List<int> _firstList = new List<int>();
    private List<int> _secondList = new List<int>();

    public DistanceCalculator(List<string> list) 
    {
        foreach (string line in list)
        {
             var elements =line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
             _firstList.Add(int.Parse(elements[0]));
             _secondList.Add(int.Parse(elements[1]));
        }
    }

    public long CalculateSimpleDistance()
    {
        _firstList.Sort();
        _secondList.Sort();
        long sum = 0;
        for (int i = 0; i < _firstList.Count; i++)
        {
            
            sum += Math.Abs(_secondList[i] - _firstList[i]);
        }
        
        return sum;
    }

    public long SimilarityScore()
    {
        long sum = 0;
        foreach (int element in _firstList)
        {
            int count = _secondList.Count(el => el == element);
            sum += element * count;
        }
        
        return sum;
    }
}