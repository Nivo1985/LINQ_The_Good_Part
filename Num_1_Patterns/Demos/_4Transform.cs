using Num_1_Patterns.Demos.Util;

namespace Num_1_Patterns.Demos;

public class _4Transform:Basic
{
    public Dictionary<int, string> Old()
    {
        var result = new Dictionary<int, string>();

        foreach (var person in people)
        {
            result.Add(person.Id, person.Name);
        }

        return result;
    }

    public Dictionary<int, string> New() => people
        .Select(p => new { p.Id, p.Name })
        .ToDictionary(p => p.Id, p => p.Name);
}