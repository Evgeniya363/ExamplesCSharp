int[] arr = {1,3,8,6,2,5,6,2,9,6,4};

void PrintArray(int[] array)
{
  for (int i=0; i<arr.Length; i++)
  {
    Console.Write($"{array[i]}  ");
  }
}

void CollectionSort(int[] array)
{
  for (int i=0; i<array.Length-1; i++)
  {
    int minPosition=i;
    for (int j=i+1; j<array.Length; j++)
    {
      if (array[j]< array[minPosition]) minPosition=j;
    }
    if (i!=minPosition)
    {
      int tmp=array[i];
      array[i]=array[minPosition];
      array[minPosition]=tmp;
    }
  }
}

CollectionSort(arr);
PrintArray(arr);