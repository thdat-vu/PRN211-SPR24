using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Entities
{
    internal class Student
    {
		private int _id; //backing field  + Get/Set kiểu mới gọi chung là Full Property
		private string _name;
		private int _yob;


		public int Id => _id;
       

  //      public int Id
		//{
		//	get { return _id; }
		//	//set { _id = value; }
		//}//hợp lý ngoài đời vì id ko nên sửa

		

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        public int Yob 
		{
            get => _yob; 
            set => _yob = value;
        }

    }
}
