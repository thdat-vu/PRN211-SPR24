using StudentManagerV3.Entities;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Gpa at first: " + s.Gpa); //GetGpa()
            s.Gpa = 9.9;
            Console.WriteLine("Gpa for now: " + s.Gpa);
        }
    }
}
