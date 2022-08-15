// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


System.Console.Write("Введите число: ");
string input = Console.ReadLine();
int num = int.Parse(input);

if(num >= 100) {
    while (num > 1000) {
        num /= 10;
    }
    int result = num % 10;
    System.Console.WriteLine(result); 
} else {
    System.Console.WriteLine("Третьей цифры нет!");
}