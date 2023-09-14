namespace _24._09;
public class Magazine
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int YearOfFoundation { get; set; }
    public string Telephone { get; set; }
    public string EMail { get; set; }

    public override string ToString() =>
        $"Name: {Name}\n" +
        $"Description: {Description}\n" +
        $"Year of foundation: {YearOfFoundation}\n" +
        $"Telephone: {Telephone}\n" +
        $"E-Mail: {EMail}\n\n";
}
