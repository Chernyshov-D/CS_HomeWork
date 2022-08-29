// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double[,] CreateTwoDimensionalArray(int lines, int columns, int min, int max)
{
    double[,] array = new double[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max) / 10.0;
        }
        }
    return array;
}

void ShowTwoDimensionalArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double[,] array = CreateTwoDimensionalArray(Prompt("Введите количество строк: "), 
                                            Prompt("Введите количество столбцов: "), -100, 100);
ShowTwoDimensionalArray(array);