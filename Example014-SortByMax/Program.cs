int[] arr = { 1, 3, 8, 6, 2, 5, 6, 2, 9, 6, 4 };

void PrintArray(int[] array)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{array[i]}  ");
  }
}

void CollectionSort(int[] array)
{
  for (int i = array.Length-1; i>1; i--)
  {
    int maxPosition = i;
    for (int j = i - 1; j >0; j--)
    {
      if (array[j]>array[maxPosition]) maxPosition = j;
    }
    if (i != maxPosition)
    {
      int tmp = array[i];
      array[i] = array[maxPosition];
      array[maxPosition] = tmp;
    }
  }
}

CollectionSort(arr);
PrintArray(arr);