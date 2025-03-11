namespace DesignPatternsStructural.Proxy.Interface
{
    public interface IDocument
    {
        void Display();

        void Edit(string newContent);

        void Approve();
    }
}
