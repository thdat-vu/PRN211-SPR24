using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {

        //CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOX
        //LẼ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DB - NHƯNG TẠM THỜI HARD-CODED TRƯỚC, ĐỂ MAI TÍNH...
        public List<BookCategory> GetAllCategories()
        {

            BookCategoryRepository _repo = new BookCategoryRepository();
            return _repo.GetBookCategories();
        }
    }
}
