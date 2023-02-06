class Book : Documents
{
    public string? ActorName { get; set; }
    public int Pages { get; set; }
    public List<Documents>? ListDocuments;
    public Book(string id, string? publisher, int versions, string? actorName, int pages) : base(id, publisher, versions)
    {
        ActorName = actorName;
        Pages = pages;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" ,ActorName: " + ActorName + ", Pages: " + Pages);
    }
}