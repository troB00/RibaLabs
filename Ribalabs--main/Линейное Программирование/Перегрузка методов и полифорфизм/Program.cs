using System;

namespace VolumeCalculationOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет объемов с использованием перегрузки методов:");

            // Объем куба
            double cubeVolume = CalculateVolume(2);
            Console.WriteLine($"Объем куба со стороной 2 равен {cubeVolume}.");

            // Объем параллелепипеда
            double boxVolume = CalculateVolume(3, 4, 5);
            Console.WriteLine($"Объем параллелепипеда со сторонами 3, 4 и 5 равен {boxVolume}.");

            // Объем цилиндра
            double cylinderVolume = CalculateVolume(3.0, 5);
            Console.WriteLine($"Объем цилиндра с радиусом 3 и высотой 5 равен {cylinderVolume:F2}.");

            // Объем шара
            double sphereVolume = CalculateVolume(3.0);
            Console.WriteLine($"Объем шара с радиусом 3 равен {sphereVolume:F2}.");
        }

        // Метод для расчета объема куба
        static double CalculateVolume(double a)
        {
            return a * a * a;
        }

        // Метод для расчета объема параллелепипеда
        static double CalculateVolume(double a, double b, double c)
        {
            return a * b * c;
        }

        // Метод для расчета объема цилиндра
        static double CalculateVolume(double r, double h)
        {
            return Math.PI * r * r * h;
        }

        // Метод для расчета объема шара (используем другой тип параметра для перегрузки)
        static double CalculateVolume(float r)
        {
            return (4 * Math.PI * Math.Pow(r, 3)) / 3;
        }
    }
}