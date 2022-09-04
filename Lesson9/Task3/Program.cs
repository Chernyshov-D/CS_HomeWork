// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message) {
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int AkkermanFunc (int m, int n) {
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunc(m - 1, 1);
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int akkerman = AkkermanFunc(Prompt("Введите неотрицательное число M: "), Prompt("Введите неотрицательное число N: "));
System.Console.WriteLine(akkerman);