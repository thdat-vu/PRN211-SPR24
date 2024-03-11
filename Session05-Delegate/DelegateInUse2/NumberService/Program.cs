namespace NumberService
{
    //Cabinet come back
    //Viết 1 class thùng chứa mà chứa 1 mảng các con số
    //1. in ra các số dangd có
    //2. in số chẵn
    //3. in số lẻ
    //4. in ra..

    internal class NumberServices
    {
        private static List<int> _arr = new List<int>() { 1, 2, 3, 4, 5 ,6, 7, 8, 9, 11, 8 , 10, 50, 100, 101, 99 };

        //CRUD
        //1. PrintAll()
        public static void PrintAll()
        {
            
            _arr.ForEach(x => Console.Write(x+" "));
        }
        public static void PrintOdds()
        {
            _arr.ForEach(x =>
            {
                if (x % 2 != 0) Console.Write(x + " ");
            });
        }
        public static void PrintEvens()
        {
            _arr.ForEach(x =>
            {
                if (x % 2 == 0) Console.Write(x + " ");
            });
        }

        //4. Print on demand, đưa nhu cầu của bạn vào
        public static void PrintByYourSelf(Action<int> f) //trỏ đến F(int x)
        {
            foreach (var x in _arr)
            {
                f(x); //hàm này làm gì với con x, bố ai mà biết???
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberServices.PrintByYourSelf(n => {
                if (n % 5 == 0) 
                    Console.Write(n + " ");
            });

            //NumberServices.PrintAll();
            //NumberServices.PrintEvens();
            //NumberServices.PrintOdds();
        }
    }
}
