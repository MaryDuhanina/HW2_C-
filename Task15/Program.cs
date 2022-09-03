// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

while (numberA<8 && numberA>0)
{
    if (numberA > 5 && numberA < 8)
    {
        Console.WriteLine("Ура, выходной)");
        break;
    }

    if (numberA > 0 && numberA < 6);
    {
        Console.WriteLine("Не выходной(");
        break;
    }
}
if (numberA<1 || numberA>7)
{
    Console.WriteLine("Нет такого дня недели");
}
        

