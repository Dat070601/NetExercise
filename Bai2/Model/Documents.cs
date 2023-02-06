public class Documents{
    
    public string? Id { get; set; } 
    public string? Publisher { get; set; }
    public int Versions { get; set; }
    public Documents(string id, string? publisher, int versions)
    {
        Id = id;
        Publisher = publisher;
        Versions = versions;
    }
    public virtual void OutPut()
    {
        Console.Write("Id: " +Id+" ,Publisher: "+ Publisher + " ,Versions: " + Versions);
    }
}