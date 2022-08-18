// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void cube(int num) {
    for (int i = 1; i <= num; i++) {
    System.Console.WriteLine(i * i * i);
    }
}

int number = Prompt("Введите любое число: ");
System.Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
cube(number);