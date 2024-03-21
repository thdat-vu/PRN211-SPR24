using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Class này chứa các hàm CRUD trực tiếp các table. Nó cung cấp các hàm cơ bản :
    /// GetBooks()
    /// UpdateBook()
    /// Get()
    /// nó là đứa xài trực tiếp DbContext
    /// </summary>
    public class BookRepository
    {
        private HoangNgocTrinhContext _context;
        /// <summary>
        /// Hàm trả về các cuốn sách trong dtb
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            _context = new HoangNgocTrinhContext();
            return _context.Books.ToList(); // ta luôn nên convert mọi thứ về List cho dễ xử lí
        }

        public void UpdateBook(Book b)
        {
            _context = new();
            _context.Books.Update(b); //SQL: update Book set BookId=, BookName = ..., where BookId = ...
            _context.SaveChanges(); //keep track on change.
        }
    }
}
