using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities.V2
{
    internal class Student
    {
        private string _id;         //biến lưu các đặc trưng của 1 object 
        private string _name;       //nào đó sẽ đc tạo ra bởi new
        private string _email;      //biến bắt buộc phải gọi tên mới là
        private int _yob;           //BACKING FIELD và method gọi chung là
        private double _gpa;        //MEMBER OF A CLASS, NHỮNG THÀNH PHẦN TẠO NÊN CLASS, 
                                    //BIẾN/BACKING FIELD DÙNG ĐỂ LƯU TRẠNG THÁI CỦA OBJECT - STATE. TRẠNG THÁI CỦA SV LÀ SN 2K3, ĐIỂM LÀ 9.5

        // 1 CLASS NẾU KO TẠO CTOR, VẪN TẠO OBJECT MỚI
        //state LÀ DEFAULT
        //CHUỐI -> RỖNG
        //SỐ -> 0
        //BOOL -> FALSE
        //VẪN NEW BÌNH THƯỜNG, KHI ĐÓ RUNTIME ENV SẼ TỰ TẠO RA CHO 1 PHỄU DEFAULT, CTOR DEFAULT KHÔNG ĐẦU VÀO, KO CÂU LỆNH

        //public Student()
        //{
            
        //}

        public int GetYob() => _yob;
    }
}
