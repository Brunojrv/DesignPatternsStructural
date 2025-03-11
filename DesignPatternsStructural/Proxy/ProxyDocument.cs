using DesignPatternsStructural.Proxy.Entities;
using DesignPatternsStructural.Proxy.Enum;
using DesignPatternsStructural.Proxy.Interface;

namespace DesignPatternsStructural.Proxy
{
    public class ProxyDocument : IDocument
    {
        private readonly Document _realDocument;
        private readonly PermissionLevel _permission;

        public ProxyDocument(string initialContent, PermissionLevel permission)
        {
            _realDocument = new Document(initialContent);
            _permission = permission;
        }

        public void Display()
        {
            _realDocument.Display();
        }

        public void Edit(string newContent)
        {
            if (_permission == PermissionLevel.Viewer)
            {
                Console.WriteLine("Acesso negado: nível Viewer não pode editar.");
                return;
            }

            _realDocument.Edit(newContent);
        }

        public void Approve()
        {
            if (_permission != PermissionLevel.Admin)
            {
                Console.WriteLine("Acesso negado: apenas Admin pode aprovar.");
                return;
            }

            _realDocument.Approve();
        }
    }

}
