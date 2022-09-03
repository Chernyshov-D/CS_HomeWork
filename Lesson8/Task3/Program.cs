// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void ShowTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo) 
{
    int[,] matrix = new int[matrixTwo.GetLength(0), matrixTwo.GetLength(1)];

    if (matrixOne.GetLength(1) == matrixTwo.GetLength(0)) 
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrixTwo.GetLength(1); k++)
                {
                    temp += matrixOne[i, k] * matrixTwo[k, j];
                    
                }
                matrix[i, j] = temp;
                temp = 0;
            }
        }

    }
    return matrix;
}

int[,] matrixOne = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrixTwo = new int[,] { { 3, 4 }, { 3, 3 } };


System.Console.WriteLine("Матрица 1: ");
ShowTwoDimensionalArray(matrixOne);
System.Console.WriteLine("Матрица 2: ");
ShowTwoDimensionalArray(matrixTwo);
System.Console.WriteLine("Произведение матриц: ");
ShowTwoDimensionalArray(MultiplicationMatrix((matrixOne), (matrixTwo)));