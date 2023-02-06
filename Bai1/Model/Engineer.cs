class Engineer : Officer
{
    private string? Training { get; set; }
    public Engineer(string? name, int age, string? gender, string? address, string? training) : base(name, age, gender, address)
    {
        Training = training;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" Training: " + Training);
    }
}