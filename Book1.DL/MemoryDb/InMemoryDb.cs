using Book1.Model;


namespace Book1.DL

public static class InMemoryDb

{
        public static List<Author> AuthorsData
            = new List<Author>() {
           
        new Author()
        { 
        Id = 1,
        Name = "Name 1",
        Description = "abc"
        }
    new Author()
    {
        Id = 2,
        Name = "Name 2",
        Description = "abc"
        }

    new Author()
    {
        Id = 3,
        Name = "Name 3",
        Description = "abc"
        }

}
