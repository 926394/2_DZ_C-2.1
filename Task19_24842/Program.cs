// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите на проверку 5-ти значное, зеркальное число: ");
int num = int.Parse(Console.ReadLine()!);
int ab = num / 1000;
int a = ab / 10;
int b = ab % 10;

int cd = num % 100;
int d = cd / 10;
int c = cd % 10;

if (a == c && b == d)
{
    Console.WriteLine($"Ответ: да, число {num} зеркальное");
}
else 
{
    Console.WriteLine($"Ответ: число {num} неверно");
}
// Console.WriteLine($"Максимальная цифра в числе {num} --> {max}");