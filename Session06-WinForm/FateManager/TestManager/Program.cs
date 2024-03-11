using Services;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test ngày sinh 7/3
            string zodiacSign = ZodiacCalculator.GetZodiacEnglish(3, 7);
            Console.WriteLine("Sign(EN) " + zodiacSign);
            Console.WriteLine("Sign(VI) " + ZodiacCalculator.GetZodiacVietnamese(zodiacSign));
            Console.WriteLine("Sign(EN) " + ZodiacCalculator.GetZodiacEnglish(30, 7));

        }
    }
}
