using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB.Models;
using WebApplication1.HelperServices;
using WebApplication1.Services.Implimentations;
using WebApplication1.Services.Models;

namespace WebApplication1;

[ApiController]
[Route("api/admincontroller")]
public class AdminController : ControllerBase
{
    #region Services
    
    private readonly ILogger<ProductService> _logger;
    private readonly IProductService _service;
    private readonly IGhostUser _ghost;

    #endregion
    
    
    #region Constructors

    public AdminController(ILogger<ProductService> logger, IProductService service, IGhostUser ghost)
    {
        _logger = logger;
        _service = service;
        _ghost = ghost;
    }

    #endregion


    #region Methods

    [HttpGet("create")]
    public IActionResult Create([FromQuery] decimal price, string category)
    {
        Product pr = new Product();
        pr = _service.Create(price, category);
        
        return Ok("Item created:\n" +
                  $"{pr}");
    } 
    
    
    [HttpGet("autogenerator")]
    public async Task<IActionResult> Auto()
    {
        await _ghost.Create();

        return Ok("+300 items");
    } 

    #endregion
}