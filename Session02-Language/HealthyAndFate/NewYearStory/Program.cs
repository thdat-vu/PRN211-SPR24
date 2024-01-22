using Bmi;
using Zodiac;

namespace NewYearStory
{
    internal class Program
    {
        /// <summary>
        /// This app shows 2 main features: BMI Calculator and Zodiac Sign. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // string enSign = ZodiacCalculator.GetZodiacEnglish(18, 1);
            // Console.WriteLine($"Your zodiac: {enSign}");
            //var viSign = ZodiacCalculator.GetZodiacVietnamese(enSign);
            //var: inferrent, suy luận kiểu
            //nghĩa là ngay lúc khai báo biến chưa cần khai báo datatype. Lát hồi khi gán giá trị biến tự động map data type tương ứng.
            //Console.WriteLine($"Your zodiac: {viSign}");

            //BÀI TẬP VỀ NHÀ - ASSIGNMENT #2 
            //Hoàn tất nốt app này, gồm các câu lệnh sau
            //in ra menu gồm
            //1. Tính Bmi
            //2. Tính Cung Hoàng Đạo
            //3. Quit


            //Chọn gì thì làm nấy
            //Làm được validator càng tốt: ngày âm, tháng 15, 30/2
            //cân nặng
            //nhập data luôn là chuỗi: Console.Readline() - String
            //convert thành số
            //int. 
            //double.
            //hỏichatGPT
            //dùng vòng lắp do-while 100% giống Java


            //Nộp lên LMS
            //Deadline: 12h trưa thứ 2, ngày 22/1/2024
            //nộp trễ ko tính điểm. 0 điểm





            Console.WriteLine(@"        Welcome to New Year Story App. 
        Happy New Year! Gong xi fa cai!
        1. Calulate BMI.
        2. Show Zodiac Sign.
        3. Quit.
");
            int choice;//Init a variable for user choice.
            //User should must choose a number from 1 to 3 to use this app.
            do
            {
                Console.Write("Enter a number between 1 and 3 to choose: ");
                //choice = int.Parse(Console.ReadLine());// FormatException error.
                bool isNumber = int.TryParse(Console.ReadLine(), out choice); //this line tries to convert the string input from the user to an integer. Instead of throwing an error if the conversion fails, int.TryParse returns false.
                                                                              //passed by reference.
                if (!isNumber || choice < 1 || choice > 3)//if choice is a invalid input.
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    continue; //skip the rest of code if isNumber is false.
                }

                if (choice == 1) //User enters 1 to calculate BMI.
                {
                    Console.Write("Enter your weight (kilogram): ");
                    //double weight = double.Parse(Console.ReadLine()); //FormatException error.
                    double weight;//Init a zero weight
                    bool isDouble = double.TryParse(Console.ReadLine(), out weight); //this line tries to convert the string input from the user to an double. Instead of throwing an error if the conversion fails, double.TryParse returns false.
                    if (!isDouble || weight <= 0) //if weight is invalid.
                    {
                        Console.WriteLine("Invalid input. Please choose Calulate BMI again and enter a positive number.");
                        continue;//skip the rest of code if isDouble is false.
                    }
                    Console.Write("Enter your height (meter): ");
                    //double height = double.Parse(Console.ReadLine()); //FormatException error.
                    double height;//Init a zero weight
                    isDouble = double.TryParse(Console.ReadLine(), out height); //this line tries to convert the string input from the user to an double. Instead of throwing an error if the conversion fails, double.TryParse returns false.
                    if (!isDouble || height <= 0) //if weight is invalid.
                    {
                        Console.WriteLine("Invalid input. Please choose Calulate BMI again and enter a positive number.");
                        continue;//skip the rest of code if isDouble is false.
                    }
                    double bmi = BmiCalculator.GetBMI(weight, height);
                    string bmiStatus = BmiCalculator.EvaluateBmiStatus(bmi);
                    Console.WriteLine(@$"            Your weight is: {weight} kilogram(s).
            Your height is: {height} meter(s).
            Your Bmi status {bmiStatus}. ");
                    Console.WriteLine();
                }
                else if (choice == 2) //User enters 2 to show Zodiac sign.
                {
                    Console.WriteLine("Tell me your date of birth.");
                    Console.Write("Enter the day: ");
                    //int day = int.Parse(Console.ReadLine()); //FormatException error.
                    int day; //Init the day
                    isNumber = int.TryParse(Console.ReadLine(), out day); //this line tries to convert the string input from the user to an integer. Instead of throwing an error if the conversion fails, int.TryParse returns false.
                    if (day < 1 || day > 31) //if day is less than 1 or more than 31.
                    {
                        Console.WriteLine("A day of a month must be between 1 and 30. Please choose Show Zodiac Sign again and enter valid day.");
                        continue; //skip the rest of code if isNumber is false.
                    }
                    Console.Write("Enter the month: ");
                    //int month = int.Parse(Console.ReadLine());//FormatException error.
                    int month; //Init the month
                    isNumber = int.TryParse(Console.ReadLine(), out month); //this line tries to convert the string input from the user to an integer. Instead of throwing an error if the conversion fails, int.TryParse returns false
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("A month must be between 1 and 12 please choose Show Zodiac Sign again and enter a valid month.");
                        continue; //skip the rest of code if isNumber is false.
                    }
                    if (month == 2 && day > 29) //if the month is 2 and the day is more than 29
                    {
                        Console.WriteLine("February only has 28 or 29 days. Please choose Show Zodiac Sign again and enter a valid date of birth.");
                        continue; //skip the rest of code if date of birth is invalid.
                    }
                    if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) //April, June, September and November only have 30 days
                    {
                        Console.WriteLine("April, June, September and November only have 30 days. Please choose Show Zodiac Sign again and enter a valid date of birth.");
                        continue;
                    }
                    var enSign = ZodiacCalculator.GetZodiacEnglish(day, month);//English
                    Console.WriteLine($"Your zodiac: {enSign}.");
                    var viSign = ZodiacCalculator.GetZodiacVietnamese(enSign);//Vietnamese
                    Console.WriteLine($"Cung hoang dao cua ban la: {viSign}.");
                    Console.WriteLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("See you soon.");//Console shows this message when user enters 3.
                    Console.WriteLine();
                }
            } while (choice != 3); //Do not escape the loop until user enters 3.
        }
    }
}
