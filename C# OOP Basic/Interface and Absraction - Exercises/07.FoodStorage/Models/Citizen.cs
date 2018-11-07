
public class Citizen : IBuyer
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; }
    public string Birthdate { get; }


}

