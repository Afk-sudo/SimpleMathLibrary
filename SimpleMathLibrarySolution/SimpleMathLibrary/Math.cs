using System;

namespace SimpleMathLibrary
{
    public static class Math
    {
        public const double PI = 3.14159265359;
        public static double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;
        public static double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;
        public static double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

        public static double Split(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine($"Division of {firstNumber} by zero.");
                return 0;
            }
            return firstNumber / secondNumber;
            
        }

        public static double CalculateLapArea(double lapRadius) => PI * lapRadius * lapRadius;
        public static double CalculateSquareArea(double sideLengthSquare) => sideLengthSquare * sideLengthSquare;

        public static double CalculateParallelogramArea(double baseParallelogram, double heightParallelogram) =>
            baseParallelogram * heightParallelogram;


    }
}