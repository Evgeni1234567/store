using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Isbn { get; }
        public string Author { get; }
        public string Title { get; }

        public Book(int id, string isbn, string author, string title)
        {
            Id = id;
            Isbn = isbn;
            Author = author;
            Title = title;
        }

        internal static bool IsIsbn(string s) // проверка на валидность данных ввода ISBN
        {
            if (s == null)
                return false;

             s = s.Replace("-", "") // дефис заменяем на пустую строку. ищет подстроку такую и меняет. делает дляы всех вхождений
                  .Replace(" ", "")
                  .ToUpper();

            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$"); // \\ d экранирование ситаксиса. Regex вернет тру если будет совпадать строка с патерном.
        
        }

         


    }
}
