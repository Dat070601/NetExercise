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
    }
}