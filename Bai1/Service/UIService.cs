namespace Bai1.Service
{
    class UIService : IUIService
    {
        private readonly IStaffManagement staffManagement;
        public UIService(IStaffManagement StaffManagement)
        {
            staffManagement = StaffManagement;
        }

        public void AddStaff()
        {
            Console.WriteLine("Enter the number of Staffs you want to add: ");
            int quantity = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < quantity; i++)
            {
                GetRoleAndAddStaff();
            }
        }

        public int GetMenuTable()
        {
            Console.WriteLine(" Welcome to the Program of Staff Management ");
            Console.WriteLine("============================================");
            Console.WriteLine("|| Enter 1: To add new staff              ||");
            Console.WriteLine("|| Enter 2: To search staff by name       ||");
            Console.WriteLine("|| Enter 3: To show infomation of staffs  ||");
            Console.WriteLine("|| Enter 4: To Exit                       ||");
            Console.WriteLine("============================================");
            return Int32.Parse(Console.ReadLine());
        }
        
        public void GetRoleAndAddStaff()
        {
            var AddOffice = staffManagement.AddInfoOffice();
            if(AddOffice.IsSuccess)
            {
                staffManagement.AddDetailStaff(AddOffice,GetRoleTable());
            }
            else 
                Console.WriteLine(AddOffice.ErrorMessage);
        }

        public string GetRoleTable()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("||Enter E: To insert new Engineer ||");
            Console.WriteLine("||Enter W: To insert new Worker   ||");
            Console.WriteLine("||Enter P: To insert new Personnel||");
            Console.WriteLine("====================================");
            return Console.ReadLine();
        }

        public void RunningUI()
        {
            while (true)
            {
                switch(GetMenuTable()){
                    case 1:
                    {
                        AddStaff();
                        staffManagement.GetAllStaff();
                        break;
                    }
                    case 2:
                    {
                        staffManagement.SearchStaffByName();
                        break;    
                    }
                    case 3:
                    {
                        staffManagement.GetAllStaff();
                        break;
                    }
                    case 4:
                        return;
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