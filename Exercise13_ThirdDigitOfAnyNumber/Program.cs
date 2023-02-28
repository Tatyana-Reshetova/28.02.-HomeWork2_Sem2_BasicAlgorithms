// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
if (num < 100 )
{
   Console.WriteLine("Третьей цифры нет "); 
}
if (num>=100 && num < 1000) 
{
Console.WriteLine($"Третья цифра числа {num} -> {num%10}");
}
while (num > 1000)
{
    Console.WriteLine($"{num} -> {num / Convert.ToInt32(Math.Pow(10,count-2)) % 10}");
    count++;
}
