

using Bmi;

namespace Math

{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sumAll, sumEven, sumOdd = 0;
            sumAll = SumIntegers(out sumEven);
            sumAll = SumOddIntegers(ref sumOdd);
            //vì ref ko hứa hẹn trong hàm sẽ có trả về hay không
            //lỏng lẻo trong lời hứa
            //cho nên để xài ref bắt buộc biến bên ngoài phải có sẵn 1 default value nào đó
            //để ngộ nhỡ hàm ko thèm trả 
            //thì ta còn default 
            //nếu hàm có trả thì ta có giá trị mới đè default
            Console.WriteLine("Sum Odd: "+ sumOdd);
        }

        //cả ref và out đc xem là kĩ thuật truyền tham chiếu
        //pass by ref, tức là trong hàm có sửa gì, biến ngoài kia cũng thay đổi nốt, 
        //đứng đây mà thay đổi đằng kia

        //sửa value trực tiếp của biến đc truyền qua tham số
        //out, ref

        //pass by value, kiểu truyền thống (int a), em chỉ xin value 
        //của biến truyền vào, ko ảnh hưởng bên ngoài hàm.

        //svm tab tab
        //static void Main(string[] args)
        //{
        //    //CheckReadOnlyParam(68);
        //    //PrintIntegerList();
        //    //Console.WriteLine("Sum all: " + SumIntegers());
        //    int sumA, sumE;
        //    sumA = SumIntegers(out sumE);
        //    Console.WriteLine("Sum All: " + sumA);
        //    Console.WriteLine("Sum Even: " + sumE);

        //    //cách xài thứ 2 với biến out trong tham số hàm
        //    sumA = SumIntegers(out int sumAllEvenNumbers);
        //    //khai báo biến để hứng value qua ngả out ngay trên quá trình 
        //    //gọi hàm
        //    Console.WriteLine($"Sum Even numbers {sumAllEvenNumbers}");

        //}

        static int SumOddIntegers(ref int sumOdd)
        {
            int sumAll = 0, sumO = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;
                if (i % 2 != 0)
                    sumO += i;
            }
            sumOdd = sumO; //HÀM REF CÓ THỂ KO CẦN OUT RA
                             //LỎNG LẺO HƠN HÀM OUT
                             //CÁCH XÀI 2 HÀM CŨNG KHÁC

            return sumAll;
        }


        //overloading
        //là hiện tương có thể xảy rả trên bất kì class nào
        //khi có nhiều hàm trùng tên nhau, nhưng khác phần tham số,
        //đầu vào - khác theo data type, ko care trên biến

        //static int SumIntegers(double sumEven) //okela, thay int = double
        //{
        //    return 0;
        //}
        static int SumIntegers(out int sumEven)
        {
            int sumAll = 0, sumE = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumAll += i;
                if(i % 2 == 0)
                    sumE+=i;
            }
            sumEven = sumE; //đẩy value trong hàm ra ngoải ngả param 
            //dùng từ khóa out
            //out: em HỨA sẽ trả về 1 giá trị, bắt buộc phải gán sumEven = 1 cái gì đó.
            return sumAll;
        } //XÀI OUT BẮT BUỘC PHẢI CÓ VALUE CHO OUT TRONG HÀM

        //hàm trả về giá trị
        //tính tổng các số tự nhiên từ 1..100 -> 5050
        //HÀM THIẾT KẾ TỐT LÀ HÀM TRẢ VỀ GIÁ TRỊ CHO AI ĐÓ DÙNG
        // HÀM KHÔNG NÊN CÓ LỆNH NHẬP DỮ LIỆU TỪ BÀN PHÍM, HÀM KHÔNG NÊN CÓ 
        //LỆNH IN RA MÀN HÌNH
        //TA NHẬN VÀO, TRẢ RA -> THIẾT KẾ TỐT MANG Ý NGHĨA THƯ VIỆN
        //REUSE 
        //static int SumIntegers()
        //{
        //    int sumAll = 0;
        //    for (int i = 1; i <= 100; i++) 
        //    {
        //        sumAll += i;
        //    }
        //    return sumAll;
        //}


        //Mantra: static chỉ chơi vs static

        //in ra các số tự nhiên từ 1 đến 100
        static void PrintIntegerList()
        {
            Console.WriteLine("the list of integer from 1 to 100: ");
            Console.WriteLine(@"1 2 3 
4 5 6 
7 
8 9 
10 11 12 13 14 15 16 17 18 19");

            Console.WriteLine(@"

");//xuống hàng 2 dòng kiểu raw verbatim tha vì \n \n 
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
        }

      
        static void CheckReadOnlyParam(in int n)
        {
            //keyword in dùng trong tham số hàm có ý nghĩa
            //ko cho code bên trong hàm thay đổi value n. n trở thành readonly
            //n chỉ có thể dùng để gán cho ai đó, bản thân n ko đc mang giá trị mới
            //TODO AT HOME: với hàm có prototype dạng: 
            //CheckReadOnlyParam(int Student x)
            //hỏi rằng x có thể đc gán giá trị mới hay ko??
            //x là biến object, trỏ vùng new Student(..) kiến thức OOP
            Console.WriteLine($"Before modifying value, n is {n}");
            // n = 2024; // thay đổi value của biến
            int x = n;
            Console.WriteLine($"After modifying value,for now n is {n}");
        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            //xài thư viện /dll từ nơi khác, từ project khác trong cùng solution, nhưng có thể khác namespace
//            //chú ý 3 việc,
//            //1. add cái reference tới .dll hay project cùng solution
//            //2. tick cái option - VIP - Copy Local
//            //3. using cái namespace ở nơi khác chứa code mình sẽ xài
//            //xin phép, chi ra nơi chứa của thư viện/ hàm sẽ xài
//            Console.WriteLine(BmiCalculator.EvaluateBmiStatus(BmiCalculator.GetBMI(70, 1.73)));

//            double bmi = BmiCalculator.GetBMI(70, 1.73);
//            string weightStatus = BmiCalculator.EvaluateBmiStatus(BmiCalculator.GetBMI(70, 1.73));

//            //raw String
//            Console.WriteLine(@$"Your BMI is {bmi} based on the 
//your weight of {70} kilos and 
//your height of {1.73} m.
//<html>
//    <head></head>
//    <body></body>
//</html>
//Your weight status is {weightStatus}");
//            //kĩ thuật in chuôi nguyên bản có sao in vậy.
//            //raw string - verbatim - DÙNG kí tự @ đứng đầu chuỗi
//            Console.WriteLine("Press any button to exit.");
//            Console.ReadLine();
//        }
    }
}
