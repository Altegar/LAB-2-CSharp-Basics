// Сушинський Ігор
// Лабораторна робота № 2
// Функції, що містять розгалуження: функції з параметрами.
// Варіант 3

namespace LAB_2_CSharp
{
    internal class Program
    {
        private static double f1(double x, double a, double b, double c)
        {
            // розв'язок за допомогою команд розгалуження в повній формі
            double F;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            else if (a > 0 && c == 0)
                F = -a / (x - c);
            else
                F = (10 * x) / (c - 4);

            return F;
        }

        private static double f2(double x, double a, double b, double c)
        {
            // розв'язок за допомогою команд розгалуження в скороченій формі
            double F = -1;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            if (a > 0 && c == 0)
                F = -a / (x - c);
            if (!(a < 0 && c != 0) && !(a > 0 && c == 0))
                F = (10 * x) / (c - 4);

            return F;
        }

        private static void g1(double x, double a, double b, double c, ref double y)
        {
            // розв'язок за допомогою команд розгалуження в повній формі
            double F;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            else if (a > 0 && c == 0)
                F = -a / (x - c);
            else
                F = (10 * x) / (c - 4);

            y = F;
        }

        private static void g2(double x, double a, double b, double c, ref double y)
        {
            // розв'язок за допомогою команд розгалуження в скороченій формі
            double F = -1;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            if (a > 0 && c == 0)
                F = -a / (x - c);
            if (!(a < 0 && c != 0) && !(a > 0 && c == 0))
                F = (10 * x) / (c - 4);

            y = F;
        }

        private static void h1(double x, double a, double b, double c, out double y)
        {
            // розв'язок за допомогою команд розгалуження в повній формі
            double F;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            else if (a > 0 && c == 0)
                F = -a / (x - c);
            else
                F = (10 * x) / (c - 4);

            y = F;
        }

        private static void h2(double x, double a, double b, double c, out double y)
        {
            // розв'язок за допомогою команд розгалуження в скороченій формі
            double F = -1;

            if (a < 0 && c != 0)
                F = a * Math.Pow(x, 2) + b * x + c;
            if (a > 0 && c == 0)
                F = -a / (x - c);
            if (!(a < 0 && c != 0) && !(a > 0 && c == 0))
                F = (10 * x) / (c - 4);

            y = F;
        }

        private static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // перший спосіб - інформацію отримуємо як результат функції
            Console.WriteLine($"F1 = {f1(x, a, b, c)}");
            Console.WriteLine($"F2 = {f2(x, a, b, c)}");
            Console.WriteLine();

            // другий спосіб - інформацію отримуємо як параметр-посилання
            double y1 = 0, y2 = 0;

            g1(x, a, b, c, ref y1);
            g2(x, a, b, c, ref y2);

            Console.WriteLine($"G1 = {y1}");
            Console.WriteLine($"G2 = {y2}");
            Console.WriteLine();

            // третій спосіб - інформацію отримуємо як вихідний параметр
            double z1, z2;

            h1(x, a, b, c, out z1);
            h2(x, a, b, c, out z2);
            Console.WriteLine($"H1 = {z1}");
            Console.WriteLine($"H2 = {z2}");
        }
    }
}