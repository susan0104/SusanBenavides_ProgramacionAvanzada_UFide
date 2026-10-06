using PAP.DataAccess;
using PAP.Repositories;
using System.Collections.Generic;

namespace PAP.Business
{
    public class BookManager
    {
        private readonly BookRepository _repository;

        public BookManager()
        {
            _repository = new BookRepository();
        }

        public IEnumerable<Book> GetAllBooksFromDataModel()
        {
            BookRepository.InsertBooks();
            return _repository.GetAll();
        }   
    }
}
