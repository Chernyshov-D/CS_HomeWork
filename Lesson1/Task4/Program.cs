// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число: ");
string input = Console.ReadLine();
int num = int.Parse(input);


for (int i = 1; i <= num; i++) {
    if((i % 2) == 0) {
        System.Console.WriteLine(i);
    }

}