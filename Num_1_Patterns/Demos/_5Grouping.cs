using Num_1_Patterns.Demos.Util;

namespace Num_1_Patterns.Demos;

public class _5Grouping: Basic
{
    public Dictionary<string, List<Person>> Old()
    {
        var result = new Dictionary<string, List<Person>>();
        
        foreach (var person in people)
        {
            if (!result.ContainsKey(person.Country))
            {
                result.Add(person.Country, new List<Person>(){person});
            }
            else
            {
                result[person.Country].Add(person);
            }
        }

        return result;
    }
    public Dictionary<string, List<Person>> New() =>  people.GroupBy(p => p.Country)
            .ToDictionary(p=>p.Key,p=>p.ToList());
}