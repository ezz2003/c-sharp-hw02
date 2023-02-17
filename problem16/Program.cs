// 16. напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 



bool Answer(int num1, int num2) => num1 * num1 == num2 | num2 * num2 == num1;

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (Answer(number1, number2)){
  Console.WriteLine("Одно число является квадратом другого числа");
}
else
{
  Console.WriteLine("Одно число Не является квадратом другого числа");
}