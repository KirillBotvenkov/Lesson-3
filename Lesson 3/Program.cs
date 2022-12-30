// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Cube(int number)
{
    return number*number*number;
}

void ShowCube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.WriteLine(Cube(i));
    }
}

int number = Promt("Введите число");
ShowCube(number);