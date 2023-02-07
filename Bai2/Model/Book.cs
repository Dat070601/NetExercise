class Book : Documents
{
    public string? ActorName { get; set; }
    public int Pages { get; set; }
    public List<Documents>? ListDocuments;
    public Book()
    {}
    public Book(string id, string? publisher, int versions, string? actorName, int pages) : base(id, publisher, versions)
    {
        ActorName = actorName;
        Pages = pages;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" ,ActorName: " + ActorName + ", Pages: " + Pages);
    }
    public override Documents ReturnObject(string id, string? publisher, int versions) {
        Console.Write("Enter Actor Name: ");
        string? ActorName = Console.ReadLine();
        Console.Write("Enter Number of Pages: ");
        int Pages = Int32.Parse(Console.ReadLine());
        return new Book(id, publisher, versions, ActorName, Pages);
    }
}