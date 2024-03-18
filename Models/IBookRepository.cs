namespace Mission11_BookLibrary.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }

    }
}
