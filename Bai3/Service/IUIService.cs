using Bai3.Model;

namespace Bai3.Service
{
    interface IUIService
    {
        public string AddGroupStudentUI();
        public int GetChooseInMenu();
        public Students AddBasicInfoStudent();
        public void RunningUI();
        public void CountToAddStudent();
    }
}