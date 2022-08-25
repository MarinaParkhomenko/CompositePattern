namespace Lab4.Models;

public class Paragraph : CompositeComponent
{
    public override string ToString()
    {
        return String.Join(' ', _children.Select(c => c.ToString()));
    }
}