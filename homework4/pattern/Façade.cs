namespace ConsoleApp1;

public class Façade   //i think it's the best and easiest pattern
{
    public async static void GetAllData()
    {
        //take first data
        Structure1 a = await new JsonParser(new HttpClient()).GetStructure1(new Structure1());
        
        Console.WriteLine($"user Id: {a.userId}");
        Console.WriteLine($"Id: {a.Id}");
        Console.WriteLine($"Title: {a.Title}");
        Console.WriteLine($"Completed: {a.Completed}\n\n");
        
        //take second data
        Structure2 b = await new JsonParser(new HttpClient()).GetStructure2(new Structure2());
        
        Console.WriteLine($"user Id: {b.userId}");
        Console.WriteLine($"Id: {b.Id}");
        Console.WriteLine($"Title: {b.Title}");
        Console.WriteLine($"Body: {b.Body}\n");
    }


    public async static void GetDataFromFirstShop()  //just for example
    {
        Structure2 b = await new JsonParser(new HttpClient()).GetStructure2(new Structure2());
        
        Console.WriteLine($"user Id: {b.userId}");
        Console.WriteLine($"Id: {b.Id}");
        Console.WriteLine($"Title: {b.Title}");
        Console.WriteLine($"Body: {b.Body}\n");
    }
    
    
    public async static void GetDataFromSecondShop() //just for example
    {
        Structure2 b = await new JsonParser(new HttpClient()).GetStructure2(new Structure2());
        
        Console.WriteLine($"user Id: {b.userId}");
        Console.WriteLine($"Id: {b.Id}");
        Console.WriteLine($"Title: {b.Title}");
        Console.WriteLine($"Body: {b.Body}\n"); 
    }
}