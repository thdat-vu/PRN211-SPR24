using Repository.Entities;

namespace Services
{
	public class BookService
	{
        //class này chính là Cabinet hồi xưa mình học

        //ta sẽ gọi 1 class tên là: BookRepository ở bên Repository
        //để CRUD data trong DB. Phần này làm sau
        //Class này sẽ tương tác với GUI để đẩy data ra show trên form GUI
        //class này cũng hứng data từ màn hình GUI để đẩy xuống DB qua lời gọi tới class BookRepository sẽ làm sau
        //----------------------------------------
        //FORM GUI ------------------------- BookService ------------------------ Repository ---- DB


        //public List<Book> GetAllBooks() 
        //{
        //	//phần này lấy từ DB, ta làm thử
        //	List<Book> books = new List<Book>();
        //	books.Add(new Book() {BookId = 1, BookName = "Tôi thấy hoa vàng..", Author = "Nguyễn Nhật ÁNh" });
        //	books.Add(new Book() {BookId = 2, BookName = "Trại thấy hoa vàng..", Author = "Nguyễn Nhật ÁNh" });
        //	books.Add(new Book() {BookId = 3, BookName = "Có con mèo ngồi trên cửa sổ", Author = "Nguyễn Nhật ÁNh" });
        //	return books;
        //}

        public List<Book> GetAllBooks()
        {
            //TODO: Gọi class BookRepository để lấy toàn bộ sách từ DB
            //Call class BookRepository to retrieve all books from DB
            List<Book> arr = new List<Book>();

            //using object initialization
            arr.Add(new Book()
            {
                BookId = 1,
                BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long",
                Author = "Robin Sharma",
                Description= "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long",
                //PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 2,
                BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright",
                Author = "Kazuko Watanabe",
                Description="Hãy phát huy các tố chất vốn có của bạn, ở trong bạn..",
                //PublicationDate = "2023-01-01",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 3,
                BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth",
                Author = "Rosie Nguyễn",
                Description="",
                //PublicationDate = "2018-1-1",
                BookCategoryId = 5
            });

            arr.Add(new Book()
            {
                BookId = 4,
                BookName = "Snow Crash",
                Description = "Hiro lives in a Los Angeles where franchises line the freeway...",
                Author = "Neal Stephenson",
               
                //PublicationDate = "2001-1-1",
                BookCategoryId = 2
            });

            return arr;
        }
    }
}
