using PAP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PAP.Repositories
{
    public class BookRepository : RepositoryBase<Book>
    {
        public static void InsertBooks()
        {
            BookRepository repository = new BookRepository();

            var books = new List<Book>
            {
                new Book
                {
                    Name = "The Silent Horizon",
                    Title = "The Silent Horizon",
                    Category = "Fiction",
                    Publisher = "HarperCollins",
                    Author = "Eleanor Brooks",
                    Description = "A mysterious journey across a forgotten landscape reveals secrets buried for generations.",
                    PublicationDate = new DateTime(2021, 3, 15),
                    Height = 8.5m,
                    Width = 5.5m,
                    Price = 18.99m,
                    IsBestSeller = true,
                    Genre = "Mystery",
                    IsInStock = true,
                    CreatedAt = new DateTime(2021, 3, 20),
                    UpdatedAt = new DateTime(2026, 9, 1)
                },
                new Book
                {
                    Name = "Beyond the Stars",
                    Title = "Beyond the Stars",
                    Category = "Science Fiction",
                    Publisher = "Penguin Random House",
                    Author = "Marcus Reed",
                    Description = "Humanity's first expedition beyond the solar system encounters something unexpected.",
                    PublicationDate = new DateTime(2020, 7, 10),
                    Height = 9.0m,
                    Width = 6.0m,
                    Price = 22.5m,
                    IsBestSeller = true,
                    Genre = "Science Fiction",
                    IsInStock = true,
                    CreatedAt = new DateTime(2020, 7, 15),
                    UpdatedAt = new DateTime(2026, 8, 25)
                },
                new Book
                {
                    Name = "The Art of C#",
                    Title = "The Art of C#",
                    Category = "Technology",
                    Publisher = "O'Reilly Media",
                    Author = "Daniel Foster",
                    Description = "A practical guide to writing clean, maintainable and modern C# applications.",
                    PublicationDate = new DateTime(2023, 1, 12),
                    Height = 9.2m,
                    Width = 7.0m,
                    Price = 45.99m,
                    IsBestSeller = true,
                    Genre = "Programming",
                    IsInStock = true,
                    CreatedAt = new DateTime(2023, 1, 20),
                    UpdatedAt = new DateTime(2026, 9, 5)
                },
                new Book
                {
                    Name = "Echoes of Winter",
                    Title = "Echoes of Winter",
                    Category = "Fiction",
                    Publisher = "Simon & Schuster",
                    Author = "Clara Mitchell",
                    Description = "A family returns to their ancestral home and discovers an unfinished story.",
                    PublicationDate = new DateTime(2019, 11, 4),
                    Height = 8.4m,
                    Width = 5.4m,
                    Price = 16.75m,
                    IsBestSeller = false,
                    Genre = "Drama",
                    IsInStock = true,
                    CreatedAt = new DateTime(2019, 11, 10),
                    UpdatedAt = new DateTime(2026, 7, 12)
                },
                new Book
                {
                    Name = "The Last Algorithm",
                    Title = "The Last Algorithm",
                    Category = "Technology",
                    Publisher = "MIT Press",
                    Author = "Nathan Cole",
                    Description = "A software engineer discovers an algorithm capable of predicting human decisions.",
                    PublicationDate = new DateTime(2022, 5, 18),
                    Height = 9.1m,
                    Width = 6.7m,
                    Price = 34.99m,
                    IsBestSeller = true,
                    Genre = "Tech Thriller",
                    IsInStock = true,
                    CreatedAt = new DateTime(2022, 5, 25),
                    UpdatedAt = new DateTime(2026, 8, 30)
                }
            };

            int nextId = repository._context.Books.Any()
                ? repository._context.Books.Max(existing => existing.Id)
                : 0;

            bool hasNewBooks = false;

            foreach (Book book in books)
            {
                bool alreadyExists = repository._context.Books.Any(existing =>
                    existing.Title == book.Title &&
                    existing.Author == book.Author);

                if (!alreadyExists)
                {
                    book.Id = ++nextId;
                    repository._context.Books.Add(book);
                    hasNewBooks = true;
                }
            }

            if (hasNewBooks)
            {
                repository.Save();
            }
        }
    }
}
