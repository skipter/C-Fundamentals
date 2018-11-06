
public class Robots : IBirthdayDate
{
    public Robots(string model, string id, string birthdate)
    {
        this.Model = model;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Model { get; private set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }
}

