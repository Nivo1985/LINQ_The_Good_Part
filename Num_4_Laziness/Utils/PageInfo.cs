namespace Num_4_Laziness.Utils;

public class PageInfo
{
    private string Title { get;}
    public string Description => GetDescription();

    public PageInfo(string title)
    {
        Title = title;
    }
    private string GetDescription()
    {
        Console.WriteLine("Getting description for " + Title);
        return "Description for " + Title;
    }
}