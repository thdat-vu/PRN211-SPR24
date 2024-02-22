using Repositories.Entities;
using Services;
using System.Collections;
using System.Xml.Linq;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Java: ArrayList<Student> seBox = new ArrayList<Student>();
            Cabinet<Student> seBox = new Cabinet<Student>();
            seBox.Add(new Student() { Id = "SE1", Name = "An", Email ="an@gmail.com", Yob = 2000, Gpa = 8.6});
            seBox.Add(new Student() { Id = "SE2", Name = "Bình", Email = "binh@gmail.com", Yob = 2004, Gpa = 8.4 });


            //cần tủ khác đựng hồ sơ ngành Biz
            Cabinet<Student> bizBox = new Cabinet<Student>();
            bizBox.Add(new Student() { Id = "SS1", Name = "Cuong", Email = "cuong@gmail.com", Yob = 2005, Gpa = 8.2});
            bizBox.Add(new Student() {Id = "SS2", Name = "Dung", Email = "dung@gmail.com", Yob = 2005, Gpa = 8.7});

            //đựng Lecturer đi
            Cabinet<Lecturer>selecBox = new Cabinet<Lecturer>();
            selecBox.Add(new Lecturer() { Id = "LEC1", Name = "Em" });
            selecBox.Add(new Lecturer() { Id = "LEC2", Name = "Giang" });
            //in kq các hồ sơ của mỗi tủ
            Console.WriteLine("The list of SE Students:");
            seBox.PrintList();
            Console.WriteLine("The list of Biz Students:");
            bizBox.PrintList();
            Console.WriteLine("The list of SE Lecturers:");
            selecBox.PrintList();
        }
    }
}
