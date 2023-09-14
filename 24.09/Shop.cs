namespace _24._09;
public class Shop
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string Telephone { get; set; }
    public string EMail { get; set; }

    public override string ToString() =>
       $"Name: {Name}\n" +
       $"Description: {Description}\n" +
       $"Address: {Address}\n" +
       $"Telephone: {Telephone}\n" +
       $"E-Mail: {EMail}\n\n";
}
