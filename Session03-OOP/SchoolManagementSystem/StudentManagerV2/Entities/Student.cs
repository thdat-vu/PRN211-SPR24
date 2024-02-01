using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    internal class Student
    {

        private string _id;         //_conLạcĐà
        private string _name;       //private là mặc định 
        private string _email;
        private int _yob;
        private double _gpa;

        //show ra info khi cần thiết bằng cái hàm Get() bạn hỏi tôi đáp, tôi return cái tôi đang có

        //nếu ta không làm cái phễu để hứng vật liệu, ta vẫn có được 1 cái obj = không khí lấp đầy khuôn - mọi value default 

        //Quá trình biên dịch code runtime machine sẽ lo cho ta 1 cái phễu / ctor rỗng, ko nhận, ko xử lý gì cả
        //gọi tao m sẽ có 1 obj rỗng - default value bên trong
        //public Student(){} //hình dáng phễu rỗng


        //có những tình huống bạn thích làm cơ cũng ok.
        //một class có thể có nhiều các fill info vào tức là có thể có nhiều phễu - nhiều ctor
        //nếu đã tạo ít nhất 1 ctor khác rỗng thì máy sẽ ko tự tạo ra thêm ctor rỗng, trừ phi bạn từ làm
        //nếu có ctor rỗng và ctor khác thì bạn có nhiều cách new 



        

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }
        public Student()
        {
            
        }

        //ta có 2 quyền trên info: xe, và sửa, Get() và Set() y chang máy dt mới mua: xem đc hình nền, và thay đổi hình nền - Settings 
        //đưa ảnh mới vào, t đổi cho - đè value mới
        //điểm thi cuối kì 5 đc 9.0 


        public void setGpa(double gpa) => _gpa = gpa;
        //sửa info trên object đã đc đúc ra trước đó, đúc trước đó qua con đường gọi new dùng phễu đổ info 
        //giống info là thay đổi info, khác ctor: ctor tạo object, 
        //hàm set() thay đổi trên obj, giống edit profile trên FB

        public void ShowProfile()
        {
            Console.WriteLine($"{_id} | {_name}| {_gpa} ");
        }
    }
}
