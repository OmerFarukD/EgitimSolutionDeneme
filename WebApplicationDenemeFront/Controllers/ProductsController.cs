using Microsoft.AspNetCore.Mvc;
using WebApplicationDenemeFront.Data;

namespace WebApplicationDenemeFront.Controllers;

public class ProductsController : Controller
{
    private readonly ProductData _productData;

    public ProductsController(ProductData productData)
    {
        _productData = productData;
    }


    public IActionResult Index()
    {
        var data = _productData.GetAll();
        
        return View(data);
    }

    public IActionResult GetById(int id)
    {
        var data = _productData.GetById(id);
        return View(data);
    }
    
    
}