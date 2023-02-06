using Bai1.Model.Response;

public class Officer : GeneralResponse
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public string? Address { get; set; }
    public Officer()
    {
        
    }
    public Officer(string? name, int age, string? gender, string? address){
        Name = name;
        Age = age;
        Gender = gender;
        Address = address;
    }
    public virtual void OutPut(){
        Console.Write("Name: " + Name + " Age: " + Age+ " Gender: " + Gender + " Address: " + Address);
    }
}