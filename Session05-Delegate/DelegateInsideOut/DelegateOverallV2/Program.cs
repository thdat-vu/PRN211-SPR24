namespace DelegateOverallV2
{
	delegate void OneInputNoOutput(int n);

	internal class Program
	{
		static void Main(string[] args)
		{
			//viết cho t hàm nhận vào con int, in ra các số từ 1...n
			OneInputNoOutput printNumbers = (int x) =>
			{ 
                Console.WriteLine($"The list of numbers from 1... {x}");
                for (int i =1 ; i <= x; i++) 
				{
                    Console.Write( i + " " );
                }
			};
			//printNumbers(1000); //ứng vs  hàm nhận đầu vào

			printNumbers = (x) =>
			{
				Console.WriteLine($"The list of numbers from 1... {x}");
				for (int i = 1; i <= x; i++)
				{
					Console.Write(i + " ");
				}
			};
			printNumbers = x =>
			{
				Console.WriteLine($"The list of numbers from 1... {x}");
				for (int i = 1; i <= x; i++)
				{
					Console.Write(i + " ");
				}
			};
			printNumbers(1000);
		}

		//ko nhầm lẫn giữa lambda và expression body
		//ex bo: hàm chỉ có 1 dòng lệnh, và tên hàm phải đầy đủ
		//lambda: ăn bớt cú pháp, 
	}
}

//quy tắc ăn bớt viết kiểu lambda
//1. công thức chuẩn của hàm là: 
//đầu-ra-nếu-có tên-hàm(đầu-vào-nếu-có)
//vd: int f(int, long)

//2. công thức chuẩn của lambda:
// ()=>{}
// ()=>...
//tham số => code hàm


//2. lược bớt ở vế tham số
//* nếu hàm ko có tham số đầu vào, gõ()=> 
//* nếu hàm óc 1 tham số đầu vào, gõ (int x) =>
//									gõ (x) =>
//									gõ x =>

//*nếu hàm có nhiều tham số trở lên, gõ (int a, string s) =>
//									gõ (a, s) =>

//3. lược bỏ ở phần code 
//*nếu code chỉ có 1 lệnh, gõ      => {1 lệnh;};
//									=> 1 lệnh; //lược bỏ{}
//*nếu code chỉ có nhiều lệnh, như truyền thống gõ {nhìu lệnh ở đây; return nếu cần;};

