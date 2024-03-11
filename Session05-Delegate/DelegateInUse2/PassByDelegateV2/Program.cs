namespace PassByDelegateV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action f1 = ShowMsg;
            // PrintMessage(hàm);
            //PrintMessage(ShowMsg); //đây là lập trình hàm
            //PrintMessage(() => Console.WriteLine("Phản ứng của t"));
            // PrintMessage(delegate () { Console.WriteLine("Phản ứng của t"); });

            //PrintMessage(() =>
            //{
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //});

            //PrintMessage(() =>
            //{
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        if (i % 2 != 0) Console.Write(i + " ");
            //    }
            //});

            
        }
        static void ShowMsg() => Console.WriteLine("và ô văn kê hôm nay chúng ta chơi con game uno nha!");
        static void PrintMessage(Action f1)
        {
            //khi chạy hàm PrintMessage thì cần phải đưa vào 1 hàm khác. Lí do: do hàm này printMSG() cần nhận vào 1 giá trị gán cho biến f2, f2 là delegate nên cần 1 hàm có sẵn

            //rồi đưa value thì xài.
            Console.WriteLine("I'm a PrintMessage method. For now, i will run another method pass by me");
            f1.Invoke(); //call-back


        }
        static void PrintMsg(Action<int> f2)
        {
            Console.WriteLine("Input 1 number: ");
            
            f2(n);
        }
       
    }
}
