using AnalogueClock;

class Program
{
    static void Main(string[] args)
    {
        AngleCalculator angleCalculator = new AngleCalculator();
        Console.Write("Enter the hours (0-12): ");
        int hours = Convert.ToInt32(Console.ReadLine());
            
        Console.Write("Enter the minutes (0-59): ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        double lesserAngle = angleCalculator.CalculateAngle(hours, minutes);

        Console.WriteLine($"The lesser angle between the hour and minute hands is: {lesserAngle} degrees");
    }
}