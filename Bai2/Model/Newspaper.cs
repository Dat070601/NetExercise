class Newspaper : Documents
{
    public string? DateTime { get; set; }
    public Newspaper(string id, string? publisher, int versions, string? dateTime) : base(id, publisher, versions)
    {
        DateTime = dateTime;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" ,DateTime: " + DateTime);
    }
}