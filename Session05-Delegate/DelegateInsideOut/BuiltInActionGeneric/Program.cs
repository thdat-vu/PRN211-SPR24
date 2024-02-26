namespace BuiltInActionGeneric
{
	delegate void OneInputNoOutput(string s);
	internal class Program
	{
		static void Main(string[] args)
		{
			//viết hàm nhận vào 1 câu thông báo và in ra câu đó
			Action<string> printMsg = s => Console.WriteLine(s);
			printMsg("Cam on Microsoft, BuiltIn Action hay vai~.");
		}

		
	}
}
