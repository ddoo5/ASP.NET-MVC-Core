using Newtonsoft.Json;

namespace ConsoleApp1;

public class JsonParser    //in methods only different links!(this class implemented for "различные Json структуры (предположительно из разных веб сервисов), олицетворяюющие товар в магазинах")
{
    private readonly HttpClient _httpClient;

    
    public JsonParser(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    
    public async Task<Structure1> GetStructure1(Structure1 data)
    {
        var httpRequest = new HttpRequestMessage(HttpMethod.Get, ("https://jsonplaceholder.typicode.com/todos/4"));   //here
        
        try
        {
            HttpResponseMessage httpResponseMessage = _httpClient.SendAsync(httpRequest).Result;
            string response = await httpResponseMessage.Content.ReadAsStringAsync();
            data =  (Structure1)JsonConvert.DeserializeObject(response, typeof(Structure1));
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\n" +
                              $"{ex.HelpLink}");
        }
        
        return null;
    }
    
    
    public async Task<Structure2> GetStructure2(Structure2 data)
    {
        var httpRequest = new HttpRequestMessage(HttpMethod.Get, ("https://jsonplaceholder.typicode.com/posts/13"));   //and here
        
        try
        {
            HttpResponseMessage httpResponseMessage = _httpClient.SendAsync(httpRequest).Result;
            string response = await httpResponseMessage.Content.ReadAsStringAsync();
            data =  (Structure2)JsonConvert.DeserializeObject(response, typeof(Structure2));
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}\n" +
                              $"{ex.HelpLink}");
        }
        
        return null;
    }
}