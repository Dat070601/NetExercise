namespace Bai2.Service
{
    public class DocumentManagement : IDocumentManagement
    {
        public List<Documents> ListDocuments{ get; set; }
        public DocumentManagement()
        {
            ListDocuments = new List<Documents>(){
                new Book("Book001","KimDong",100,"HoangDat",90),
                new Newspaper("Newspapper001","HoangDat",100,"07-06-2022"),
                new Book("Book002","NhiDong",90,"LeHuy",100),
                new Magazine("Magazine001","NhiDong",67,01,01)
            };         
        }

        public void AddDocument(Documents Document)
        {
            var findDocsId = ListDocuments.Where(doc => doc.Id.Contains(Document.Id)).FirstOrDefault();
            if(findDocsId != null)
            {
                Console.WriteLine("Documents is already exists!");
            }
            else
            {
                ListDocuments.Add(Document);
            }        
        }

        public void GetAllDocuments(IEnumerable<Documents> listDocuments)
        {
            Console.WriteLine("List Documents: ");
            foreach (var item in listDocuments)
            {
                item.OutPut();
            }
        }

        public void CheckType(Type typeClass)
        {
            var listDoc = ListDocuments.Where(doc => doc.GetType().ToString().Contains(typeClass.ToString()));
            if(listDoc.Count() == 0)
            {
                Console.WriteLine("Can not find Document");
            }
            else{
                GetAllDocuments(listDoc);
                SearchDocumentsByPublisher(listDoc);
            }
        }

        public void SearchDocumentsByPublisher(IEnumerable<Documents> typeDoc)
        {
            Console.WriteLine("Enter name of publisher to search: ");
            string? publisherName = Console.ReadLine();
            var listByPublisher = typeDoc.Where(byDoc => byDoc.Publisher.ToLower().Contains(publisherName.ToLower()));
            if(listByPublisher == null)
            {
                Console.WriteLine("No publisher found");
            }
            else
            {
                GetAllDocuments(listByPublisher);
            }
        }

        public void SearchDocumentsByTypes(string? type)
        {
            switch(type)
            {
                case "Book":
                {
                    CheckType(typeof(Book));
                    break;
                }
                case "Magazine":
                {
                    CheckType(typeof(Magazine));
                    break;
                }
                case "Newspaper":
                {
                    CheckType(typeof(Newspaper));
                    break;
                }
                default:
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }

        public void RemoveDocumentById(string idDocument)
        {
            var docs = ListDocuments.Where(doc => doc.Id.ToLower().Contains(idDocument.ToLower())).FirstOrDefault();
            if(docs == null)
                Console.WriteLine("Documents not exists!");
            else
            {
                ListDocuments.Remove(docs);
                Console.WriteLine("List after delete");
                GetAllDocuments(ListDocuments);
            }
        }

        public void AddDetailDocument(Documents document, string type)
        {
            switch (type)
            {
                case "B":
                {
                    Documents AddBook = new Book().ReturnObject(document.Id, document.Publisher,document.Versions);
                    AddDocument(AddBook);
                    break;
                }
                case "M":
                {   
                    Documents AddMagazine = new Magazine().ReturnObject(document.Id, document.Publisher,document.Versions);
                    AddDocument(AddMagazine);
                    break;
                }
                case "N":
                {
                    Documents AddNews = new Newspaper().ReturnObject(document.Id, document.Publisher,document.Versions);
                    AddDocument(AddNews);
                    break;
                }
                default:
                {
                    Console.WriteLine("Unknown document");
                    break;
                }
            }
        }

        public void GetDocuments()
        {
            foreach (var item in ListDocuments)
            {
                item.OutPut();
            }
        }
    }
}