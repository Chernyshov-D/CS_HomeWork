// Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void FindPositiveNumbers(int m, int n)
{
    if (m <= n) 
    {
        if (m % 2 == 0) System.Console.Write($"{m} ");
        FindPositiveNumbers(m + 1, n);
    }

}

int m = Prompt("Введите первое число: ");
int n = Prompt("Введите второе число: ");
FindPositiveNumbers(m, n);
