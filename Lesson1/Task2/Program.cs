// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
string a = Console.ReadLine();
int number1 = int.Parse(a);

System.Console.Write("Введите второе число: ");
string b = Console.ReadLine();
int number2 = int.Parse(b);

System.Console.Write("Введите третье число: ");
string c = Console.ReadLine();
int number3 = int.Parse(c);

int max = number1;

if(number2 > max) {
    max = number2;
}

if(number3 > max) {
    max = number3;
}

System.Console.WriteLine($"max = {max}");