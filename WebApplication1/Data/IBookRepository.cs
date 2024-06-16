using WebApplication1.Models;

namespace WebApplication1.Data;

public interface IBookRepository
{
    List<ComicBook> FindAllComicBooks();

    ComicBook? GetComicBookById(long? id);
}