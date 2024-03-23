using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        BookCategoryRepository _repo;
        public List<BookCategory> GetAllCategories()
        {

            //TODO: Gọi class BookCategoryRepository để lấy toàn bộ danh mục phân loại sách từ DB
            //Call class BookCategoryRepository to retrieve all book categories from DB
            _repo = new BookCategoryRepository();
            return _repo.GetBookCategories();
        }
    }
}
