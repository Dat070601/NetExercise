using Bai3.Model;

namespace Bai3.Service
{
    interface IStudentService
    {
        public void AddStudent(Students Student);
        public void GetAllStudent();
        public void SearchStudentById(int id);
        public void AddDetailStudent(Students Student, string Type);
    }
}