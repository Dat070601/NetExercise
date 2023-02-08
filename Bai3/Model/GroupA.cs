namespace Bai3.Model
{    
    class GroupA : Students
    {
        public const string? MATH = "Math";
        public const string? PHYSICS = "Physics";
        public const string?  CHEMISTRY = "Chemistry";
        public GroupA(int id, string? name, string? address, int priorityLevel) : base(id, name, address, priorityLevel)
        {
            
        }
        public override void OutPut(){
            base.OutPut();
            Console.WriteLine(", GroupA and Subject: " + MATH + ", " + PHYSICS + ", " + CHEMISTRY);
        }  
    }
}