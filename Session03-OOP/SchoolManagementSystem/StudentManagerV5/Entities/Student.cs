using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //auto implemented property
        //tự động generate _backing field ngầm lúc runtime
        //bên java chính là sử dụng thư viện Lombok

        //lỡ quên thì gõ prop tab tab sửa lại data type và property name cho phù hợp
        //đừng quên truyền thống propfull tab tab để có backing field
    }
}
