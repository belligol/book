using Book1.Model;


namespace Book1.DL
public class Class1
{
	public class AuthorRepository : IAuthorRepository

		public List<Author> GetAll()
	{
		return InMemoryDB.AuthorsData;
	}

	public AuthorRepository GetById(int id)
	{
		return InMemoryDB.AuthorData
			.First(a => a.Id == id);
	}
}
