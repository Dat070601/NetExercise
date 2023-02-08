using Bai3.Model;

namespace Bai3.Service
{
    class StudentService : IStudentService
    {
        public List<Students> Students { get; set; }
        public StudentService()
        {
            Students = new List<Students>(){
                new GroupA(1,"DINH HOANG DAT","THANH KHE",10),
                new GroupB(2,"HOANG LE HUY","NGU HANH SON",9),
                new GroupA(3,"HUYNH NGOC THINH","TRUONG CHINH",11),
            };
        }
        public void AddStudent(Students Student)
        {
            var findStudent = Students.Where(st => st.Id == Student.Id).FirstOrDefault();
            if(findStudent != null)
            {
                Console.WriteLine("Student is already exist!");
            }
            else
            {
                Students.Add(Student);
            }
        }
        public void GetAllStudent()
        {
            foreach (var item in Students)
            {
                item.OutPut();
            }
        }

        public void SearchStudentById(int id)
        {
            var findStudent = Students.Where(st => st.Id == id).FirstOrDefault();
            if (findStudent == null)
            {
                Console.WriteLine("Student Could Not Be Found!");
            }
            else
            {
                findStudent.OutPut();
            }
        }

        public void AddDetailStudent(Students Student, string Type)
        {
            switch (Type)
            {
                case "A":
                {
                    Students AddStudentGroupA = new GroupA(Student.Id, Student.Name, Student.Address, Student.PriorityLevel);
                    AddStudent(AddStudentGroupA);
                    break;
                }
                case "B":
                {
                    Students AddStudentGroupB = new GroupB(Student.Id, Student.Name, Student.Address, Student.PriorityLevel);
                    AddStudent(AddStudentGroupB);
                    break;
                }
                case "C":
                {
                    Students AddStudentGroupC = new GroupC(Student.Id, Student.Name, Student.Address, Student.PriorityLevel);
                    AddStudent(AddStudentGroupC);
                    break;
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