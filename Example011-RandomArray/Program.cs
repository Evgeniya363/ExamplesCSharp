// Создание и вывод массива случайныз чисел
void FillArray (int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while( index < length)
  {
    collection[index] = new Random().Next(1,100);
    index++;
  }
}

void PrintArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  Console.WriteLine("Массив случайных чисел: ");
  while (index < length)
  {
    Console.Write($"{collection[index]} ");
    index++;
  }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);