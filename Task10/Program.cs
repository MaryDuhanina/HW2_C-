// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 && numberA < 1000)
{
    int result1 = numberA/10;
    int result2 = result1 % 10;
    Console.WriteLine("Вторая цифра " + result2);
}
else
{
    Console.WriteLine("Число не техзначное");
}