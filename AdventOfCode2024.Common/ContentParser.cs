using System.Reflection;
using AdventOfCode.Interfaces;

namespace AdventOfCode2024.Common;

public class ContentParser : IContentParser
{
    public List<string> GetLines(string manifestName)
    {
        var lines = new List<string>();
        var assembly = Assembly.GetCallingAssembly();
        var manifest = assembly.GetManifestResourceNames().FirstOrDefault(x=> x.EndsWith(manifestName));
        if (manifest == null)
            return lines;
        using var stream = assembly.GetManifestResourceStream(manifest);
        if (stream == null)
            return lines;

        var reader = new StreamReader(stream);
        while (reader.Peek() >= 0)
        {
            var line = reader.ReadLine();
            lines.Add(line ?? "");
        }

        return lines;
    }
}