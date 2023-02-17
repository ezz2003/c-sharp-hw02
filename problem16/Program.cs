// 16. напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 



bool Answer(int num1, int num2) => num1 * num1 == num2;

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (Answer(number1, number2)){
  Console.WriteLine($"Число {number2} является квадратом числа {number1}");
}
else
{
  Console.WriteLine($"Число {number2} НЕ является квадратом числа {number1}");
}