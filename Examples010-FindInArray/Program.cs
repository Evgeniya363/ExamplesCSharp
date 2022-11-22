// Найти максимальный элемент массива
int[] array = new int[] {12,42,75,92,35,76,98,34,56,34};
int count = array.Length;
int find = 76;
int position = -1;
int i = 0;

while(i < count) 
{
  if(array[i] == find) 
  {
    position = i;
    break;
  }
  i++;
}
Console.WriteLine(position);
