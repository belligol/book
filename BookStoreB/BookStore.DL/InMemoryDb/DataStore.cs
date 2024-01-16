using BookStore.Models.Data;

namespace BookStore.DL.InMemoryDb
{
    public static class DataStore
    {
        public static List<Author> Authors = new List<Author>()
    {
        new Author()
                {
                    Id = Guid.NewGuid(),
                    Title = "gosho",
                    Bio = "gosho bio"
                },
        new Author()
                {
                    Id = Guid.NewGuid(),
                    Title = "ginka",
                    Bio = "ginka bio"
                }
    };

        public static List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id = Guid.NewGuid(),
                Title = "book of gosho",
                Description = "some description",
                AuthorId = Guid.NewGuid()
            },
            new Book()
            {
                Id = Guid.NewGuid(),
                Title = "book of gosho",
                Description = "some description",
                AuthorId = Guid.NewGuid()
            }
                ,
            new Book()
            {
                Id = Guid.NewGuid(),
                Title = "book of gosho",
                Description = "some description",
                AuthorId = Guid.NewGuid()
            }
        };
    }
    }
