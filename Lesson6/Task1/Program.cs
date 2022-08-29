// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string Prompt(string msg)
{
    System.Console.Write(msg);
    string result = Console.ReadLine();
    return result;
}
void ShowArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]},  ");
    }
    System.Console.WriteLine();
}
int[] ArrNums()
{   
    int count = 0;
    string num = string.Empty;
    int[] tempArr = new int[100];
    for (count = 0; num != "exit"; count++)
    {
        num = Prompt($"Введите число или \"exit\" для выхода: ");
        if (num != "exit") 
        {
            tempArr[count] = int.Parse(num);
        }
    }
    int[] array = new int[count-1];
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = tempArr[i];
    }
    return array;
}
void FindMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Чисел больше нуля: {count}");
}
int[] arr = ArrNums();
ShowArr(arr);
FindMoreZero(arr);