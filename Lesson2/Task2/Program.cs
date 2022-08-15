// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

System.Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();
int num = int.Parse(input);

if(num >= 100 && num < 1000) {
    int one = num / 100 % 10;
    int two = num / 10 % 10;
    int three = num % 10;
    int result = one * 10 + three;
    System.Console.WriteLine(result); 
} else {
    System.Console.WriteLine("Число не трехзначное!");
}