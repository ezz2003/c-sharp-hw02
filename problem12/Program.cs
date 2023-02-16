// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму, и если нет, то выводить остаток от деления.
// 

string AnswerRemainder(int num1, int num2)
{
  int rem = num1 % num2;
  return rem != 0 ? $"Число {num1} не кратно числу {num2}, остаток {rem}": "";
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AnswerRemainder(number1, number2));