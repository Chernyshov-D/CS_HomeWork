// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArr(int lengthArr, int min, int max)
{
    int[] arr = new int[lengthArr];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void ShowArr(int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

int FindNumbers(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    };
    return result;
}

int[] array = CreateArr(4, 100, 1000);
ShowArr(array);
System.Console.WriteLine($"Четные числа {FindNumbers(array)}");