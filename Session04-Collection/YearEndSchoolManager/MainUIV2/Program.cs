using Repositories.Entities;
using ServicesV2;

namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithIntList();
            //PlayWithStudentList();
            PlayWithCabinetV2(); //tủ dùng generic và list
        }

        static void PlayWithCabinetV2()
        {
            //Java: ArrayList<Student> seBox = new ArrayList<Student>();
            Cabinet<Student> seBox = new Cabinet<Student>();
            seBox.Add(new Student() { Id = "SE1", Name = "An", Email = "an@gmail.com", Yob = 2000, Gpa = 8.6 });
            seBox.Add(new Student() { Id = "SE2", Name = "Bình", Email = "binh@gmail.com", Yob = 2004, Gpa = 8.4 });


            //cần tủ khác đựng hồ sơ ngành Biz
            Cabinet<Student> bizBox = new Cabinet<Student>();
            bizBox.Add(new Student() { Id = "SS1", Name = "Cuong", Email = "cuong@gmail.com", Yob = 2005, Gpa = 8.2 });
            bizBox.Add(new Student() { Id = "SS2", Name = "Dung", Email = "dung@gmail.com", Yob = 2005, Gpa = 8.7 });

            //đựng Lecturer đi
            Cabinet<Lecturer> selecBox = new Cabinet<Lecturer>();
            selecBox.Add(new Lecturer() { Id = "LEC1", Name = "Em" });
            selecBox.Add(new Lecturer() { Id = "LEC2", Name = "Giang" });
            //in kq các hồ sơ của mỗi tủ
            Console.WriteLine("The list of SE Students:");
            seBox.PrintAll();
            Console.WriteLine("The list of Biz Students:");
            bizBox.PrintAll();
            Console.WriteLine("The list of SE Lecturers:");
            selecBox.PrintAll();
        }

        static void PlayWithStudentList()
        {
            //Student[] arr = new Student[300] //mảng C#, học rồi
            //          arr trỏ đến 1 phòng có 300 ghế ngồi nhưng chưa có sv nào cụ thể 
            //          arr trỏ đến 300 biến Student:
            //                                          arr[0]  arr[1]  arr[2]
            //              ~Khai báo lẻ Student        s1,     s2,     s3
            //
            List<Student> arr = new List<Student>();
            //arr trỏ 1 túi, 1 vùng new bự sẽ dùng chứa nhiều biến Student, hơn 300
            arr.Add(new Student() { Id = "SE1", Name = "An" });
            arr.Add(new Student() { Id = "SE2", Name = "Binh" });
            arr.Add(new Student() { Id = "SE3", Name = "Cuong" });
            Console.WriteLine("The student list using for i: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]); //đc xài như mảng luôn. java hình như ko có
                                           //arr.get(i)
                                           //kĩ thuật indexer
            }
            Console.WriteLine("The student list using foreach: ");
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }
        static void PlayWithIntList()
        {
            //int[] arr = new int[300];
            //arr sẽ trỏ 1 vùng new trong đó 300 biến int khác chờ gán giá trị
            //arr sẽ trỏ 1 vùng new trong đó có chứa 300 biến int mang tên arr[0], arr[1],... 
            //                                 ~ biến int lẻ                int a,     b,   c

            List<int> arr = new List<int>(); //Java sẽ là ArrayList<int> arr = new ArrayList<int>();
                                             //Bên Java cấm ko đc new List() vì List là abstract/interface
                                             //Bên C# List new đc, ArrayList cũng new được
                                             //Nhưng ArrayList ít xài, ko an toàn
                                             //Nên List bên C# xem như là ArrayList bên Java


            //cách xài còn lại như Java
            //arr sẽ trỏ vào 1 vùng new trong đó sex chuacws rất nheieuf biến int khác
            //arr sẽ trỏ vào 1 túi bự chứa nhiều biến int bên trong
            //có 1 biến int vừa đc trỏ vào túi arr, kèm value 1;
            //so sánh với mảng chính là arr[0] = 1;
            arr.Add(1);
            arr.Add(3);
            arr.Add(5);
            arr.Add(7);
            arr.Add(9);
            arr.Add(2);
            arr.Add(4);
            arr.Add(6);
            arr.Add(8);
            arr.Add(10);
            //đếm xem tạm thời "Mảng" đang có bao nhiều phần từ, biến int
            //chưa thèm hỏi value từng đứa
            //arr.Length -> mẢng truyền thống
            Console.WriteLine("The size of bag/arr: " + arr.Count);
            //                            java:       arr.Lenght


            //cứ xem nó rất rất giống mảng, in for bình thường, for each, for đặc biệt từ từ học
            Console.WriteLine("The bag's values: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]); //đc xài như mảng luôn. java hình như ko có
                                                                            //arr.get(i)
                //kĩ thuật indexer
            }
            foreach (int x in arr) 
            {
                Console.Write(x + " ");
            }
        }
    }
}
