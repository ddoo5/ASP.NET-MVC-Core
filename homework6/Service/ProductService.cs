using WebApplication1.DB.Connections;
using WebApplication1.DB.Models;
using WebApplication1.Services.Models;

namespace WebApplication1.Services.Implimentations;

public class ProductService : IProductService
{
    #region Services
    
    private readonly ILogger<ProductService> _logger;
    private readonly DBConnection _connection;

    #endregion
    
    
    #region Constructors

    public ProductService(DBConnection connection, ILogger<ProductService> logger)
    {
        _connection = connection;
        _logger = logger;
    }

    #endregion


    #region Implimentation

    public Product Create(decimal price, string name)
    {
        var id = _connection.Products.Count() + 1;
        
        var product = new Product
        {
            Id =  id,
            Price = price,
            Category = "товар",
            Name = name
        };

        _connection.Products.Add(product);
        
        _connection.SaveChanges();

        return product;

    }
    
    #endregion
}