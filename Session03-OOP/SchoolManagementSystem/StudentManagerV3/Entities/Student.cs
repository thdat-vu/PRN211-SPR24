using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //Get() và Set()
        //Csharp cung cấp cách viết mới nhanh hơn cho cả Get() và Set() thay vì viết theo style truyền thống như Java đã học và giống như Java. Kĩ thuật mới này nó gộp cả Get() và Set() vào 1 cái tên gọi đại diện chung cho 1 đặc tính cần làm Get() Set()
        //tên gọi chung đại diện cho cả 2 hàm -> PROPERTY
        //WHY 2 NAME GET???() SET()?? FPR A FIELD/ATTRIBUTE?
        //DÙNG Name là đủ đại diện cho GetName() và SetName()
        //Dùng Gpa là đủ cho cả GetGpa() và SetGpa()

        public string Name { get { return _name; } set {  _name = value; } }
        public int Yob { get { return _yob;} set { _yob = value; } }
        public double Gpa { get => _gpa; set =>_gpa = value; }

        //bạn có quyền chọn riêng get, set method hoặc cả 2 
        //nếu chỉ có get gọi là readonly

        //KĨ THUẬT VIẾT PROPERTY GET SET KÈM BIẾN _ (FIELD, BACKING FIELD) THÌ ĐC GỌI LÀ KĨ THUẬT FULL-PROPERTY
    }
}
