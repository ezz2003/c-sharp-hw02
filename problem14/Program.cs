// 14. напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23 

string AnswerRemainder(int num)
{
  // int rem1 = num % 7;
  // int rem2 = num % 23;
  return num % 7 == 0 & num % 23 == 0 ? $"Число {num} кратно числу 7 и числу 23": $"Число {num} не кратно числу 7 и числу 23";
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AnswerRemainder(number));