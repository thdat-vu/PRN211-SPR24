using StudentManager.Entities.V1;
using StudentManager.Entities.V2;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateObjectV1(); //tạo object kiểu truyền thống dân gian.
            //CreateObjectV2(); //tạo object kiểu lược bỏ tên class ở new
            //do đằng trước Student tiến = ...
            // CreateObjectV3(); //dùng var, nhưng vế new phải chỉ rõ data type cho var là gì
            //CreateObjectV4();
            CreateObjectV5();
        }
        static void CreateObjectV5()
        {
            Entities.V2.Student x = new Entities.V2.Student();
            Console.WriteLine("Yob: " + x.GetYob());
        }
        static void CreateObjectV4()
        {

            var tien = new Entities.V1.Student(name: "Bui Huu Tien", email: "tienbh@...", gpa: 9.5, yob: 2003, id: "SE1");

            tien.ShowProfile();
        } //ta ghi tên của đaià vào của hàm kèm dấu 2 chấm để định danh biến nhận đầu vào
        //new kiểu kiểu này cho phép dùng lộn xộn thư tự truyền vào
        //name-argument: pass value to a method accompany with the variable name. Do not need to follow parameters order strictly
        static void CreateObjectV3()
        {

            var tien = new Entities.V1.Student("SE1", "Bui Huu Tien", "tienbh@...", 2003, 9.5);

            tien.ShowProfile();
        }
        static void CreateObjectV2()
        {

            Entities.V1.Student tien = new("SE1", "Bui Huu Tien", "tienbh@...", 2003, 9.5);
            
            tien.ShowProfile();
        }

        //tạo object từ CLass, đúc tượng từ khuôn
        static void CreateObjectV1()
        {
            //một object chứa nhiều info - complex 
            //ta luôn đặt tên gọi cho mọi thứ quanh ta, object cũng z. Bạn sv Bùi Hữu Tiến, sn 2k3, Cần Thơ, Châu Văn Liêm
            //ta gọi tắt là tiến (camel Case)
            Entities.V1.Student tien = new Entities.V1.Student("SE1", "Bui Huu Tien", "tienbh@...", 2003, 9.5);
            //tien: biến object - obj variable 
            //new Student(...) là object, là những gì tồn tại quanh ta. Bạn sv Tiến với đầy đủ info ở trên là có thật, cụ thể 
            //2 vùng ram đc cấp phát. 
            //new Student () -> ở chỗ HEAP SEGMENT

            tien.ShowProfile();
        }
    }
}
