using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class BookCategoryRepository
    {
        HoangNgocTrinhContext _repo = new HoangNgocTrinhContext();
        public List<BookCategory> GetBookCategories()
        {
            return _repo.BookCategories.ToList();
        }
    }
}
