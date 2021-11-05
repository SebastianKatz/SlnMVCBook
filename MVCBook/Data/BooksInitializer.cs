using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCBook.Models;


namespace MVCBook.Data
{
    public class BooksInitializer : DropCreateDatabaseAlways<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            var operas = new List<Book>
            {
               new Book {
                  Name = "Un libro",
                  Author = "El autor",
                  PagesNumber = 406,
                  Publisher = "La editorial",
                  PublicationDate = "15/05/1998",
                  Content = ".....",
                  Price = 84,
                  PriceConfirm = 84

               }
            };
            operas.ForEach(s => context.Books.Add(s));

            context.SaveChanges();


        }

    }
}