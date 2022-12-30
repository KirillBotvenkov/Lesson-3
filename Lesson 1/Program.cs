// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int ReverseNumber(int number){
    int reverse = 0;
    while (number > 0){
        reverse = reverse * 10 + number % 10;
        number /= 10;
    }
    return reverse;
}

bool IsPalindrome(int number){
    int reverse = ReverseNumber(number);
    return reverse == number;
}
bool ValidateNumber(int number){
    if (number < 10000 || number >= 100000){
        Console.WriteLine("Число не является пятизначным");
        return false;
    }
    return true;
}

int number = Prompt("Введите пятизначное число");
if (ValidateNumber(number))
{
    if (IsPalindrome(number)){
        Console.WriteLine("Число является палиндромом");
    }
    else {
        Console.WriteLine("Число не является палиндромом");
    }
}