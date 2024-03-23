using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    
    public class BookCategoryRepository
    {
        private HoangNgocTrinhContext _context;
        public List<BookCategory> GetBookCategories()
        {
            _context = new();
            return  _context.BookCategories.ToList(); // ta luôn nên convert mọi thứ về List cho dễ xử lí
        }


    }
}
