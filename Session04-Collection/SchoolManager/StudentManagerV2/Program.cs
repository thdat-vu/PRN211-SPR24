using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mua 2 cái tủ đựng 2 loại hồ sơ Sinh Viên
            Cabinet seBox = new Cabinet();
            Cabinet ssBox = new Cabinet();

            seBox.AddStudent("SE1", "An", "an@", 2003, 8.6); //0
            seBox.AddStudent("SE2", "Binh", "binh@", 2004, 8.7); //1
            seBox.AddStudent("SE3", "Cuong", "cuong@", 2005, 8.8);//2


            ssBox.AddStudent("SS1", "AnS", "an@", 2003, 6.8); //0
            ssBox.AddStudent("SS2", "BinhS", "binh@", 2004, 7.8); //1
            ssBox.AddStudent("SS5", "CuongS", "cuong@", 2005, 8.8);//2

            Console.WriteLine("THE SS STUDENTS: ");
            ssBox.PrintStudentList();

            Console.WriteLine("THE SE STUDENTS: ");
            seBox.PrintStudentList();
        }
    }
}


//HÀM IN CHO NHIỀU LỰA CHỌN:
//IN DS SV TĂNG DẦN THEO, GIẢM DẦN THEO...
//SẮP XẾP DANH SÁCH SINH VIÊN...
//UPDATE 1 HỒ SƠ NÀO ĐÓ
//[i]Id = ???
//KHI ADD vào phải kiểm tra trùng ID -> CHÍNH LÀ HÀM SEARCHID()