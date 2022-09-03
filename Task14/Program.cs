// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int result1 = numberA % 7;
int result2 = numberA % 23;
if (result1 == 0 || result2 == 0)
{
    Console.WriteLine("кратно");   
}    
else
{
    Console.WriteLine("не кратно");
} 

