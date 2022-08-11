// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5

System.Console.Write("Введите первое число: ");
string a = Console.ReadLine();
int number1 = int.Parse(a);

System.Console.Write("Введите второе число: ");
string b = Console.ReadLine();
int number2 = int.Parse(b);

if(number1 > number2) {
    System.Console.WriteLine($"max = {number1}, min = {number2}");
} else {
    System.Console.WriteLine($"max = {number2}, min = {number1}");
} 