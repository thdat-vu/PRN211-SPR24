using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    //Cabinet là Cái Tủ đựng nhiều hồ sơ Sinh Viên
    //Student là từng bạn, từng hồ sơ
    //1 đống hồ sơ thì phải có chỗ để lưu trữ: chính là Cái Tủ
    //Tư duy Cái Tủ thì tương lai ta sẽ có Tủ SE, Tủ IA, Tủ GD
    //tư duy class clone ra object
    //new Cabinet là có 1 cái tủ sẵn sàng đựng nhiều hồ sơ thep phân loại nào đó. Tư Duy OOP Class clone ra object cùng hệ 
    internal class Cabinet //CRUD - CREATE, RETRIEVE, UPDATE, DELETE
    {
        private Student[] _list = new Student[300];
        //ta có 1 cái tủ đựng 300 hồ sơ 
        //nhưng thực sự chưa có hồ sơ nào cả, giống như mua tủ ngoài đời
        //khi có 1 món đồ bỏ vào tủ, tức là bỏ vào ngăn nào, bỏ vào mảng ở vị trí nào đó 
        //_lis[i] = new Student()

        private int _count = 0; //biến đếm số phần tử trong mảng 
                                //cứ add 1 hồ sơ vào mảng thì _count++
                                //for đến _count, cái mới thi gán vào _count

                                //add[_count++] add[0] add[1] add[2] của mảng 
                                //_listp[_count] = new Student() {....}; count++;

        //giả bộ tủ đã đc add hồ sơ, hiện có _count phần tử, _count hồ sơ đc new Student()

        //ta in ra danh sách hồ sơ Sinh Viên 
        public void PrintStudentList() //retrieve
        {
            //ta ko đc for đến hết mảng mà chỉ for đến _count
            Console.WriteLine($"There is/are {_count} student(s) in the cabinet");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);
            }                       //gọi thầm tên em


        }

        //hàm create
        public void AddStudent(string id, string name, string email, int yob, double gpa)
        {
            _list[_count] = new Student() { Id = id, Name = name, Email = email, Yob = yob, Gpa = gpa };
            _count++;
        }
    }
}
