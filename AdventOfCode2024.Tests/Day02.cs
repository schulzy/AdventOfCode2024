using AdventOfCode.Interfaces;
using AdventOfCode2024.Common;
using AdventOfCode2024.Day02;

namespace AdventOfCode2024.Tests;

public class Day02
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Task1Predefined()
    {
        IContentParser contentParser = new PredefinedContentParser();

        IDailyTask<int> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Task1()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<int> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(631));
    }
    
    [Test]
    public void Task2Predefined()
    {
        IContentParser contentParser = new PredefinedContentParser();

        IDailyTask<int> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Task2()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<int> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(665));
    }

    internal class PredefinedContentParser : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "7 6 4 2 1",
                "1 2 7 8 9",
                "9 7 6 2 1",
                "1 3 2 4 5",
                "8 6 4 4 1",
                "1 3 6 7 9"

            };
        }
    }
}