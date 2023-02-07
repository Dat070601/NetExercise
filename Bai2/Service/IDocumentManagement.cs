namespace Bai2.Service
{
    public interface IDocumentManagement
    {
        public void RemoveDocumentById(string idDocument);
        public void AddDocument(Documents Document);
        public void GetAllDocuments(IEnumerable<Documents> listDocuments);
        public void GetDocuments();
        public void CheckType(Type typeClass);
        public void SearchDocumentsByTypes(string Type);
        public void SearchDocumentsByPublisher(IEnumerable<Documents> typeDoc);
        public void AddDetailDocument(Documents document,string type);
    }
}