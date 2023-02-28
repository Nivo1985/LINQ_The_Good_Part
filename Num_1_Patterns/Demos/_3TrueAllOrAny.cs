using Num_1_Patterns.Demos.Util;

namespace Num_1_Patterns.Demos;

public class _3TrueAllOrAny: Basic
{
    public void OldAny(int id =2)
    {
        var result = false;
        foreach (var person in people)
        {
            if (person.Id <= id) continue;
            result = true;
            break;
        }

        Console.WriteLine(result);
    }
    public void OldAll(int id =2)
    {
        var result = true;
        foreach (var person in people)
        {
            if (person.Id > id) continue;
            result = false;
            break;
        }

        Console.WriteLine(result);
    }
    
    public void NewAny(int id =2) => Console.WriteLine(people.Any(p=>p.Id > id));

    public void NewAll(int id =2) => Console.WriteLine(people.All(p=>p.Id > id));
}