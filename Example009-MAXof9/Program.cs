// Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)
{
  int max = arg1;
  if (arg2 > max) max = arg2;
  if (arg3 > max) max = arg3;
  return max;
}

int a1 = 34, a2 = 54, a3 = 17;
int b1 = 36, b2 = 4, b3 = 87;
int c1 = 14, c2 = 58, c3 = 67;

int max = Max(
  Max(a1, a2, a3),
  Max(b1, b2, b3),
  Max(c1, c2, c3)
);
Console.WriteLine(max);
