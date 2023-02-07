using Bai2.Model.Response;

public class Documents : GeneralResponse
{
    
    public string? Id { get; set; } 
    public string? Publisher { get; set; }
    public int Versions { get; set; }
    public Documents()
    {
        
    }
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
    public virtual Documents ReturnObject(string id, string? publisher, int versions){
        return new Documents(id,publisher,versions);
    }
}