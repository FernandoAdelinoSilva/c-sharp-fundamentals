using Exercise_2;

public static class Math
    {
        public static double Operation(int operationNumber, double value1, double value2)
        {
            switch (operationNumber)
            {
                case (Int32)Operations.Add: 
                    return Add(value1, value2);
                case (Int32)Operations.Subtract:
                    return Subtract(value1, value2);
                case (Int32)Operations.Times:
                    return Times(value1, value2);
                case (Int32)Operations.Divide:
                    return Divide(value1, value2);
                case (Int32)Operations.Mid:
                    return Mid(value1, value2);
            }
            return 0;
        }

        private static double Add(double a, double b) { return a + b; }
        private static double Subtract(double a, double b) { return a - b; }
        private static double Times(double a, double b) { return a * b; }
        private static double Divide(double a, double b) { return (b == 0) ? 0 : (a / b); }
        private static double Mid(double a, double b) { return Divide(Add(a, b), 2); }
}

