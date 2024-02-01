namespace CheckReadOnlyParam1
{   

    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        /// <summary>
        /// Change the name of Student x
        /// </summary>
        /// <param name="x"></param>
        public static void CheckReadOnlyParam(in Student x)
        {


            x.Name = "EmNenDungLai";
        }

        public static void Main()
        {
            Student s = new Student { Name = "DatVT", Age = 18 };
            CheckReadOnlyParam(s);
            Console.WriteLine(s.Name);  //"EmNenDungLai"
        }
    }
}
