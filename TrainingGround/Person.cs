
public class Person
{
    public Person() { }
    public Person(string name)
    {
        this.Name = name;
    }
    public string? Name { get; private set; }
    public int BirthYear;
    public double LengthInMeters;
    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
}
