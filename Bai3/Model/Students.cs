using Bai3.Model.Response;

namespace Bai3.Model
{    
    public class Students : GeneralResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int  PriorityLevel{ get; set; }
        public Students()
        {
            
        }

        public Students(int id, string? name, string? address, int priorityLevel)
        {
            Id = id; 
            Name = name; 
            Address = address; 
            PriorityLevel = priorityLevel;
        }
        public virtual void OutPut()
        {
            Console.Write("Id: " +Id+" ,Name "+ Name + " ,Address: " + Address +", PriorityLevel: " + PriorityLevel);
        }
    }
}