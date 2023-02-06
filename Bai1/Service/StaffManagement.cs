namespace Bai1.Service
{
    class StaffManagement : IStaffManagement
    {
        public List<Officer> Officers { get; set; }
        public StaffManagement()
        {            
            Officers = new List<Officer>(){
                new Employee("HUYNH NGOC THINH", 22, "Male", "TruongChinh", "IT"),
                new Engineer("HOANG LE HUY", 21, "Male", "NguHanhSon","ReactJs")
            };
        }
        public void AddStaff(Officer officer)
        {
            //Add the staff
            Officers.Add(officer);
        }

        public void SearchStaffByName()
        {
            Console.WriteLine("Enter name to search: ");
            string? NameSearch = Console.ReadLine();
            var Result = Officers.Where(c => c.Name.Contains(NameSearch)).ToList();
            if(Result.Count == 0) Console.WriteLine("No Staff found");
            else{
                foreach (var item in Result)
                {
                    item.OutPut();
                }
            }
        }

        public void GetAllStaff()
        {
            foreach (var item in Officers)
            {
                item.OutPut();
            }
        }
        public Officer AddInfoOffice()
        {
            try
            {                
                Console.Write("Enter name: ");
                string? Name = Console.ReadLine();
                Console.Write("Enter age: ");
                int Age = Int32.Parse(Console.ReadLine());
                Console.Write("Enter gender: ");
                string? Gender = Console.ReadLine();                   
                Console.Write("Enter address: ");
                string? Address = Console.ReadLine();
                return new Officer(Name, Age, Gender, Address){
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new Officer(){
                    IsSuccess = false,
                    ErrorMessage = e.Message
                };
            }
        }

        public void AddDetailStaff(Officer officer ,string role)
        {
            switch (role)
            {
                case "E":
                {
                    Console.WriteLine("Enter training: ");
                    string? Training = Console.ReadLine();
                    Officer Engineer = new Engineer(officer.Name,officer.Age,officer.Gender,officer.Address,Training);
                    AddStaff(Engineer);
                    break;
                }
                case "W":
                {
                    Console.WriteLine("Enter level: ");
                    int Level = Int32.Parse(Console.ReadLine());
                    Officer Worker = new Worker(officer.Name,officer.Age,officer.Gender,officer.Address,Level);
                    AddStaff(Worker);
                    break;
                }
                case "P":
                {
                    Console.Write("Enter Role: ");
                    string? Role = Console.ReadLine();
                    Officer Employee = new Employee(officer.Name,officer.Age,officer.Gender,officer.Address,Role);
                    AddStaff(Employee);
                    break;
                }
                default:
                {
                    Console.WriteLine("Input is not a valid");
                    break;
                }
            }
        }
    }
}