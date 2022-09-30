using WebApplication1.DB.Models;
using WebApplication1.Services.Models;

namespace WebApplication1.HelperServices;

public class GhostUser : IGhostUser
{
    private  readonly IProductService _service;


    public GhostUser()
    {
    }
    
    public GhostUser(IProductService service)
    {
        _service = service;
    }
    
    
    public async Task<Product> Create()   //without logic, full random
    {
        //data
        Random rnd = new();
        int count = rnd.Next(1, 10);
        decimal price = rnd.Next(450, 6200000);
        string category = ((NameList)rnd.Next(1, 10)).ToString();

        //method
        for (int i = 0; i < 300; i++)
        {
            //add
            _service.Create(price, category);
            
            //create new data
            category = ((NameList)rnd.Next(1, 10)).ToString();
            price = rnd.Next(450, 6200000);
        }
        return new Product(){};
    } 
}