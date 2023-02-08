namespace Bai3.Model
{
    class GroupC : Students
    {
        public const string? LITERATURE = "Literature";
        public const string? HISTORY = "History";
        public const string? GEOGRAPHIC = "Geographic";
        public GroupC(int id, string? name, string? address, int priorityLevel) : base(id, name, address, priorityLevel)
        {
            
        }
        public override void OutPut(){
            base.OutPut();
            Console.WriteLine(", Group C and Subject: " + LITERATURE + ", " + HISTORY + ", " + GEOGRAPHIC);
        }  
    }
}