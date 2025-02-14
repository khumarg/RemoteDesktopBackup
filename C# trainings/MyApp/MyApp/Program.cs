namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new GradeCalculator();
            Console.Write("Enter the percentage : ");
            var percentage = Convert.ToInt32(Console.ReadLine());
            var grade = calc.GetGradeByPercentage(percentage);
            Console.WriteLine("Student Grade = " + grade);
        }
    }
}
