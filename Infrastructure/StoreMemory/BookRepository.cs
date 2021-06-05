﻿using System;
using Store;
using System.Linq;

namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book (1,"ISBN 12122-31312", "Knut", "Art of Programming"),
            new Book (2,"ISBN 12332-31312", "Fowler", "Refact"),
            new Book (3,"ISBN 12332-31312", "Ritchie","C Prog")
        
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(books => books.Isbn.Contains(isbn)).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(books => books.Title.Contains(titleOrAuthor)).ToArray();
        }

        public Book[] GetByTitle(string titlePatr)
        {
            return books.Where(book => book.Title.Contains(titlePatr))
                        .ToArray();
        }
    }
}
