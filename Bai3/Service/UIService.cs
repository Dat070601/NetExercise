using Bai3.Model;

namespace Bai3.Service
{
    class UIService : IUIService
    {
        private readonly IStudentService studentServices;
        public UIService(IStudentService StudentService)
        {
            studentServices = StudentService;
        }

        public Students AddBasicInfoStudent()
        {
            try
            {
                Console.Write("Enter Id of Student: ");
                int id = Int32.Parse(Console.ReadLine());                   
                Console.Write("Enter Name of Student: ");
                string? nameStudent = Console.ReadLine();
                Console.Write("Enter Address of Student: ");
                string? address = Console.ReadLine();
                Console.Write("Enter PriorityLevel of Student: ");
                int priorityLevel = Int32.Parse(Console.ReadLine());
                return new Students(id, nameStudent, address, priorityLevel){
                    IsSuccess = true,
                };
            }
            catch (Exception e)
            {
                return new Students()
                {
                    IsSuccess = false,
                    ErrorMessage = e.Message
                };
            }
        }

        public string AddGroupStudentUI()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("||Enter A: Insert student to group A  ||");
            Console.WriteLine("||Enter B: Insert student to group B  ||");
            Console.WriteLine("||Enter C: Insert student to group C  ||");
            Console.WriteLine("========================================");
            return Console.ReadLine();
        }

        public void CountToAddStudent()
        {
            Console.WriteLine("Enter the number of Students you want to add: ");
            int Quantity = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < Quantity; i++)
            {
                var AddBasicInfo = AddBasicInfoStudent();
                var AddGroupStudent = AddGroupStudentUI();
                if(AddBasicInfo.IsSuccess)
                {
                    studentServices.AddDetailStudent(AddBasicInfo,AddGroupStudent);   
                }
                else
                {
                    Console.WriteLine(AddBasicInfo.ErrorMessage);    
                }
            }      
        }

        public int GetChooseInMenu()
        {
            Console.WriteLine(" Welcome to the Program of Student Management ");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| Enter 1: To add new Student              ||");
            Console.WriteLine("|| Enter 2: To show infomation of Students  ||");
            Console.WriteLine("|| Enter 3: To search for Student by Id     ||"); 
            Console.WriteLine("|| Enter 4: To Exit                         ||");
            Console.WriteLine("==============================================");
            return Int32.Parse(Console.ReadLine());
        }

        public void RunningUI()
        {
            while (true)
            {
                switch (GetChooseInMenu())
                {
                    case 1:
                    {
                        CountToAddStudent();
                        studentServices.GetAllStudent();
                        break;
                    }
                    case 2:
                    {
                        studentServices.GetAllStudent();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Enter Id of Student to search: ");
                        int id = Int32.Parse(Console.ReadLine());
                        studentServices.SearchStudentById(id);
                        break;
                    }
                    case 4:
                        return;
                    default:
                    {
                        Console.WriteLine("Please choose the correct option!");
                        break;
                    }
                }
            }
       }
    }
}