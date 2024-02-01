using StudentManagerV5.Entities;
using System.Data;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateStudentV1();
            PlayWithAnonymousType();
        }
        static void PlayWithAnonymousType()
        {
            //sv liên quan đến GV. Cần tạo thông tin ông thầy, logic bình thường ta cần 1 class Lecturer/teacher như class đã học
            //Có 1 cách khác ko cần tạo class Lecturer 1 cách tường minh (explicit) nhưng vẫn lưu đc info
            //DB: table Product(Id, Name, Description, Unit (đvt), Price, BrandName(xuất xứ), CategoryId(FK)...)
            //~class Product
            //SELECT * FROM PRODUCT -> LẤY TẤT CẢ CÁC CỘT, LẤY BN DÒNG LIÊN QUAN ĐẾN WHERE

            //SELECT Id, Name, Category from Product
            //-> lấy 1 số cột, Phép chiếu projection, rọi đèn pun thấy đc 1 góc

            //C# cho phép tạo object mà ko cần chỉ rõ ra tên class ngay lúc khai báo biến và new object

            //kĩ thuật này đc gọi là ANONYMOUS TYPE - CLASS STUDENT LÀ 1 DATA TYPE
            //                                      - CLASS TEACHER LÀ 1 DATA TYPE
            //                                      KO CÓ DATA TYPE RÕ RÀNG MÀ VẪN RA OBJECT

            var s1 = new{ Id = "SE1", Name = "An Nguyen" };
            //object này readonly thôi, tức là chứa cái auto-implemented prop
            //và nó k chứa hàm, chỉ chứa info

            //in ra thế nào
            Console.WriteLine(s1); //mặc định ToString() của nó sẽ ghép chuỗi ra on ra kq

            Console.WriteLine(s1.ToString());
            Console.WriteLine("ID: " + s1.Id + "| Name: " + s1.Name);
            Console.WriteLine($"ID: {s1.Id}| Name: {s1.Name}" );

            Student s2 = new Student() { Id = "SE2", Name = "Bình Lê", Yob = 2003 };
            Console.WriteLine("ID: " + s2.Id + "| Name: " + s2.Name);
        }

        static void PlayWithArrayV1()
        {
            //Biến: tên gọi cho 1 value, đơn giá trị, phức tạp - object
            //mảng là kĩ thuật khai báo nhiều biến cùng lúc, cùng kiểu, ở sát nhau trong RAM
            int a, b, c, d, e, f, g, i, h, j; //nhiều biến cùng lúc, cùng kiểu, éo đảm bảo ở sát nhau, mình khác tên
            //int arr[] = new int[10];
            //arr là tên gọi chung cho 10 biến int
            //arr[0] là biến đầu tiên
            //arr[1] là biến kế tiếp
            //4 byte trong RAM chứa value!!! là con int
        }

        static void CreateStudentV2()
        {
            Student student = new Student() { Id = "SE1", Gpa = 6.8, Name = "An Nguyen", Yob = 2003 };
            //kĩ thuật create object using OBJECT INITIALIZER
            //tạo object gán luôn property, default chủ động
            //giống như new qua phễu truyền tham số
            //hay ở chỗ không cần quá nhiều ctor,
            //cách mình gán value cho property chính là giống kiểu
            //truyền tham số cho phễu ctor
        }

        static void CreateStudentV1()
        {
            //Student s = new Student(); //default 
            //var s = new Student();
            Student s = new ();
            s.Id = "SE1";
            s.Name = "An Nguyen";
            s.Yob = 2003;
            s.Gpa = 6.8; //tạo ra đi rồi edit
            Console.WriteLine($"An profile at first: {s.Id} {s.Name} {s.Yob} {s.Gpa}");
        }
    }
}
