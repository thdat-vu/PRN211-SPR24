namespace Healthy;
//~ package
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
	
	double bmi = BMICalculator.GetBMI(70, 1.73); //70 kg, 1.73 m
	
	Console.WriteLine("Your BMI is " + bmi);
 	
	Console.WriteLine("Press any button to exit");
	Console.ReadLine();
    }
}
