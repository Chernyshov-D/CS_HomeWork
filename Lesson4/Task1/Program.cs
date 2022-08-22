// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double num(int a, int b)
{   
    double result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int a = Prompt("Введите первое число: ");
int b = Prompt("Введите второе число: ");
double exponentiation = num(a, b);

System.Console.Write($"Результат: {exponentiation}");