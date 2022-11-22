// Найти максимальный элемент массива

int[] array = { 12, 42, 75, 92, 35, 76, 98, 34, 56, 34 };
int count = array.Length;
int max = array[0];
int i = 1;

Console.WriteLine("Исходный массив: ");
while (i < count)
{
  Console.Write($"{array[i]}  ");
  if (array[i] > max) max = array[i];
  i++;
}
Console.WriteLine($"\nМаксимальный элемент: {max}");
