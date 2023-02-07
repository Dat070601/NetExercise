class Newspaper : Documents
{
    public string? DateTime { get; set; }
    public Newspaper()
    {
        
    }
    public Newspaper(string id, string? publisher, int versions, string? dateTime) : base(id, publisher, versions)
    {
        DateTime = dateTime;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" ,DateTime: " + DateTime);
    }
    public override Documents ReturnObject(string id, string publisher, int versions){
        Console.Write("Enter Release Date: ");
        string? releaseDate = Console.ReadLine();
        return new Newspaper(id, publisher, versions, releaseDate);
    }
}