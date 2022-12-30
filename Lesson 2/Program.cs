// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Square(int number)
{
    return number * number;
}

int SumSquare(int[] pointA, int[] pointB)
{
    int sum = 0;
    for (int i = 0; i < pointA.Length; i++)
    {
        sum = Square(pointA[i] - pointB[i]);
    }
    return sum;
}

double Length(int[] pointA, int[] pointB)
{
    double result = Math.Sqrt(SumSquare(pointA, pointB));
    return result;
}

const int X = 0;

const int Y = 1;

const int Z = 2;

int[] pointA = new int[3];
int[] pointB = new int[3];

pointA[X] = Promt("Введите координату точки А по оси x >");
pointA[Y] = Promt("Введите координату точки А по оси y >");
pointA[Z] = Promt("Введите координату точки А по оси z >");
pointB[X] = Promt("Введите координату точки B по оси x >");
pointB[Y] = Promt("Введите координату точки B по оси y >");
pointB[Z] = Promt("Введите координату точки B по оси z >");
System.Console.WriteLine($"Расстояние между точками равно {Length(pointA, pointB)}");


