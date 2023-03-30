namespace Num_2_Pipelines;

public class Examples
{
    public void GetSongsDuration()
    {
        var input = "4:13,5:10,2:13,4:30,1:17,7:30";

        var result1 = 
            TimeSpan.FromSeconds(
            input.Split(',')
            .Select(x => "0:" + x)// adding hour to date time formatted string
            .Select(TimeSpan.Parse) // converting to time span
            .Select(x => x.TotalSeconds)
            .Sum());

        var result2 = input.Split(',')
            .Select(x => "0:" + x) // adding hour to date time formatted string
            .Select(TimeSpan.Parse) // converting to time span
            .Aggregate(TimeSpan.Zero, (x, y) => x + y);
        
        var result3 = input.Split(',')
            .Select(x => TimeSpan.Parse("0:" + x))
            .Aggregate(TimeSpan.Zero, (x, y) => x + y);
    }

    // IN 1,3,5-7,9 OUT 1,3,5,6,7,9 
    // IN 6,1-3,2-4 OUT 1,2,3,4,6 
    public void RangesFullView() 
    {
        var input = "6,1-3,2-4";
        var result1 = input.Split(",")
            .Select(x => x.Split("-"))
            .Select(x => new { Start = int.Parse(x[0]), End = int.Parse(x[x.Length == 1 ? 0 : 1]) })
            .SelectMany(x => Enumerable.Range(x.Start, x.End - x.Start + 1))
            .OrderBy(x=>x)
            .Distinct().ToList();

        
        var result2 = input.Split(",")
            .Select(x => x.Split("-"))
            .Select(x => new { Start = int.Parse(x[0]), End = int.Parse(x.Last()) })
            .SelectMany(x => Enumerable.Range(x.Start, x.End - x.Start + 1))
            .OrderBy(x=>x)
            .Distinct().ToList();
    }
}