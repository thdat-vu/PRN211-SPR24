using System.Threading.Channels;

namespace DelegateOverall
{

	public delegate void NoInputNoOutputDelegate(); //t đại diện cho các hàm cụ thể nào đó style void F()
	public delegate void OneInputNoInputDelegate(int x); // t đại diện cho style void F(int n)
	internal class Program
	{
		static void Main(string[] args)
		{
			//NoInputNoOutputDelegate showInfo = new NoInputNoOutputDelegate(SayMsg);
			//NoInputNoOutputDelegate showInfo = SayMsg;
			//showInfo(); //gọi gián tiếp cứ nhớ () là gọi hàm. 
			//showInfo += PrintIntegerList; // multicast delegate
			//showInfo();

			//         //in số từ 1....1000
			//         Console.WriteLine("\n\n This list of number from 1...1000");
			//OneInputNoInputDelegate printOnDemand = PrintIntegerList;
			//printOnDemand(1000); //~ PrintIntegerList(1000);


			//1. t muốn in câu thông báo chúng ta của tương lai! Dùng delegate 
			//2. t muốn in ra màn hình các số chẵn từ 1....1000 //dùng delegate
			//ans:
			//1. tạo hàm riêng lẻ, sau đó gán nick cho nó như đã làm4
			//NoInputNoOutputDelegate printMessage = SayFuture;
			//printMessage += PrintEvenNumbers;
			//printMessage.Invoke();

			//2. LÀM BIẾNG TẠO HÀM LẺ - TỨC LÀ KO VÀO QUÁN NGỒI 1 CHỖ - CÓ SẴN 
			//	UỐNG CF TAKE AWAY, ON THE GO, LÀM BIẾNG TẠO HÀM LẺ NHƯ Ở DƯỚI
			//	TỌA HÀM NGAY LÚC KHAI BÁO VÀ GÁN LUẬT SƯ, NGAY LÚC GÁN HÀM CHO NICK MỚI
			

			//đưa code ngay ở đây
			//Anonymous function
			NoInputNoOutputDelegate printMessage = delegate() 
			{ 
				Console.WriteLine("Chung ta cua tuong lai"); 
			};

			//invoke như bt 
			//printMessage();

			//mún in các số lẻ từ 1...100
			printMessage = delegate ()
			{
				Console.WriteLine("The even number list of 1.... 100");
				for (int i = 1; i <= 100; i++)
				{
					if (i % 2 == 0)
					{
						Console.Write(i + " ");
					}
				}
			};
			//printMessage.Invoke();

			//3. Còn cái dây nịt
			//in số chia hết cho 5

			printMessage = () =>
			{
				Console.WriteLine("The list of divident from 1.... 100");
				for (int i = 1; i <= 100; i++)
				{
					if (i % 5 == 0)
					{
						Console.Write(i + " ");
					}
				}
			};
			//printMessage.Invoke();

			//3.1 . in cho caia thông báo: đào, phở, và piano và mai và sâu!!! 
			NoInputNoOutputDelegate Netflox = () => Console.WriteLine("đào, phở, và piano và mai và sâu");
			Netflox();
		}
		static void SayFuture() => Console.WriteLine("Chung ta cua tuong lai");
		static void PrintEvenNumbers()
		{
            Console.WriteLine("The list of even numbers from 1....1000");
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
                    Console.Write(i + " ");
                }
			}
        }
		//các hàm cụ thể - explicit - vào quán có 1 chỗ ngồi
		static void SayMsg() => Console.WriteLine("No input message comes from No Input - No Output Method");
		static void PrintIntegerList()
		{
            Console.WriteLine("Here is the list of numbers from 1..100");
			for (int i = 1; i <= 100; i++)
			{
                Console.Write($"{i} ");
            }
        }

		//in từ 1 cho đến n 
		static void PrintIntegerList(int n)
		{
			
			if(n < 1)
			{
                Console.WriteLine("Invalid n. N must be  >= 1");
				return;  //return nothing.
            }
			Console.WriteLine("Here is the list of numbers from 1..n");
			for (int i = 1; i <= n; i++)
			{
				Console.Write($"{i} ");
			}
		}
	}
}
