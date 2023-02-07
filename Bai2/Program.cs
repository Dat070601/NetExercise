using Bai2.Service;

public class Program
{
    public static void Main(string[] args){
        IDocumentManagement DocumentManagement = new DocumentManagement();
        IUIService UiService = new UIService(DocumentManagement);
        UiService.RunningUI();
    }
}