// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
string a = Console.ReadLine();
int number = int.Parse(a);

if((number % 2) == 0) {
    System.Console.WriteLine("Число четное");
} else {
    System.Console.WriteLine("Число нечетное");
}