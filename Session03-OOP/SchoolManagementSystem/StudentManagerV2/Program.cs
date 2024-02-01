using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CreateObjectAndUsingSetting();
            CreateObjectUsingEmptyCtor();
        }

        static void CreateObjectAndUsingSetting()
        {
            //tạo 1 object ko khí = new phễu rỗng
            Student s = new Student("SE1", "An Nguyen", "@an", 2003, 6.8);
            Console.WriteLine("Before updating GPA: ");

            s.ShowProfile();
            s.setGpa(8.6);
            Console.WriteLine("After updating GPA: ");
            s.ShowProfile();
            
        }
        static void CreateObjectUsingEmptyCtor()
        {
            //tạo 1 object ko khí = new phễu rỗng
            Student s = new Student();
            Console.WriteLine("Before updating GPA: ");
            s.ShowProfile();
            s.setGpa(9.0);
            Console.WriteLine("After updating GPA: ");
            s.ShowProfile();
        }
    }
}
