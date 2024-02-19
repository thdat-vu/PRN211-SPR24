using StudentManager.Entities;
using System.Diagnostics.CodeAnalysis;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateAnObject();
            //PlayWithValueTypeArray();
            //PlayWithValueTypeArrayV2();
            PlayWithStudentArray();
        }

        //MẢNG CỦA CÁC OBJECT, PHỨC TẠP HƠN 1 TÝ, DO CÓ THÊM DẤU . ĐỂ SỜ VÙNG RAM
        
        
        static void PlayWithStudentArray()
        {
            Student[] arr = new Student[5];
            //5 biến Student, tương đương Student s1, s2, s3, s4, s5
            //khác hoàn toàn vs Student Arr; // 1 sv trong tương lai, 1 biến Student
            arr[0] = new Student() { Id = "SE86", Name = "An" , Gpa = 8.6, Yob = 2003}; //arr[0] = 5; ở mảng primitive/value type
            arr[1] = new Student() { Id = "SE82", Name = "Binh", Gpa = 8.2, Yob = 2002 };
            arr[2] = new Student() { Id = "SE81", Name = "Cuong", Gpa = 8.1, Yob = 2001 };
            arr[3] = new Student() { Id = "SE50", Name = "Dung", Gpa = 5, Yob = 2000 };
            arr[4] = new Student() { Id = "SE51", Name = "Em" , Gpa =5.1, Yob = 2005};
            //Câu hỏi: 
            //arr. có sổ gì ko .Length{get} arr là biến con trỏ trỏ vùng new chứ nhiều SV, vùng new này có 1 prop chứa chiều dài mảng
            //arr[0]. có xổ gì ko, chính là TRỎ VÀO CÙNG NEW STUDENT()
            //VÙNG OBJECT CHỨA INFO SV, xổ các public của vùng new Student()
            Console.WriteLine(arr[0]); // đố biết màn hình ra gì
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            //gọi thâm tên ToString()

            //ta in danh sách sinh viên for vì đang chơi mảng
            Console.WriteLine("The student list printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]); //gọi thầm tên em
            }

            Console.WriteLine("The student list printed by using traditional for each");
            foreach (Student x in arr)
            {
                Console.WriteLine(x); //gọi thầm tên em
            }
            foreach (var x in arr)
            {
                Console.WriteLine(x); //gọi thầm tên em
            }

            //ko thích dùng ToString()
            //get từng món của sv[i] mà in mà ghép chuỗi
            Console.WriteLine("The student list printed by using foreach without ToString()");

            foreach (var x in arr)
            {
                Console.WriteLine(@$"Id: {x.Id}
Name: {x.Name}
Email: {x.Email}
Yob: {x.Yob}
Gpa: {x.Gpa}
++++++++++++++++++++++++++++");
            }
        }

        static void PlayWithValueTypeArrayV2()
        {
            //int[] arr = new int[6]; // rồi gán lẻ = arr[0] = 5; arr[1] = 10,...
            int[] arr = { 5,    10,     15,     20,     25,     30,      35,      40,      45 };
            //         //arr[0] arr[1] arr[2] arr[3]  arr[4]   arr[5] arr[6]  arr[7] ...
            Console.WriteLine("The array has the values of (printed in traditional way: ");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\nThe array has the values of (printed in for each: ");
            foreach (var x in arr) //Java:  for(int x: arr)
            {
                Console.Write(x + " ");
                //x = arr[0] = 5, x = arr[1] = 10, ....
                //cw (arr[i]) ~~~~~~ cw(x)
                sum += x;

            }
            //Console.WriteLine();
            Console.WriteLine(@"
    Sum: "+ sum);
        }


        //Mảng là 1  kĩ thuật khai báo nhiều biến cùng loại cùng lúc, ở sát nhau trong RAM, cùng tên
        static void PlayWithValueTypeArray()
        {
            //TUO CẦN LƯU TRỮ 10 CON SỐ NGUYÊN 5 10 15 20 25 40 
            //C1: 10 biến lẻ kiểu int 
            int a = 5, b = 6, c = 7, d = 8, e = 9, f = 10;
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, a6 = 30;
            //xài biến nào thì gõ tên biến đó dùng 
            //cần từng lệnh lẻ để chơi từng biến. 
            //dễ hiểu, mỗi biến 1 value, mỗi value 1 tên gọi
            //ko hiệu quả nếu cần lưu trữ nhiều con số, nhiều biến
            //đặc biệt lúc xử lý
            //in ra 10 biến đi
            Console.WriteLine("Place holder style: {0} {1} {2} {3} {4} {5}",a1, a2, a3, a4, a5, a6);
            
            //tính tổng 100 biến, câu lệnh siêu dài
            //in cũng v

            //C2: DÙNG MẢNG, KHAI BÁO SỈ, MUA THEO LỐC, LÔ
            int[] arr = new int[600]; //đã có 6 biến int r, thiếu value cho từng biến
            //[con số đc quyền thay đổi chỉ ra biến thứ mấy trong loạt biến từng tên arr]
            //[index] chỉ số thứ tự của biến. Có quyền thay đổi từ 0 -> 5

            //gán giá trị cho từng biến của mảng
            arr[0] = 5; //int a = 5  a1 = 5
            arr[1] = 10;
            arr[2] = 15;
            
            //từ từ gán [3]...[5]
            //in mảng
            Console.WriteLine("The value array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



        }
        static void CreateAnObject()
        {            Student s = new Student() {Id ="SE1", Name="An Nguyen", Email ="ann@fpt.edu.vn", Yob = 2003, Gpa = 8.8};
            Console.WriteLine(s.ToString()); //giống ShowProfile() nhưng trả về chuỗi phải tự in

            //ko có hàm ToString() tự viết thì xài ké hàm ToString() của cha - Ông Tổ class Object 
            //hàm này do nothing, show object này vùng new này thuộc class nào
            //muốn in kq riêng, tự viết ToString()
            Console.WriteLine(s); //ko cần .ToString() mà vẫn gọi ToString()
            //Nếu có hàm ToSTring() riêng của ta, thì ko cần gọi nó 1 cách trực tiếp trong câu lệnh cw, vì nó đc gọi ngầm ToString()
            //Thay vì in giá trị con trỏ, pointer, nó sẽ đi toString() mà gọi 
        }
    }
}


//Bài tập về nhà: 
//sắp xếp danh sách sinh viên giảm dần theo điểm trung bình
//sắp xếp danh sách sinh viên tăng dần theo năm sinh
//sắp xếp danh sách sinh viên tăng dần theo tên gọi
//gợi ý: video về mảng và sắp xếp trong môn JAVA OOP trên trên GIÁO.LÀNG