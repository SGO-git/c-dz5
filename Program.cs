// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 1000 || Number < 99)
{
    System.Console.WriteLine("Wrong number");
}
else
{
    Number = Number / 10;
    int MiddleNumber = Number % 10;
    System.Console.WriteLine(MiddleNumber);
}
