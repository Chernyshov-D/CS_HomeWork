// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

void randomArray (int[] array) { // Функция заполнения массива случайными числами
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1, 100);
    }
}

void showArray (int[] array) { // Функция вывода массива
    for (int i = 0; i < array.Length; i++) 
    {
        System.Console.Write($"{array[i]},  ");
    }
}

int FindSecondMax(int[] array) {  // Функция поиска второго максимального числа в массиве  
    int firstMax = 0;
    int secondMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > firstMax)
        {
            firstMax = array[i];
        }
    };
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > secondMax && array[j] < firstMax)
        {
            secondMax = array[j];
        }
    };
    return secondMax;
}

int[] array = new int[8]; // Создаем массив с 8 элементами
randomArray(array); // Заполняем массив
showArray(array); // Выводим массив
System.Console.WriteLine($"=> Второе максимальное число в массиве: {FindSecondMax(array)}");
