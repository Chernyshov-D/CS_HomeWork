// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

System.Console.Write("Введите номер дня недели: ");
string input = Console.ReadLine();
int day = int.Parse(input);


if (day == 6 || day == 7) {
    System.Console.WriteLine("Выходной");
} else if (day < 1 || day > 7) {
    System.Console.WriteLine("Такого дня недели не существует");
} else {
    System.Console.WriteLine("Будний день");
}