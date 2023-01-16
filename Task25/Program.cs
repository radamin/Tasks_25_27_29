// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Inter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;
int numB = numberB;
int numA = numberA;


if (numB > 0)
{
  for (int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
  Console.WriteLine("Answer: " + result);
}
else
{
  Console.Write("Error: enter a positive number");
}
