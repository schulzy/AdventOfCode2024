using AdventOfCode.Interfaces;
using AdventOfCode2024.Common;
using AdventOfCode2024.Day04;

namespace AdventOfCode2024.Tests;

public class Day04
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Task1Predefined()
    {
        IContentParser contentParser = new PredefinedContentParser();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(13));
    }
    
    [Test]
    public void Task1()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task1(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(27059));
    }
    
    [Test]
    public void Task2Predefined()
    {
        IContentParser contentParser = new PredefinedContentParser();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(30));
    }
    
    [Test]
    public void Task2()
    {
        IContentParser contentParser = new ContentParser();

        IDailyTask<long> sut = new Task2(contentParser);
        long result = sut.Run();
        Assert.That(result, Is.EqualTo(5744979));
    }

    internal class PredefinedContentParser : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return
            [
               ""
            ];
        }
    }
}