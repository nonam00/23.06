namespace _24._09;

public class WebPage
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string IpAddress { get; set; }

    public override string ToString() =>
        $"Name: {Name}\n" +
        $"Url: {Url}\n" +
        $"Descrription: {Description}\n" +
        $"IpAddress: {IpAddress}\n";

}
