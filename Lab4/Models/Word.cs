namespace Lab4.Models;

public class Word : LeafComponent
{
    public Word(string value) : base(value)
    {
    }

    public override string ToString()
    {
        return Value;
    }
}