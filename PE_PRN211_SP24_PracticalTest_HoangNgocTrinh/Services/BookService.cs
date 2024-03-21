using Repositories;
using Repositories.Entities;

namespace Services
{

  //3-layer Architecture:
  // [1]            [2]                [3]                          SQLSERVER        
  //UI-Forms  ---- Services  ------- Repositories -----------------    DB
  //MainUI    ---- BookService       BookRepository (Book Entity)    Book Table
  //  request/response         <----->      
  //  đưa data xuống DB                chơi trực tiếp DB: lên, xuống
  //  lấy data từ DB show                                 CRUD table thực sự
  //            RAM                                 DB ĐĨA CỨNG HDD/SSD 
    public class BookService
    {
        //Class này trung chuyển dữ liệu giữa Forms UI và CSDL
        //Nó chứa data trong RAM, xử lí mọi thứ thuật toán nếu cần rồi đẩy lên UI
        //hoặc cất xuống DB
        //chứa list các Book đọc từ DB và show lên UI
        //chứa info cuốn sách lấy từ màn hình UI dự định cập nhật xuống DB

        //THƯỜNG SẼ CHỨA CÁC HÀM CRUD NHƯNG CHỈ TRONG RAM - LINQ CÓ THỂ NHẢY VÀO

        //giả bộ đã đọc data từ DB lên rồi, giờ show ra màn hình UI
        //tạm thời hard-coded danh sách các cuốn sách trong RAM
        //bữa tới học cách lấy từ DB thực sự
        //lấy xong thì cx phải có n cuốn sách trả về trong RAM


        //Vì ta còn cần dùng repo nhiều lần trong class Service nhiều lần cho việc CRUD data
        //cho nên ta khai báo repo như là backed field.
        BookRepository _repo = new BookRepository();
        
        //sự khác biệt giữa service                 VS REPO
        //tên hàm đặt gần với end-user              do nó chơi với table vật lý
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        public void UpdateABook(Book book)
        {
             _repo.UpdateBook(book); // Bên repo sẽ lo làm việc với dtb
            //service chỉ gọi thôi. Nhận book từ UI và pass sang repo
        }
    }
}
