// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());
if (num == 1||num==2||num==3||num==4||num==5)
{
   Console.WriteLine("Нет, это рабочий день"); 
}
if (num == 6|| num ==7)
{
    Console.WriteLine("Да, это выходной день");
}

if (num>7)
{
   Console.WriteLine("Всего 7 дней недели, такого дня недели нет"); 
}
