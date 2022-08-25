namespace Lab4.Models;

public abstract class LeafComponent : ITextComponent
{
    public string Value { get; set; }

    public LeafComponent(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}