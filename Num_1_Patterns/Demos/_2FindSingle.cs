using Num_1_Patterns.Demos.Util;

namespace Num_1_Patterns.Demos;

public class _2FindSingle: Basic
{
    public void Old(int id =2)
    {
        Person result = null;
        foreach (var person in people)
        {
            if (person.Id != id) continue;
            result = person;
            break;
        }

        Console.WriteLine(result.Name);
    }

    public void New(int id =2) => Console.WriteLine(people.FirstOrDefault(p => p.Id == id)?.Name);
}