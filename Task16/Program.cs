// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result1 = numberA / numberB;
int result2 = numberB / numberA;
if (result1 == numberB || result2 == numberA)
{
    Console.WriteLine("Да");   
}    
else
{
    Console.WriteLine("Нет");
} 


