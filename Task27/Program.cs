// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Inter number:" + " ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int sum = 0;

if (num > 0)
{
  for (int i = 0; i <= num; i++)
  {
    sum += number % 10;
    number /= 10;
  }
  Console.Write("The sum of the digits: " + sum);
}
else
{
  Console.Write("Error: enter a positive number");
}

