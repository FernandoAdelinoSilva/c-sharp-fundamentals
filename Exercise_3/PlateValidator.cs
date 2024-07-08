namespace Exercise_3;
internal static class PlateValidator
{
    public static bool Validation(string licensePlate)
    {
        return (DashValidator(licensePlate) 
            && LetterValidation(licensePlate) 
            && NumberValidation(licensePlate));
    }

    private static bool DashValidator(string licensePlate)
    {
        if (licensePlate.Split("-").Length.Equals(2)) return true;

        return false;
    }

    private static bool LetterValidation(string licensePlate)
    {
        string letters = licensePlate.Split("-")[0];

        if (letters.Length.Equals(3) && !letters.Any(char.IsDigit)) return true;

        return false;
    }

    private static bool NumberValidation(string licensePlate)
    {
        string numbers = licensePlate.Split("-")[1];
        if (numbers.Length.Equals(4) && !numbers.Any(char.IsLetter)) return true;

        return false;
    }
}
