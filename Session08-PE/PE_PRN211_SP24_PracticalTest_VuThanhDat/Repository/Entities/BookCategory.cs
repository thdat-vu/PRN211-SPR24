using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }
        public string BookGenreType { get; set; }
        public string Description { get; set; }

        //phần này mốt ko gõ nữa nếu có sẵn dtb. ta suy ngc lại thành class - sử dụng thư viện chuẩn của SDK là EF CORE - ENTITY FRAMEWORK
        //~HIBERNATE bên java
        //ORM 
        //TABLE THANHF CODE, CODE Thành table

        //-> Class thành Table -> Code first
        //Table -> Class -> Database First
    }
}
