using Bai3.Service;

namespace Bai3
{
    class Program
    {
        public static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();
            IUIService UiService = new UIService(studentService);
            UiService.RunningUI();
        }
    }
}