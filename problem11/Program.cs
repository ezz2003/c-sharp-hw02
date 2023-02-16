// 11. Напишите программу, которая выводит случайное трёхзначное число
    // и удаляет вторую цифру этого числа.


int DelSecondDigit(int num)
{
  // int secondDigit = (num / 100) * 10 + num % 10;
  return (num / 100) * 10 + num % 10;
}

int number = new Random().Next(100, 1000);
Console.WriteLine();
Console.WriteLine($"было: {number}, без второй цифры получилось: {DelSecondDigit(number)}");
Console.WriteLine();