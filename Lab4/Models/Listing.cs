namespace Lab4.Models;

public class Listing : LeafComponent
{
    public Listing(string value) : base(value)
    {
    }

    public Listing(string value, string title) : this(value)
    {
        Title = title;
    }

    public string Title { get; set; }

    public override string ToString()
    {
        return $"Listing({Title}):\n\t{Value}\n";
    }
}