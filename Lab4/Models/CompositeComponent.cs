namespace Lab4.Models;

public abstract class CompositeComponent : ITextComponent
{
    protected readonly List<ITextComponent> _children = new List<ITextComponent>();

    public void AddChild(ITextComponent component)
    {
        _children.Add(component);
    }

    public void AddChildren(IEnumerable<ITextComponent> components)
    {
        _children.AddRange(components);
    }
}