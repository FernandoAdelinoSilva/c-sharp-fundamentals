namespace Exercise_3;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi, please write your car license plate: ");

        string licensePlate = Console.ReadLine();

        Console.WriteLine("Well, the pattern for Brazil use to be: AAA-1234");

        bool validation = PlateValidator.Validation(licensePlate);

        if (validation) 
        {
            Console.WriteLine("This license plate was valid");
        }
        else
        {
            Console.WriteLine("This license plate was not valid");
        } 

    }
}
