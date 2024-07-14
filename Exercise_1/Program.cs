using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi, my name is Fernando Silva and this is my fundamentals project. Who are you ?");

        string user = Console.ReadLine();

        if(!String.IsNullOrEmpty(user))
        {
            Console.WriteLine($"Hi {user}. Your name has {user.Count()} characters");

            Console.WriteLine("What about your last name ?");
            
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Ok {user} {userLastName}. Nice to meet you !!");

            DateTime dateTime = DateTime.Now;

            Console.WriteLine($"Today is: {dateTime} ");

            var month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);

            Console.WriteLine($"Month is: {month} ");
        }
        else
        {
            Console.WriteLine("Ok, maybe next time.");
        }
    }
}