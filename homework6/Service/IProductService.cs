using WebApplication1.DB.Models;

namespace WebApplication1.Services.Models;

public interface IProductService
{ 
    Product Create(decimal price, string name);
}