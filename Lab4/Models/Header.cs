namespace Lab4.Models;

public class Header : LeafComponent
{
    public Header(string value) : base(value)
    {
    }
    
    public override string ToString()
    {
        return Value.ToUpper();
    }
}