namespace Lab4.Models;

public class Text : CompositeComponent
{
    public override string ToString()
    {
        return String.Join('\n', _children.Select(c => c.ToString()));
    }
}