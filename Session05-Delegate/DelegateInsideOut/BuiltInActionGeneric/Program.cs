using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace BuiltInActionGeneric
{
	delegate void OneInputNoOutput(string s);
	delegate double F2num(int x, int y); //Func<int, int, double>
	internal class Program
	{
		static void Main(string[] args)
		{
			//viết hàm nhận vào 1 câu thông báo và in ra câu đó
			Action<string> printMsg = s => Console.WriteLine(s);
			printMsg("Cam on Microsoft, BuiltIn Action hay vai~.");
			//Chalenge 1: viết hàm nhận vào 2 con số nguyên, in ra tích của chúng. Viết ngay trong main().


			Action<double, double> calculateMultiply = (x, y) => Console.WriteLine($"{x} times {y} = {x*y}" );
			calculateMultiply(5, 10);
			//chalenge 2: viết hàm nhận vào 2 con số nguyên trả về số mũ của nó 
			//ex: 5^2 =25
			Func<int, int, double> calculateExponential = GetExponent;//= (x, y) => Math.Pow(x, y);
			F2num ftwo = GetExponent; //(x, y) => Math.Pow((double)x, y);
            Console.WriteLine("2^10 = " + ftwo(2,10));

        }

		static double GetExponent(int x, int y) => Math.Pow(x, y);
	}
}
