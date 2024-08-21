using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookServices
    {
        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBook()
        {
            return _repo.GetBooks();
        }
        public void AddBookFromUI(Book book)
        {
            _repo.AddBook(book);
        }
        public void UpdateBookFromUI(Book book)
        {
            _repo.UpdateBook(book);
        }

        public void DeleteBookFromUI(Book book)
        {
            _repo.DeleteBook(book);
        }

    }
}
