using WebApplication1.Models;

namespace WebApplication1.Data;

public class BookRepository : IBookRepository
{

    public List<ComicBook> FindAllComicBooks()
    {
        return _comicBooks.ToList();
    }

    public ComicBook? GetComicBookById(long? id)
    {
        var comics = FindAllComicBooks();
        var foundComicBook = comics.Find(c => c.Id == id);
        if (foundComicBook != null)
        {
            return foundComicBook;
        }
        return null;
    }
    
        private static readonly ComicBook[] _comicBooks =
        {
            new()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml =
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new() { Name = "Dan Slott", Role = "Script" },
                    new() { Name = "Humberto Ramos", Role = "Pencils" },
                    new() { Name = "Victor Olazaba", Role = "Inks" },
                    new() { Name = "Edgar Delgado", Role = "Colors" },
                    new() { Name = "Chris Eliopoulos", Role = "Letters" }
                },
                Favorite = false
            },
            new()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml =
                    "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new[]
                {
                    new Artist { Name = "Dan Slott", Role = "Script" },
                    new Artist { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist { Name = "Marcos Martin", Role = "Inks" },
                    new Artist { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml =
                    "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new() { Name = "Jeff Smith", Role = "Script" },
                    new() { Name = "Jeff Smith", Role = "Pencils" },
                    new() { Name = "Jeff Smith", Role = "Inks" },
                    new() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }
        };
}