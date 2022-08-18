/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}
string Reverse(string value)
{
    int num = int.Parse(value);
    string result = "";
    int a = 0;
    for (int i = 0; i < value.Length; i++)
    {
        a = num % 10;
        num /=  10;
        result += a;
    };
    return result;
}
string Checking(string value1, string value2)
{
    string result = "Число не является палиндромом";
    if (value1 == value2)
    {
        result = "Число является палиндромом";
    }
    return result;
}

string one = Prompt("Введите число: ");
string two = Reverse(one);
string message = Checking (one, two);
System.Console.Write(message);