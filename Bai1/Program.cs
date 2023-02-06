using Bai1.Service;

public class Program
{
    public static void Main(string[] args){
        IStaffManagement StaffManagements= new StaffManagement();
        IUIService UiService = new UIService(StaffManagements);
        UiService.RunningUI();
    }
}