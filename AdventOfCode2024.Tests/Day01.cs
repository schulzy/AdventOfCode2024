using AdventOfCode.Interfaces;
using AdventOfCode2024.Common;
using AdventOfCode2024.Day01;

namespace AdventOfCode2024.Tests;

public class Day01
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Task1Predefined()
    {
        IContentParser contentParser = new PredefinedContentParserTask();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(11));
    }
    
    [Test]
    public void Task1()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(1197984));
    }
    
    [Test]
    public void Task2Predefined()
    {
        IContentParser contentParser = new PredefinedContentParserTask();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(31));
    }
    
    [Test]
    public void Task2()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(23387399));
    }

    internal class PredefinedContentParserTask : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
                    {
                        
                        "3   4",
                        "4   3",
                        "2   5",
                        "1   3",
                        "3   9",
                        "3   3"
                    };
        }
    }
}