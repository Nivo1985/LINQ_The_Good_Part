namespace Num_1_Patterns.Demos.Util;

public class Basic
{
    protected List<Person> people = new()
    {
        new Person(){Name = "Karol Rogowski", Id = 1, Country = "Poland"},
        new Person(){ Name = "Adam Tuk", Id = 2, Country = "Poland" },
        new Person(){ Name = "Ola Gors", Id = 3, Country = "Poland" },
        new Person(){ Name = "Kasia Kot", Id = 4, Country = "England" },
        new Person(){ Name = "Tomasz Rud", Id = 5, Country = "England" },
    };
}