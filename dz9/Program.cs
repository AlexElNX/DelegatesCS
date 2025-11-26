namespace dz9
{
    public delegate void Delegate();
    public delegate void Action();
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayNumberUtils array = new ArrayNumberUtils(5);
            Delegate even;
            even = array.Even;

            array.Print();
            Console.WriteLine();

            even();
            Console.WriteLine();

            Delegate odd = array.Odd;
            odd();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Delegate simpleNumber = array.SimpleNumber;
            simpleNumber();




            DateAndMathUtils dateAndMath = new DateAndMathUtils();
            Action showTime = dateAndMath.ShowTime;
            showTime();

            Action showDate = dateAndMath.ShowDate;
            showDate();

            Action showDay = dateAndMath.ShowDayOfWeek;
            showDay();


            Action<double, double> triangleArea = dateAndMath.TriangleArea;
            Action<double, double> rectangleArea = dateAndMath.RectangleArea;

            triangleArea(10, 10);
            rectangleArea(20, 20);
        }
    }
}
