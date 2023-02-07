namespace Bai2.Service
{
    class UIService : IUIService
    {
        private readonly IDocumentManagement documentManagement;
        public UIService(IDocumentManagement DocumentManagement)
        {
            documentManagement = DocumentManagement;
        }
        public Documents AddInfoBasicDocument()
        {
            try
            {
                Console.Write("Enter Id of Document: ");
                string? id = Console.ReadLine();
                Console.Write("Enter Name of Publisher: ");
                string? namePublisher = Console.ReadLine();
                Console.Write("Enter Number of Versions: ");
                int versions = Int32.Parse(Console.ReadLine());  
                return new Documents(id, namePublisher, versions){
                    IsSuccess = true,
                };
            }
            catch (Exception e)
            {
                return new Documents(){
                    IsSuccess = false,
                    ErrorMessage = e.Message
                };
            }
        }

        public void CountToAdd()
        {
            Console.WriteLine("Enter the number of Document you want to add: ");
            int Quantity = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < Quantity; i++)
            {
                var AddBasicInfo = AddInfoBasicDocument();
                var AddType = GetTypeDocument();
                if(AddBasicInfo.IsSuccess)
                {
                    documentManagement.AddDetailDocument(AddBasicInfo,AddType);
                }
                else
                {
                    Console.WriteLine(AddBasicInfo.ErrorMessage);    
                }
            }
        }

        public int GetChooseOfMenuTable()
        {
            Console.WriteLine(" Welcome to the Program of Documents Management ");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| Enter 1: To add new Documents            ||");
            Console.WriteLine("|| Enter 2: To delete Documents by Id       ||");
            Console.WriteLine("|| Enter 3: To show infomation of Document  ||");
            Console.WriteLine("|| Enter 4: To search for Documents by Type ||"); 
            Console.WriteLine("|| Enter 5: To Exit                         ||");
            Console.WriteLine("==============================================");
            return Int32.Parse(Console.ReadLine());
        }

        public string GetTypeDocument()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("||Enter B: To insert new Book       ||");
            Console.WriteLine("||Enter M: To insert new Megazine   ||");
            Console.WriteLine("||Enter N: To insert new Newspaper  ||");
            Console.WriteLine("======================================");
            return Console.ReadLine();
        }

        public void RunningUI()
        {
            while (true)
            {
                switch (GetChooseOfMenuTable())
                {
                    case 1:
                    {
                        CountToAdd();
                        documentManagement.GetDocuments();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter Id for Delete: ");
                        string? IdDocs = Console.ReadLine();
                        documentManagement.RemoveDocumentById(IdDocs);
                        break;
                    }
                    case 3:
                    {
                        documentManagement.GetDocuments();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Enter type to search: ");
                        string? Type = Console.ReadLine();
                        documentManagement.SearchDocumentsByTypes(Type);
                        break;
                    }
                    case 5:
                    {
                        return;
                    }
                    default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                }
            }
        }
    }
}