namespace Bai9.Model
{
    public class Family
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int ElectricityCode { get; set; }
        public Family(){}
        public Family(string? name, string? address, int electricityCode)
        {
            Name = name;
            Address = address;
            ElectricityCode = electricityCode;
        }
        public virtual void OutPut(){
            Console.Write(" Name: " + Name + " Address: " + Address + " ElectricityCode: " + ElectricityCode);
        }
    }
}