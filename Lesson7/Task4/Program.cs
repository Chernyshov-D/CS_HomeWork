// Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их.
// Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

void ShowTwoDimensionalArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SumLineMax(int[,] array) {
    int max = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++) {
            if(array[i, j] > max) {
                max = array[i, j];
            }
        }
        result += max;
    }
    return result;
}

int SumColumnMin(int[,] array) {
    int min = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(1); i++) {
        min = array[0, i];
        for (int j = 0; j < array.GetLength(0); j++) {
            if(array[j, i] < min) {
                min = array[j, i];
            }
        }
        result += min;
    }
    return result;
}

int[,] array = CreateTwoDimensionalArray(Prompt("Введите количество строк: "), 
                                         Prompt("Введите количество столбцов: "), 1, 10);
ShowTwoDimensionalArray(array);
System.Console.Write($"Разность сумм максимальных элементов в каждой строке и минимальных элементов в каждом столбце: ");
System.Console.WriteLine(SumLineMax(array) - SumColumnMin(array));