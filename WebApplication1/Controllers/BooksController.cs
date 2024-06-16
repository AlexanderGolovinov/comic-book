using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

public class BooksController : Controller
{
    private readonly IBookService _bookService;
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    public ActionResult Detail(long? id)
    {
        if (id != null)
        {
            var comicDetails = _bookService.GetComicBookById(id);
            _logger.LogDebug("Fetching book detail with id: " + comicDetails);
            return View(comicDetails);
        }
        else
        {
            var comicDetails = _bookService.GetComicBookById(1);
            
            _logger.LogDebug("No Id provided. Returning default book: " + comicDetails);
            return View(comicDetails);
        }
    }
}