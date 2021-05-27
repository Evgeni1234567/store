using System;
using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book (1, "Art of Programming"),
            new Book (2, "Refact"),
            new Book (3, "C prog")
        
        };

        public Book[] GetByTitle(string titlePatr)
        {
            return books.Where(book => book.Title.Contains(titlePatr))
                        .ToArray();
        }
    }
}
