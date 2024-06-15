using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;
 
    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    public ActionResult Detail()
    {
        if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
        {
            _logger.LogDebug("Hello");
            return new RedirectResult("/");
        }

        var content = new ContentResult()
        {
            Content = DateTime.Today.DayOfWeek.ToString()
        };
        
        return content;
    }
}