// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
 char[]arr = numberA.ToString().ToCharArray();

if (numberA > 99)
{
    Console.WriteLine("Третья цифра " + arr[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
