/* Задача 2. Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. */

int[] Prompt(){   
    string[] message = new string[] {"'x' точки А", "'y' точки А", "'z' точки А", "'x' точки B", "'y' точки B", "'z' точки B"};
    int[] nubmers = new int[6];
    int i = 0;
    while(i <= 5) {
    System.Console.Write($"Координата {message[i]}: ");
    string input = Console.ReadLine();
    nubmers[i] = int.Parse(input);
    i++;
    }
    return nubmers;
}

double PointLength(int[] point) {
    double result = Math.Sqrt(((point[3] - point[0]) * (point[3] - point[0])) + ((point[4] - point[1]) * (point[4] - point[1])) + ((point[5] - point[2]) * (point[5] - point[2])));
    return result;
}
int[] numsArray = Prompt();
System.Console.Write(PointLength(numsArray));