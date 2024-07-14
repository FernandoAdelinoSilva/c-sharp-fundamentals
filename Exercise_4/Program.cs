using System.Globalization;

namespace Exercise_3;

class Program
{
    public static void Main()
    {
        DateTime dateTime = DateTime.Now;

        Console.WriteLine($"Hi, today is: {dateTime} ");

        var month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);

        Console.WriteLine($"Month is: {month} ");
    }
}
