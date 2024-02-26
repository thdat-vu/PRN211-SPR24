namespace DelegateOverallV3
{

	//diện tích hcn(chiều dài, chiều rộng)
	//diện tích tam giác(chiều cao, đáy)
	//tính a^b
	//cả 3 đều return kq

	delegate double OneOrMoreInputOneOutputDelegate(double x, double y);
	//double F(x, y)
	internal class Program
	{


		static void Main(string[] args)
		{
			//diện tích hcn(chiều dài, chiều rộng)
			OneOrMoreInputOneOutputDelegate compute = (x, y) => x * y;
			double result = compute.Invoke(5, 20);
            Console.WriteLine("area 5 x 20: " + result);

			//hàm mũ a^b
			compute = (a,b) => Math.Pow(a, b);
            Console.WriteLine("a ^ b: " + compute(2,10)); //1024
        }

	}
}
