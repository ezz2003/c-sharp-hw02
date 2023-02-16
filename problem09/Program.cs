// 9. Напишите программу, которая выводит случайное 
// число из отрезка [10,99] и показывает наибольшую цифру числа
// 

void MaxDigit(int num)
{
  int firstDigit = num / 10;
  int secondDigit = num % 10;
  if (firstDigit > secondDigit)
  {
    Console.WriteLine($"Наибольшая цифра числа - {firstDigit}");
  }
  else
  {
    Console.WriteLine($"Наибольшая цифра числа - {secondDigit}");
  }
}

int number = new Random().Next(10, 100);
// int firstDigit = number / 10;
// int secondDigit = number % 10;
Console.WriteLine($"Случайное число из отрезка [10 - 99] -> {number}");
// if (firstDigit > secondDigit)
// {
// Console.WriteLine($"Наибольшая цифра числа - {firstDigit}");
// }
//  else
// {
// Console.WriteLine($"Наибольшая цифра числа - {secondDigit}")
// }
// 

MaxDigit(number);
