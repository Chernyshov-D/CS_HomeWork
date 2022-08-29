// Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами,
// вывести его на экран, оформить в виде функций (пригодится в дальнейшем)

int[,] CreateArr(int lines, int columns, int min, int max) {
    int[,] arr = new int[lines, columns];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(min, max);
        }
        }
    return arr;
}

void ShowArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] arr = CreateArr(2, 5, 10, 100);
ShowArr(arr);