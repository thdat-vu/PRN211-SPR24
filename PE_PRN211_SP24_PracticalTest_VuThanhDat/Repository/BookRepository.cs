using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository
    {
        HoangNgocTrinhContext _dbContext = new HoangNgocTrinhContext();

        public List<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void UpdateABook(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }
        public void DeleteABook(Book book)
        {
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
        public void CreateABook(Book book)
        {
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }
    }
}
