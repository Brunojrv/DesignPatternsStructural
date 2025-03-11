using DesignPatternsStructural.Proxy.Interface;

namespace DesignPatternsStructural.Proxy.Entities
{
    public class Document : IDocument
    {
        private string _content;

        public Document(string content)
        {
            _content = content;
        }

        public void Display()
        {
            Console.WriteLine($"Exibindo documento: {_content}");
        }

        public void Edit(string newContent)
        {
            _content = newContent;
            Console.WriteLine("Documento editado.");
        }

        public void Approve()
        {
            Console.WriteLine("Documento aprovado!");
        }
    }
}
