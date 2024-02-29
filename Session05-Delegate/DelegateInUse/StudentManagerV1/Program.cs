namespace StudentManagerV1
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string ToString() => $"Student: {Id} {Name} {Yob} {Gpa}";

        //hãy yêu cầu sinh viên in ra các số từ 1...100
        public void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers from 1...100");
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(); //xuống hàng sau khi in xong
        }
        public void doAnyThing(Action f)
        {
            Console.WriteLine("I do anything... Give me your instruction.");
            f.Invoke(); //gọi hàm bên ngoài đưa vào
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Id = "SE1", Name = "An" };

            Action f = () =>
            {
                Console.WriteLine("The list of even");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            };

            //s.doAnyThing(f);
            s.doAnyThing(() =>
            {
                Console.WriteLine("The list of even");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            });
        }
    }
}
