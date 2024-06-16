using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public List<ComicBook> GetAllComicBooks()
    {
        return _bookRepository.FindAllComicBooks();
    }

    public ComicBook? GetComicBookById(long? id)
    {
        return _bookRepository.GetComicBookById(id);
    }
}