// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7.3 22.2 2 78] -> 76

double[] CreateArr(int lengthArr, int min, int max)
{
    double[] array = new double[lengthArr];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(min, max) / 10.0;
    }
    return array;
}

void ShowArr(double[] array) {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

double FindMin(double[] array) {
    double result = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (result > array[i])
        {
            result = array[i];
        }
    };
    return result;
}

double FindMax(double[] array) {
    double result = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (result < array[i])
        {
            result = array[i];
        }
    };
    return result;
}

double Difference(double[] array) {
    double max = FindMax(array);
    double min = FindMin(array);
    double result = max - min;
    return result;
}

double[] array = CreateArr(4, -100, 100);
ShowArr(array);
System.Console.WriteLine($"Разница между минимальным и максимальным элементами: {Difference(array)}");