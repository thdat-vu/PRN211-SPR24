using Repository;
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
        BookRepository _repo;
        public List<Book> GetAllBooks()
        {
            //TODO: Gọi class BookRepository để lấy toàn bộ sách từ DB
            //Call class BookRepository to retrieve all books from DB
            
            _repo = new ();
            return _repo.GetBooks();
        }

        public void CreateBook(Book book)
        {
            _repo = new();
            _repo.CreateABook(book);
        }
        public void DeleteBook(Book book)
        {
            _repo = new();
            _repo.DeleteABook(book);
        }
        public void UpdateBook(Book book)
        {
            _repo = new();
            _repo.UpdateABook(book);
        }
    }
}
