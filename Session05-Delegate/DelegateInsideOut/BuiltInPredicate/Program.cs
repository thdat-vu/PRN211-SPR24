using System.Reflection.Metadata.Ecma335;

namespace BuiltInPredicate
{
    delegate bool CheckGreaterThan2k3Delegate(int n);

    internal class Student
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string ToString() => $"{Id} | {Name} | {Yob} | {Gpa}";
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student() {Id = "SE1", Name = "An", Yob = 2003, Gpa = 8.6 };

            Predicate<Student> checkGpaGt8 = (s) => s.Gpa >= 8;
            Console.WriteLine("Check An's Gpa? " + checkGpaGt8(an));


        }


        //static void Main(string[] args)
        //{
        //    bool result = CheckGreaterThan2k3(2004);
        //    Console.WriteLine("2004>2003? " + result);



        //    Console.WriteLine("2004>2003? " + CheckGreaterThan2k3(2004));
        //    Console.WriteLine("2000>2003? " + CheckGreaterThan2k3(2000));


        //}

        //vietes ra 1 hàm kiểm tra xem nhận vào 1 con số nguyên, kiểm tra con số đó có lớn hơn > 2003 hay ko. 
        //public static bool CheckGreaterThan2k3(int n)
        //{
        //    if(n > 2003) 
        //        return true;
        //    return false;
        //}
        //public static bool CheckGreaterThan2k3V2(int n)
        //{
        //    return n > 2003;

        //}

        //static void Main(string[] args)
        //{
        //    //hãy kiểm tra 1 số có lớn 2003 hay k dùng delegate
        //    CheckGreaterThan2k3Delegate f = CheckGreaterThan2k3;
        //    Console.WriteLine("2005 > 2003 ? " + f(2005));
        //    //ko xài delegate tự tạo thì phải xài delegate Microsoft cho
        //    //using Func<>
        //    Func<int, bool> fx = CheckGreaterThan2k3;
        //    Console.WriteLine("2005 > 2003 Using Func? " + fx(2005));
        //    Predicate<int> fy = CheckGreaterThan2k3;
        //    Console.WriteLine("2005 > 2003 Using Predicate? " + fy(2005));

        //    //ko xài hàm check()
        //    fy = n => n > 2003;
        //    Console.WriteLine("2024 > 2003 Using Predicate & Lambda? " + fy(2024));

        //    //viết hàm nhận vào 1 sinh viên, trả ra xem điểm trung bình của bạn ấy có đúng là >= 8 ko



        //}
        public static bool CheckGreaterThan2k3(int n) => n > 2003;

        
    }
}
