using System.Text;

namespace Lab4.Models;

public class Sentence : CompositeComponent
{
    public override string ToString()
    {
        var sb = new StringBuilder();
        
        foreach (var child in _children)
        {
            if (sb.Length != 0 && child is not PunctuationMark)
                sb.Append(" ");
       
            sb.Append(child.ToString());
        }

        return sb.ToString();
    }
}