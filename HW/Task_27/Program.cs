// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()??" ");

int length = NumberLen(number);
SumNumbers(number, length);

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int length)
{
    int result = 0;
    for (int i = 1; i <= length; i++)
    {
        result += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе {number} равна {result}");
}
