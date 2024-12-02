using AdventOfCode.Interfaces;

namespace AdventOfCode2024.Day01;

public class Task2(IContentParser contentParser) : IDailyTask<long>
{
    private readonly IContentParser _contentParser = contentParser;

    public long Run()
    {
        var distanceCalculator = new DistanceCalculator(_contentParser.GetLines("Task.txt"));

        return distanceCalculator.SimilarityScore();
    }

    public string Name => "Historian Hysteria Hard";
}