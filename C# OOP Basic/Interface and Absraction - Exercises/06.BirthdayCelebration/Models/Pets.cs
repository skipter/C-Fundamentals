
public class Pets : IBirthdayDate
{
    public Pets(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }
    public string Birthdate { get; private set; }

    public override string ToString()
    {
        return $"{this.Birthdate}";
    }
}

