class Magazine : Documents
{
    public int Chapter { get; set; }
    public int Month { get; set; }
    public Magazine(){}
    public Magazine(string id, string? publisher, int versions, int chapter, int month) : base(id, publisher, versions)
    {
        Chapter = chapter;
        Month = month;
    }
    public override void OutPut(){
        base.OutPut();
        Console.WriteLine(" ,Chapter: " + Chapter + ", Month: " + Month);
    }
    public override Documents ReturnObject(string id, string publisher, int versions)
    {
        Console.Write("Enter Chapter: ");
        int chapter = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Release Month: ");
        int month = Int32.Parse(Console.ReadLine());
        return new Magazine(id, publisher, versions, chapter, month);
    }
}