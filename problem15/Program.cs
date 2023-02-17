// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 
// 6 -> да
// 7 -> да
// 1 -> нет
// 

bool CheckWeekend(int num) => (num == 6) | (num == 7);

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
// string dayStatus;
if (CheckWeekend(number))
{
  Console.WriteLine($"{number} - выходной день недели");
} else 
{
  Console.WriteLine($"{number} - рабочий день недели");
}