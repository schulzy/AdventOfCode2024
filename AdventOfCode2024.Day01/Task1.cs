using AdventOfCode.Interfaces;

namespace AdventOfCode2024.Day01;

public class Task1(IContentParser contentParser) : IDailyTask<long>
{
    private readonly IContentParser _contentParser = contentParser;

    public long Run()
    {
        var distanceCalculator = new DistanceCalculator(_contentParser.GetLines("Task.txt"));

        return distanceCalculator.CalculateSimpleDistance();
    }

    public string Name => "Historian Hysteria";
}