// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,] CreateTwoDimensionalArray(int lines, int columns, int min, int max)
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void ShowTwoDimensionalArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void ShowColumnAverage(int[,] array) {
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++) {
        for (int j = 0; j < array.GetLength(0); j++) {
            result += array[j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое в {i + 1} столбце: {Math.Round(result / array.GetLength(0), 1)}");
        result = 0;
    }
}

int[,] array = CreateTwoDimensionalArray(Prompt("Введите количество строк: "), 
                                         Prompt("Введите количество столбцов: "), 1, 10);
ShowTwoDimensionalArray(array);
ShowColumnAverage(array);
