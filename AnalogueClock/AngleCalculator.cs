namespace AnalogueClock
{
    public class AngleCalculator
    {
        public double CalculateAngle(int hours, int minutes)
        {
            double hourAngle = (hours % 12) * 30 + (minutes / 60.0) * 30;
            double minuteAngle = minutes * 6;
            double angle = Math.Abs(hourAngle - minuteAngle);

            return Math.Min(angle, 360 - angle);
        }
    }
}