// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}
double PowerNumber(int num, int pow)
{
    double result = num;
    if (pow == 0)
    {
        result = 1;
        return result;
    }
    for (int i = 1; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

int number = Prompt("Введите первое целое число:");
int numPow = Prompt("Введите второе целое число:");
double result = PowerNumber(number, numPow);
System.Console.WriteLine($"Число <{number}> в степени <{numPow}> равно <{result}>");