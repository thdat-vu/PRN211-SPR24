namespace PassByDelegate
{
    //C1: viết 1 hàm in ra câu thông báo "và ô văn kê hôm nay chúng ta chơi con game uno nha"
    //dùng hàm bình thường
    //dùng delegate
    //dùng lambda
    //truyền delegate vào 1 hàm

    //C2: truyền delegate vô hàm khác - Action<>, func<> và predicate<>

    //C3: t mún in ShowNameMsg() thông qua printMessage(). Cấm sửa printMsg

    //C4: in ra các số từ 1..100 thông qua PrintMessage()

    //C5: in các số lẻ từ 1...100
    internal class ChickenGang
    {
        public static void ShowNameMsg() => Console.WriteLine("Static: Phản ứng của t!");
        public void ShowMsg2() => Console.WriteLine("Non static: Phản ứng của t!");
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //dùng delegate
            Action f1 = ShowMsg;
            Console.WriteLine("Method inside class");
            f1();
            f1.Invoke();

            Console.WriteLine("Call method outside the class");
            Action f2 = ChickenGang.ShowNameMsg;
            f2();
            ChickenGang ckg = new ChickenGang();
            Action f3 = ckg.ShowMsg2;
            f3.Invoke();

            Action f4 = new ChickenGang().ShowMsg2;
            f4.Invoke();

            Console.WriteLine("Call method using lambda");

            Action f5 = () => Console.WriteLine("và ô văn kê hôm nay chúng ta bắt ma nha!");
            f5.Invoke();

            
        }


        static void ShowMsg() => Console.WriteLine("và ô văn kê hôm nay chúng ta chơi con game uno nha!");

    }
}
