using Num_4_Laziness.Utils;

namespace Num_4_Laziness;

public class Examples
{   
    public void Deffer1()
    {
        var input = new List<string>{ "A", "B", "C", "D", "E" };

        input.Select(s =>
        {
            Console.WriteLine(s);
            return s.ToLower();
        });
        
        Console.WriteLine("Deffer2 DONE");
        Console.WriteLine("==============");
    }
    
    public void Deffer2()
    {
        var input = new List<string>{ "A", "B", "C", "D", "E" };

        var enumerable = input.Select(s =>
        {
            Console.WriteLine(s);
            return s.ToLower();
        }).Where(x=>x switch { "a" or "b" or "c" => true, _ => false });

        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Deffer3 DONE");
        Console.WriteLine("==============");
    }

    public void MultiUsage1()
    {
        var input = new List<PageInfo>()
        {
            new PageInfo("Azure"),
            new PageInfo("Azure DB"), 
            new PageInfo("Blazor"), 
            new PageInfo("WPF"),
            new PageInfo("Azure CI/CI"),
            new PageInfo("WPF UX"),
        };

        var azureResult = input.Where(x => x.Description.Contains("Azure")).Select(x =>x.Description).ToList();
        var WPFResult =  input.Where(x => x.Description.Contains("WPF")).Select(x =>x.Description).ToList();
    }
    
    public void MultiUsage2()
    {
        var input = new List<PageInfo>()
        {
            new PageInfo("Azure"),
            new PageInfo("Azure DB"), 
            new PageInfo("Blazor"), 
            new PageInfo("WPF"),
            new PageInfo("Azure CI/CI"),
            new PageInfo("WPF UX"),
        };

        var proxyInput = input.Select(x =>x.Description).ToList(); // RLY?

        var azureResult = proxyInput.Where(x => x.Contains("Azure")).ToList();
        var WPFResult =  proxyInput.Where(x => x.Contains("WPF")).ToList();
    }
}