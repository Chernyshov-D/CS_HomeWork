// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message) {
    System.Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[,] CreateTwoDimensionalArray(int lines, int columns, int min, int max) {
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void ShowCreateTwoDimensionalArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

bool CheckIndexes(int[,] array, int line, int column) {
    bool result = true;
    if (array.GetLength(0) <= line || array.GetLength(1) <= column) {
        result = false;
    }
    return result;
}

void FindElement(int[,] array, int line, int column) {
    if (CheckIndexes(array, line, column)) {
        System.Console.Write(array[line, column]);
    } else {
        System.Console.Write("Такого элемента массиве нет");
    }
}

int[,] array = CreateTwoDimensionalArray(4, 3, 1, 100);
ShowCreateTwoDimensionalArray(array);
FindElement(array, Prompt("Введите индекс строки > "), 
                   Prompt("Введите индекс столбца > "));