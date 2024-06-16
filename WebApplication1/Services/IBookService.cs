using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IBookService
{

    List<ComicBook> FindAllComicBooks();
    
    ComicBook? GetComicBookById(long? id);

}