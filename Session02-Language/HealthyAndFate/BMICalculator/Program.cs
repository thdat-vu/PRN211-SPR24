//namespace BMICalculator
namespace Bmi //package controller dao
//import dao;
//using dao;
//using Bmi;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double bmi = GetBMI(70, 1.73);
            Console.WriteLine("1.Your BMI is " + bmi); //print the msg by concatenate strings
            Console.WriteLine("2.Your BMI is {0}", bmi); //placeholder 
            //each var iss mapped with a space in target string the order of used var begins with 0.
            Console.WriteLine("3.Your BMI is {0} | {1}", bmi, 2024);
            Console.WriteLine($"4.Your BMI is {bmi} | {2024}"); //interpolation technique

            

            Console.WriteLine($"5. Your BMI is: {BmiCalculator.GetBMI(70, 1.73)}");

            BmiCalculator.EvaluateBmiStatus(bmi);
            Console.WriteLine(BmiCalculator.EvaluateBmiStatus(bmi));
        }

        //static chỉ chơi với static 

        //static double GetBMI(double weight, double height)
        //{
        //    return weight / (height * height);
        //} Ctrl + K + C to comment multiple lines
        //Ctrl + K + U to uncomment

        //body expression
        //ko đc nhầm lẫn với biểu thức Lambda
        //do cả 2 style đều xài chung => d
        //hàm chỉ có 1 lệnh duy nhất, ddc phép rút gọn code, rút cả return 
        //cú pháp này đc gọi là body expression
        static double GetBMI(double weight, double height) => weight / (height * height);

        

    }
}
