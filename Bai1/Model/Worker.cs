class Worker : Officer
{
    private int Level { get; set; }
    public Worker(string? name, int age, string? gender, string? address, int level) : base(name, age, gender, address)
    {
        Level = level;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" Level: " + Level);
    }
}