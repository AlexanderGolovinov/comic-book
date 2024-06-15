using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    public string Detail()
    {
        return "Books detail page";
    }
    
}