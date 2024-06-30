namespace Exercise_2;

class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Please, Type 2 Numbers");
            Console.WriteLine("First Number:");

            string number1 = Console.ReadLine();
            double value1 = Convert.ToDouble(number1);

            Console.WriteLine("Second Number:");
            string number2 = Console.ReadLine();
            double value2 = Convert.ToDouble(number2);

            Console.WriteLine("Now type the number for the required operation:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");
            Console.WriteLine("5 - Mid");

            string operation = Console.ReadLine();

            double result = Math.Operation(Convert.ToInt32(operation), value1, value2);

            Console.WriteLine($"Result: {result.ToString()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, please provide valid numbers");
        }
        
    }
}
    