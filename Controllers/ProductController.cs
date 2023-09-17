
using ElectroShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    IProductService productService;
    public ProductController(IProductService service)
    {
        productService = service;
    }

    [HttpGet]
    public IActionResult Get(){
        return Ok (productService.Get());
    }

    [HttpGet("{id}")]
    [Authorize(Roles = ("Admin"))]
    public IActionResult Get(Guid id){
        return Ok (productService.Get(id));
    }
}