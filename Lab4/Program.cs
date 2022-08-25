using Lab4.Models;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();

            var paragraph1 = new Paragraph();

            var header = new Header("Header");

            var sentence = new Sentence();
            sentence.AddChildren(new ITextComponent[]
            {
                new Word("Lorem"), new Word("ipsum"), new Word("sit"), new Word("atmet"), new PunctuationMark(","),
                new Word("consectetur"), new Word("adipiscing"), new Word("elit"), new PunctuationMark(","), new Word("sed"),
                new Word("do"), new Word("eiusmod"), new Word("tempor"), new PunctuationMark(".")
            });

            text.AddChild(header);
            paragraph1.AddChild(sentence);

            text.AddChild(paragraph1);

            text.AddChild(new Listing("Console.WriteLine(\"Hello World\")", "C# Code"));

            Console.WriteLine(text.ToString());

        }
    }
}
