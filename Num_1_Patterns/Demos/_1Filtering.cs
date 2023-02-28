using Num_1_Patterns.Demos.Util;

namespace Num_1_Patterns.Demos;

public class _1Filtering: Basic
{
    public void Old()
    {
        Console.WriteLine("Filtering Old result");
        foreach (var person in people)
        {
            if (person.Id > 1)
            {
                Console.WriteLine(person.Name);
            }
        }
    }

    public void New() => people.Where(p=> p.Id > 1).ToList().ForEach(p=> Console.WriteLine(p.Name));
}