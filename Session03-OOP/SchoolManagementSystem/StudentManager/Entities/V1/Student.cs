using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities.V1
{
    internal class Student
    {
        private string _id; //quy tắc đặt tên cho đặc tính
        private string _name;//của 1 object: _kèm camelCaseNotation
        private string _email;//biến mô tả đặc tính của 1 object 
        private int _yob;       //đc gọi là backed-field, backing field,
        private double _gpa;//Java gọi là property/attribute/characteristic

        //constructor: hàm phễu, nhận thông tin bên ngoài, vật liệu bên ngoài đổ lấp vào các ngóc ngách, đặc tính bên trong của khuôn của Class.
        //Tên hàm tạo ra đối tượng/tên ctor giống 100% tên Class
        //Nó là cái phễu hứng info bên ngoài đưa vào bên  trong
        //Ctrl + .
        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

       
        //mặc định các info của các object là private
        //vậy nếu muốn cho người khác biết, thì ta đưa ra cách giao tiếp hỏi đáp, bạn hỏi tôi đáp, bạn muốn biết hãy hỏi tôi, GetInfo() của t -> hàm Get() xuất hiện

        public string GetName()
        {
            return _name;
        }
        //viết kiểu truyền thống
        public string GetEmail() => _email;
        //expression body khi hàm chỉ có 1 lệnh duy nhất

        //tương tự cho các hàm còn lại

        //khi có nhu cầu chỉnh sửa, update/edit info của object hoặc là mài dũa tinh chỉnh bức tượng đc đúc ra, ta có hành động set(), setting()
        //Set() thiết lập thông tin mới đồng nghĩa phải đưa thông tin mới vào đè/overwrite thông tin cũ
        public void SetGpa(double gpa)
        {
            _gpa = gpa;
        }//truyền thống dân gian
        public void SetYob(int yob) => _yob = yob; //hiện đại mới mẻ
        //expression body

        //hành động show profile giống như trên fb
        public void ShowProfile()
        {
            Console.WriteLine($@"Here is my info: 
ID: {_id}
Name: {_name}
Email: {_email}
Yob: {_yob}
Gpa: {_gpa}");
        }
    }
}
