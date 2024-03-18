using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoangNgocTrinhContext context = new HoangNgocTrinhContext();
            //convert toàn bộ sách về dạng List
            List<Book> arr = context.Books.ToList();
            arr.ForEach(book =>
            {
                if (book.BookCategoryId == 5)
                {
                    Console.WriteLine(book.BookId + "| " + book.BookName + " | " + book.PublicationDate);
                }
            });




            // context.Books.ForEachAsync(book => { Console.WriteLine(book.BookId + "| " + book.BookName + " | " + book.PublicationDate); });
        }
    }
}
