using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IBookService
{

    List<ComicBook> GetAllComicBooks();
    
    ComicBook? GetComicBookById(long? id);

}