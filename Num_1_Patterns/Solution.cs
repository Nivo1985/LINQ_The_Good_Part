namespace Num_1_Patterns;
// funny sum. Sum the comma seperated numbers but skip three smallest one
public static class Solution
{
    public static int Calculate_Old(string scores)
    {
        var intScores = new List<int>();
        
        foreach (var score in scores.Split(","))
        {
            intScores.Add(int.Parse(score));
        }
        
        intScores.Sort();

        var result = 0;

        for (var i = 3; i < intScores.Count; i++)
        {
            result += intScores[i];
        }

        return result;
    }

    public static int Calculate_New(string scores) => scores
        .Split(",")
        .Select(int.Parse)
        .OrderBy(x => x)
        .Skip(3)
        .Sum();
}