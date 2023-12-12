using Book1.Model;


namespace Book1.DL
public interface IAuthorRepository
{
    List<Author> GetAll();

    Author GetById(int id);

    void Add(Author author);

    void Remove(int id);
}
