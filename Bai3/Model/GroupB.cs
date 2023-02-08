namespace Bai3.Model
{
    class GroupB : Students
    {

        public const string? MATH = "Math";
        public const string?  CHEMISTRY = "Chemistry";
        public const string? BIOLOGY = "Biology";
        public GroupB(int id, string? name, string? address, int priorityLevel) : base(id, name, address, priorityLevel)
        {
            
        }
        public override void OutPut(){
            base.OutPut();
            Console.WriteLine(", Group B and Subject: " + MATH + ", " + CHEMISTRY + ", " + BIOLOGY);
        } 
    }
}