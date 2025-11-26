namespace dz9
{
    internal class DateAndMathUtils
    {
        public DateAndMathUtils() { }
        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public void ShowDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
        public void TriangleArea(double base_, double height)
        {
            Console.WriteLine(0.5 * base_ * height);
        }

        public void RectangleArea(double length, double width)
        {
            Console.WriteLine(length * width);
        }
    }
}
