namespace Salary2
{
    internal class Program
    {
        static void Main(string[] args)
    
        {
            Console.WriteLine("Enter a number:");
            double Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percentage:");
            double percent = double.Parse(Console.ReadLine());

            double Sum = CalculatePercentage(Salary, percent);

            Console.WriteLine("Result: " + Sum);
        }

        static double CalculatePercentage(double Salary, double percent)
        {
            return Salary= Salary-(Salary * percent) / 100.0;
        }
    }
}