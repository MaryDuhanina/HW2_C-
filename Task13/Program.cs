// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 && numberA < 1000)
{
    int result1 = numberA % 10;
    Console.WriteLine("Третья цифра " + result1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
