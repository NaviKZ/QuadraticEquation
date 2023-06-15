using System;

namespace QuadraticEquation
{
    internal class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0 && b == 0 && c != 0)
            {
                if (-c / a < 0)
                {
                    Console.WriteLine("Уравнение не имеет корней");
                }
                else
                {
                    Console.WriteLine($"X1 = {Math.Sqrt(-c / a)}, X2 = {-Math.Sqrt(-c / a)}");
                }
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                Console.WriteLine($"X1 = 0, X2 = {-b / a}");
            }
            else if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("X1,2 = 0");
            }
            else
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant == 0)
                {
                    double x = -b / (2 * a);

                Console.WriteLine($"Уравнение имеет один корень: X = {x}");
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("Действительных корней нет");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine($"Уравнение имеет два корня: X1 = {x1}, X2 = {x2}");
                }
            }

            Console.ReadKey();
        }
    }
}
