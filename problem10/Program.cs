// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 
// 456 -> 5
// 782 -> 8
// 918 -> 1


int GetSecondDigit(int num) => (num / 10) % 10;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа {number} - {GetSecondDigit(number)}");