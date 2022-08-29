// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    double result = double.Parse(input);
    return result;
}

double b1 =  Prompt($"Введите b1: ");
double b2 =  Prompt($"Введите b2: ");
double k1 =  Prompt($"Введите k1: ");
double k2 =  Prompt($"Введите k2: ");

double x = (b2 - b1) / (k1 - k2);

System.Console.WriteLine($"Точка пересечения: {x}; {k1 * x + b1}");