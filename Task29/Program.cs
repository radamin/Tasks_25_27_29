// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// Например: 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = CreatArray(8);
PrintArray(array);

int[] CreatArray(int size)
{
  int[] arr = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 11);
  }
  return arr;
}
void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0, 11);
    if (i < (arr.Length - 1))
    {
      Console.Write(arr[i] + ", ");
    }
    else
    {
      Console.Write(arr[i] + "]");
    }
  }
}
