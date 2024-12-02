namespace AdventOfCode2024.Day02;

public class ReportProcessor
{
    private List<List<int>> _reports = new List<List<int>>();
    public ReportProcessor(List<string> list)
    {
        foreach (string line in list)
        {
            var elements =line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var report = new List<int>();
            foreach (var element in elements)
            {
                report.Add(int.Parse(element));
            }
            _reports.Add(report);
        }
    }

    public int SafeCodes()
    {
        var total = 0;
        foreach (List<int> report in _reports)
        {
            if ((report[0] - report[1] < 0 && CheckPositiveReport(report)) || (report[0] - report[1] > 0 && CheckNegativeReport(report))) 
            {
                total++;
            }
        }
        return total;
    }
    
    public int SafeCodesTolerate()
    {
        var total = 0;
        foreach (List<int> report in _reports)
        {
            if ((report[0] - report[1] < 0 && CheckPositiveReport(report)) || (report[0] - report[1] > 0 && CheckNegativeReport(report))) 
            {
                total++;
            }
            else if (DoubleCheck(report))
            {
                total++;
            }
        }
        return total;
    }

    private bool DoubleCheck(List<int> report)
    {
        for (int i = 0; i < report.Count(); i++)
        {
            List<int> temp = new List<int>(report);
            temp.RemoveAt(i);
            if ((temp[0] - temp[1] < 0 && CheckPositiveReport(temp)) || (temp[0] - temp[1] > 0 && CheckNegativeReport(temp))) 
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckPositiveReport(List<int> report)
    {
        for (int i = 0; i < report.Count-1; i++)
        {
            int diff = report[i + 1] - report[i];
            if(diff > 0 && diff <= 3)
                continue;
            return false;
        }
        return true;
    }
    
    private bool CheckNegativeReport(List<int> report)
    {
        for (int i = 0; i < report.Count-1; i++)
        {
            int diff = report[i] - report[i + 1];
            if(diff > 0 && diff <= 3)
                continue;
            return false;
        }
        return true;
    }
}