using Num_3_ExtendingLinq.Utils;

namespace Num_3_ExtendingLinq;

public class Examples
{
    public void GetSongsDuration()
    {
        var input = "4:13,5:10,2:13,4:30,1:17,7:30";

        var result1 = input.Split(',')
            .Select(x => "0:" + x) // adding hour to date time formatted string
            .Select(TimeSpan.Parse) // converting to time span
            .Aggregate(TimeSpan.Zero, (x, y) => x + y);
        
        var result2 = input.Split(',')
            .Select(x => "0:" + x) // adding hour to date time formatted string
            .Select(TimeSpan.Parse) // converting to time span
            .Sum(); // no clash because only our methods on that IEnumerable 
    }
    
    // IN 6,1-3,2-4 OUT 1,2,3,4,6 
    public void RangesFullView() 
    {
        var input = "6,1-3,2-4";

        var result2 = input.Split(",")
            .Select(x => x.Split("-"))
            .Select(x => new { Start = int.Parse(x[0]), End = int.Parse(x.Last()) })
            .SelectMany(x => Enumerable.Range(x.Start, x.End - x.Start + 1))
            .OrderBy(x => x)
            .Distinct()
            .StringConcat(","); 
    }
    
    public IEnumerable<KeyValuePair<string, int>> CountBy(string[] strings)
    {
        return strings.CountBy(x => x switch { "A" or "B" or "C" => x, _ => "?" });

        //return strings.GroupBy(x => x switch { "A" or "B" or "C" => x, _ => "?" })// not optimal in large collections
        //.Select(x => new { Key = x.Key, Count = x.Count() });
    }
}