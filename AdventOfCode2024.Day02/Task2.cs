using AdventOfCode.Interfaces;

namespace AdventOfCode2024.Day02;

public class Task2(IContentParser contentParser) : IDailyTask<int>
{
    private readonly IContentParser _contentParser = contentParser;

    public int Run()
    {
        var reportProcessor = new ReportProcessor(_contentParser.GetLines("Task.txt"));

        return reportProcessor.SafeCodesTolerate();
    }

    public string Name => "Red-Nosed Reports Hard";
}