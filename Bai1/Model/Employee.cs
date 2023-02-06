class Employee : Officer
{
    private string? Role { get; set; }
    public Employee(string? name, int age, string? gender, string? address, string? role) : base(name, age, gender, address)
    {
        Role = role;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" Role: " + Role);
    }
}