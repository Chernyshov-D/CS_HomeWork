int Prompt(string message) {
    System.Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value = Prompt("Введите трехзначное число: ");
if (value >= 100 && value < 1000) {
int num = value / 10 % 10;
System.Console.WriteLine(num);
} else {
    System.Console.WriteLine("Число не трехзначное!");
}